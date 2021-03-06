﻿using System;
using System.Text;  // For StringBuilder
using System.Runtime.InteropServices;

using TOAPI.Types;

namespace TOAPI.User32
{
    // DrawStateProc
    // Used with - DrawState
    public delegate int DrawStateProc(IntPtr hdc, IntPtr lData, IntPtr wData, int cx, int cy);

    // OutputProc
    // Used with DrawGrayString
    public delegate int OutputProc(IntPtr hDC, IntPtr lpData, int cchData);

    partial class User32
    {
        // Dealing with drawing
        // GetSysColorBrush
        [DllImport("user32.dll")]
        public static extern IntPtr GetSysColorBrush(int nIndex);

        // GetSysColor
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetSysColor(int nIndex);


        // BeginPaint
        [DllImport("user32.dll", EntryPoint = "BeginPaint")]
        public static extern IntPtr BeginPaint(IntPtr hWnd, [Out] out PAINTSTRUCT lpPaint);

        // EndPaint
        [DllImport("user32.dll", EntryPoint = "EndPaint")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndPaint(IntPtr hWnd, [In] ref PAINTSTRUCT lpPaint);


        // DrawState
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawState(IntPtr hdc, IntPtr hbrFore, DrawStateProc qfnCallBack, IntPtr lData, IntPtr wData, int x, int y, int cx, int cy, uint uFlags);


        // ExcludeUpdateRgn
        [DllImport("user32.dll")]
        public static extern int ExcludeUpdateRgn(IntPtr hDC, IntPtr hWnd);



        // Device Context
        // GetDCEx
        [DllImport("user32.dll", EntryPoint = "GetDCEx", CharSet = CharSet.Auto)]
        public static extern IntPtr GetDCEx(IntPtr hWnd, IntPtr hrgnClip, DeviceContextValues flags);

        // GetDC
        [DllImport("user32.dll", EntryPoint = "GetDC", CharSet = CharSet.Auto)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        //        384  17F 00010083 GetWindowDC
        [DllImport("user32.dll", EntryPoint = "GetWindowDC", CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        // ReleaseDC
        [DllImport("user32.dll", EntryPoint = "ReleaseDC", CharSet = CharSet.Auto)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        

        // GetUpdateRect
        [DllImportAttribute("user32.dll", EntryPoint = "GetUpdateRect")]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetUpdateRect([In] IntPtr hWnd, 
            IntPtr lpRect, 
            [MarshalAs(UnmanagedType.Bool)] bool bErase);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetUpdateRect(IntPtr hWnd,
            ref RECT lpRect,
            [MarshalAs(UnmanagedType.Bool)]bool bErase);


        // GetUpdateRgn
        [DllImport("user32.dll", EntryPoint = "GetUpdateRgn")]
        public static extern int GetUpdateRgn([In] IntPtr hWnd, [In] IntPtr hRgn, [MarshalAs(UnmanagedType.Bool)] bool bErase);

        // InvalidateRect
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InvalidateRect(IntPtr hWnd, ref RECT rect, bool erase);

        // InvalidateRect
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InvalidateRect(IntPtr hWnd, IntPtr rect, bool erase);

        // ValidateRect
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ValidateRect(IntPtr hWnd, ref RECT rect);

        // InvalidateRgn
        [DllImport("user32.dll", EntryPoint = "InvalidateRgn")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InvalidateRgn([In] IntPtr hWnd, [In] IntPtr hRgn, [MarshalAs(UnmanagedType.Bool)] bool bErase);

        // ValidateRgn
        [DllImport("user32.dll", EntryPoint = "ValidateRgn")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ValidateRgn([In] IntPtr hWnd, [In] IntPtr hRgn);


        // Dealing with rectangles
        // DrawAnimatedRects
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "DrawAnimatedRects")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawAnimatedRects(IntPtr hwnd, int idAni, [In] ref RECT lprcFrom,
            [In] ref RECT lprcTo);


        // DrawFocusRect
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawFocusRect(SafeHandle hDC, [In] ref RECT lprc);
        
        // FillRect
        [DllImport("user32.dll")]
        public static extern int FillRect(SafeHandle hDC, [In] ref RECT rect, IntPtr hbr);

        // FrameRect
        [DllImport("user32.dll")]
        public static extern int FrameRect(SafeHandle hDC, [In] ref RECT rect, IntPtr hbr);

        // InvertRect
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "InvertRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InvertRect([In] SafeHandle hDC, [In] ref RECT lprc);

        // DrawEdge
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawEdge(SafeHandle hDC, ref RECT rect, int edge, int flags);

        // DrawFrameControl
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawFrameControl(SafeHandle hDC, 
            ref RECT rect, 
            int type, int state);

        // DrawIconEx
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawIconEx(SafeHandle hDC, int x, int y, int hIcon, int width, int height, int iStepIfAniCursor, int hBrushFlickerFree, int diFlags);

        // DrawCaption
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawCaption(IntPtr hwnd, SafeHandle hdc, [In] ref RECT rect, uint uFlags);




        // Drawing Text
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int DrawText(SafeHandle hDC,
            StringBuilder lpszString,
            int nCount, ref RECT lpRect, uint nFormat);

        // DrawTextEx
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int DrawTextEx(SafeHandle hdc, 
            StringBuilder lpchText, int cchText,
            ref RECT lprc, 
            uint dwDTFormat, 
            ref DRAWTEXTPARAMS lpDTParams);

        // GrayString
    }
}
