using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LTCountDownTimer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var option = LoadOption();
            Application.Run(new MainForm(option));
            SaveOption(option);
        }

        const string configFilName = "config.json";

        private static Option LoadOption()
        {
            using (var isoStore = IsolatedStorageFile.GetUserStoreForDomain())
            {
                var names = isoStore.GetFileNames(configFilName);
                if (names.Length == 0) return new Option();

                using (var stream = new IsolatedStorageFileStream(names[0], FileMode.Open, FileAccess.Read, isoStore))
                using (var reader = new StreamReader(stream, Encoding.UTF8))
                {
                    var jsonText = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<Option>(jsonText);
                }
            }
        }

        private static void SaveOption(Option option)
        {
            using (var isoStore = IsolatedStorageFile.GetUserStoreForDomain())
            {
                using (var stream = new IsolatedStorageFileStream(configFilName, FileMode.Create, FileAccess.Write, isoStore))
                using (var writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    var jsonText = JsonConvert.SerializeObject(option);
                    writer.Write(jsonText);
                }
            }
        }

    }
}
