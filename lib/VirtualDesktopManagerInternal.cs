// Port from https://github.com/Grabacr07/VirtualDesktop
using System;
using System.Runtime.InteropServices;

namespace LTCountDownTimer.lib
{
    public delegate IVirtualDesktop CurrentDesktopGetter();

    public static class VirtualDesktopManagerInternal
    {
        public static CurrentDesktopGetter _GetCurrentDesktopGetter()
        {
            try
            {
                var shellType = Type.GetTypeFromCLSID(new Guid("c2f03a33-21f5-47fa-b4bb-156362a2f239"));
                var shell = Activator.CreateInstance(shellType) as IServiceProvider;

                object ppvObject;
                var guidService = new Guid("c5e0cdca-7b6e-41b2-9fc4-d93975cc467b");

                shell.QueryService(ref guidService, typeof(IVirtualDesktopManagerInternalG1).GUID, out ppvObject);
                if (ppvObject != null)
                    return (ppvObject as IVirtualDesktopManagerInternalG1).GetCurrentDesktop;

                shell.QueryService(ref guidService, typeof(IVirtualDesktopManagerInternalG2).GUID, out ppvObject);
                if (ppvObject != null)
                    return (ppvObject as IVirtualDesktopManagerInternalG2).GetCurrentDesktop;

                shell.QueryService(ref guidService, typeof(IVirtualDesktopManagerInternalG3).GUID, out ppvObject);
                if (ppvObject != null)
                    return (ppvObject as IVirtualDesktopManagerInternalG3).GetCurrentDesktop;

                return null;
            }
            catch (COMException e) when (e.ErrorCode == -2147221164 /* E_CLASSNOTREG */)
            {
                return null;
            }
        }
    }
}
