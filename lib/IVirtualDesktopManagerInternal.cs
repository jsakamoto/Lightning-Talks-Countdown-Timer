﻿// Port from https://github.com/Grabacr07/VirtualDesktop
using System;
using System.Runtime.InteropServices;

namespace LTCountDownTimer.lib
{
    [ComImport]
    [Guid("ef9f1a6c-d3cc-4358-b712-f84b635bebe7")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IVirtualDesktopManagerInternalG1
    {
        int GetCount();

        void MoveViewToDesktop(object pView, IVirtualDesktop desktop);

        bool CanViewMoveDesktops(object pView);

        IVirtualDesktop GetCurrentDesktop();

        IObjectArray GetDesktops();

        IVirtualDesktop GetAdjacentDesktop(IVirtualDesktop pDesktopReference, AdjacentDesktop uDirection);

        void SwitchDesktop(IVirtualDesktop desktop);

        IVirtualDesktop CreateDesktopW();

        void RemoveDesktop(IVirtualDesktop pRemove, IVirtualDesktop pFallbackDesktop);

        IVirtualDesktop FindDesktop(ref Guid desktopId);
    }

    [ComImport]
    [Guid("af8da486-95bb-4460-b3b7-6e7a6b2962b5")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IVirtualDesktopManagerInternalG2
    {
        int GetCount();

        void MoveViewToDesktop(object pView, IVirtualDesktop desktop);

        bool CanViewMoveDesktops(object pView);

        IVirtualDesktop GetCurrentDesktop();

        IObjectArray GetDesktops();

        IVirtualDesktop GetAdjacentDesktop(IVirtualDesktop pDesktopReference, AdjacentDesktop uDirection);

        void SwitchDesktop(IVirtualDesktop desktop);

        IVirtualDesktop CreateDesktopW();

        void RemoveDesktop(IVirtualDesktop pRemove, IVirtualDesktop pFallbackDesktop);

        IVirtualDesktop FindDesktop(ref Guid desktopId);
    }

    [ComImport]
    [Guid("f31574d6-b682-4cdc-bd56-1827860abec6")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IVirtualDesktopManagerInternalG3
    {
        int GetCount();

        void MoveViewToDesktop(object pView, IVirtualDesktop desktop);

        bool CanViewMoveDesktops(object pView);

        IVirtualDesktop GetCurrentDesktop();

        IObjectArray GetDesktops();

        IVirtualDesktop GetAdjacentDesktop(IVirtualDesktop pDesktopReference, AdjacentDesktop uDirection);

        void SwitchDesktop(IVirtualDesktop desktop);

        IVirtualDesktop CreateDesktopW();

        void RemoveDesktop(IVirtualDesktop pRemove, IVirtualDesktop pFallbackDesktop);

        IVirtualDesktop FindDesktop(ref Guid desktopId);
    }
}
