// Port from https://github.com/Grabacr07/VirtualDesktop
using System;
using System.Runtime.InteropServices;

namespace LTCountDownTimer.lib
{
    public static class VirtualDesktopManagerInternal
    {
        public static IVirtualDesktopManagerInternal CreateInstance()
        {
            try
            {
                var shellType = Type.GetTypeFromCLSID(new Guid("c2f03a33-21f5-47fa-b4bb-156362a2f239"));
                var shell = Activator.CreateInstance(shellType) as IServiceProvider;

                object ppvObject;
                //var guidService = new Guid("aa509086-5ca9-4c25-8f95-589d3c07b48a");
                var guidService = new Guid("c5e0cdca-7b6e-41b2-9fc4-d93975cc467b");
                shell.QueryService(ref guidService, typeof(IVirtualDesktopManagerInternal).GUID, out ppvObject);

                return ppvObject as IVirtualDesktopManagerInternal;
            }
            catch (COMException e) when (e.ErrorCode == -2147221164 /* E_CLASSNOTREG */)
            {
                return null;
            }
        }
    }
}
