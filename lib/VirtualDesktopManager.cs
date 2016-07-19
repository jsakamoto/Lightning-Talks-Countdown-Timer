// Port from https://github.com/Grabacr07/VirtualDesktop
using System;
using System.Runtime.InteropServices;

namespace LTCountDownTimer.lib
{
    public static class VirtualDesktopManager
    {
        public static IVirtualDesktopManager CreateInstance()
        {
            try
            {
                var vdmType = Type.GetTypeFromCLSID(new Guid("aa509086-5ca9-4c25-8f95-589d3c07b48a"));
                var instance = Activator.CreateInstance(vdmType);

                return instance as IVirtualDesktopManager;
            }
            catch (COMException e) when (e.ErrorCode == -2147221164 /* E_CLASSNOTREG */)
            {
                return null;
            }
        }
    }
}
