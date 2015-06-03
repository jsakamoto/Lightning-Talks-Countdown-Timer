#include "stdafx.h"

void ReadPFXFile(LPCWSTR fileName, CRYPT_DATA_BLOB *pPFX)
{
	HANDLE hCertFile = NULL;
	DWORD cbRead = 0;
	DWORD dwFileSize = 0, dwFileSizeHi = 0;

	hCertFile = CreateFile(fileName,
		GENERIC_READ, FILE_SHARE_READ,
		NULL, OPEN_EXISTING, 0, NULL);
	dwFileSize = GetFileSize(hCertFile, &dwFileSizeHi);
	pPFX->pbData =
		(BYTE *) CryptMemAlloc(dwFileSize*sizeof(BYTE));
	pPFX->cbData = dwFileSize;
	ReadFile(hCertFile,
		pPFX->pbData, pPFX->cbData, &cbRead, NULL);
	CloseHandle(hCertFile);
}

void GetPrivateKey(CRYPT_DATA_BLOB pPFX, LPCWSTR szPassword, HCRYPTPROV *hCPContext)
{

	HCERTSTORE hCertStore = NULL;
	PCCERT_CONTEXT hCertContext = NULL;
	DWORD dwKeySpec = AT_SIGNATURE;
	BOOL bFreeCertKey = TRUE;

	hCertStore =
		PFXImportCertStore(&pPFX, szPassword, CRYPT_EXPORTABLE);
	hCertContext = CertEnumCertificatesInStore(hCertStore, NULL);
	CryptAcquireCertificatePrivateKey(hCertContext,
		0, NULL, hCPContext, &dwKeySpec, &bFreeCertKey);
	CertCloseStore(hCertStore, CERT_CLOSE_STORE_FORCE_FLAG);
}

void MakeNewCert(HCRYPTPROV hCPContext, LPCWSTR szCertName, LPCWSTR szPassword, CRYPT_DATA_BLOB *pPFX)
{
	CERT_NAME_BLOB certNameBlob = { 0, NULL };
	PCCERT_CONTEXT hCertContext = NULL;
	SYSTEMTIME certExpireDate;
	HCERTSTORE hTempStore = NULL;

	CertStrToName(X509_ASN_ENCODING | PKCS_7_ASN_ENCODING,
		szCertName, CERT_OID_NAME_STR, NULL, NULL,
		&certNameBlob.cbData, NULL);
	certNameBlob.pbData =
		(BYTE *) CryptMemAlloc(sizeof(BYTE)*certNameBlob.cbData);
	CertStrToName(X509_ASN_ENCODING | PKCS_7_ASN_ENCODING,
		szCertName, CERT_OID_NAME_STR, NULL,
		certNameBlob.pbData, &certNameBlob.cbData, NULL);

	GetSystemTime(&certExpireDate);
	certExpireDate.wYear += 5;

	hCertContext = CertCreateSelfSignCertificate(hCPContext,
		&certNameBlob, 0, NULL, NULL, NULL,
		&certExpireDate, NULL);
	hTempStore = CertOpenStore(CERT_STORE_PROV_MEMORY,
		0, NULL, CERT_STORE_CREATE_NEW_FLAG, 0);
	CertAddCertificateContextToStore(hTempStore,
		hCertContext, CERT_STORE_ADD_NEW, NULL);
	PFXExportCertStoreEx(hTempStore, pPFX, szPassword, NULL,
		EXPORT_PRIVATE_KEYS);
	pPFX->pbData =
		(BYTE *) CryptMemAlloc(sizeof(BYTE)*pPFX->cbData);
	PFXExportCertStoreEx(hTempStore, pPFX, szPassword, NULL,
		EXPORT_PRIVATE_KEYS);

	CryptMemFree(certNameBlob.pbData);
	CertCloseStore(hTempStore, CERT_CLOSE_STORE_FORCE_FLAG);
	CertFreeCertificateContext(hCertContext);
}

void WritePFX(CRYPT_DATA_BLOB pPFX, LPCWSTR szOutputFile)
{
	HANDLE hOutputFile = NULL;
	DWORD cbWritten = 0;

	hOutputFile = CreateFile(szOutputFile,
		GENERIC_READ | GENERIC_WRITE, 0, NULL, CREATE_ALWAYS,
		FILE_FLAG_SEQUENTIAL_SCAN, NULL);
	WriteFile(hOutputFile, pPFX.pbData, pPFX.cbData,
		&cbWritten, NULL);
	CloseHandle(hOutputFile);
}

int _tmain(int argc, _TCHAR* argv [])
{
	LPCWSTR szCertFileName = NULL;
	CRYPT_DATA_BLOB pPFX;
	LPCWSTR szPassword = NULL;
	HCRYPTPROV hCPContext = NULL;
	LPCWSTR szCertName = L"CN=NewCert";
	CRYPT_DATA_BLOB pPfxOutputBlob = { 0, NULL };
	LPCWSTR szOutFile = NULL;

	// 以下でコマンドラインを解析します。
	if (argc == 1)
	{
		printf("renewcert [optional]\n");
		printf("Example: renewcert oldcert.pfx newcert.pfx CN=MyNewCert\" MySuperSecretPassword");
		return 0;
	}

	if (argc >= 2)
		szCertFileName = argv[1];

	if (argc >= 3)
		szOutFile = argv[2];

	// 【注意】必ず"CN="という形式にしてください。
	if (argc >= 4)
		szCertName = argv[3];

	if (argc >= 5)
		szPassword = argv[4];

	// 以下でデジタル証明書（.pfxファイル）を更新します。
	ReadPFXFile(szCertFileName, &pPFX);

	GetPrivateKey(pPFX, szPassword, &hCPContext);

	MakeNewCert(hCPContext, szCertName, szPassword,
		&pPfxOutputBlob);

	WritePFX(pPfxOutputBlob, szOutFile);

	// メモリなどをクリーン・アップします。
	CryptReleaseContext(hCPContext, 0);
	CryptMemFree(pPfxOutputBlob.pbData);
	CryptMemFree(pPFX.pbData);

	return 0;
}