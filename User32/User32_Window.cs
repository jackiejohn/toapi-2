﻿using System;
using System.Text;  // For StringBuilder
using System.Runtime.InteropServices;

using TOAPI.Types;


namespace TOAPI.User32
{
    /// <summary>
    /// This is the delegate for a windows procedure
    /// </summary>
    public delegate int WindowProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

    partial class User32
    {

        // Dealing with transparent windows
        [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        [DllImport("user32.dll", EntryPoint = "UpdateLayeredWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateLayeredWindow(IntPtr hWnd, IntPtr hdcDst,
            IntPtr pptDst, IntPtr psize,
            IntPtr hdcSrc, IntPtr pptSrc, uint crKey, IntPtr pblend, uint dwFlags);


        // Error handling
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClientRect(IntPtr hWnd, [Out] out RECT rect);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, [Out] out RECT rect);

        
        
        [DllImport("user32.dll", EntryPoint = "ClientToScreen")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ClientToScreen(IntPtr hWnd, ref POINT lpPoint);

        [DllImport("user32.dll", EntryPoint = "ScreenToClient")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScreenToClient(IntPtr hWnd, ref POINT lpPoint);


        // Window properties and longs
        [DllImport("user32.dll")]
        public static extern int RemoveProp(IntPtr hWnd, int atom);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProp(IntPtr hWnd, int atom, int data);

        [DllImport("user32.dll")]
        public static extern int GetProp(IntPtr hWnd, int atom);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetProp(IntPtr hWnd, string name);

        // SetWindowLong
        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        static extern WindowProc SetWindowLong(IntPtr hWnd, int nIndex, WindowProc newProc);

        public static WindowProc SetWindowProc(IntPtr hWnd, WindowProc aProc)
        {
            WindowProc oldProc = SetWindowLong(hWnd, User32.GWL_WNDPROC, aProc);
            return oldProc;
        }

        // GetWindowLong
        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        // GetWindowTextLength
        [DllImport("user32.dll")]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        // GetWindowText
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        
        [DllImportAttribute("user32.dll", EntryPoint = "SetWindowTextW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowTextW([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);

        // IsChild
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public extern static bool IsChild(int parent, int child);

        // IsWindowEnabled
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowEnabled(IntPtr hWnd);

        // IsWindowUnicode
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowUnicode(IntPtr hWnd);

        // IsWindowVisible
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowVisible(IntPtr hWnd);



        // AdjustWindowRectEx
        [DllImport("user32.dll")]
        public static extern int AdjustWindowRectEx(ref RECT lpRect, int dwStyle, bool bMenu, int dwExStyle);

        // MoveWindow
        [DllImport("user32.dll", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveWindow(IntPtr hWnd,
            int X, int Y,
            int nWidth, int nHeight,
            [MarshalAs(UnmanagedType.Bool)]bool bRepaint);

        // SetWindowPos
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);


        // EnableWindow
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnableWindow(IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool bEnable);

        // FindWindow
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string className, string windowName);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindow(IntPtr hWnd, int param);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        // SetActiveWindow
        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        public static extern IntPtr SetActiveWindow(IntPtr hWnd);

        // SetForegroundWindow
        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        // ShowWindow
        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        // ShowWindowAsync
        [DllImport("user32.dll", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        // ScrollWindow
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScrollWindow(IntPtr hWnd, int nXAmount, int nYAmount, ref RECT rectScrollRegion, ref RECT rectClip);

        // ScrollWindowEx
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScrollWindowEx(IntPtr hWnd, int nXAmount, int nYAmount, RECT rectScrollRegion, ref RECT rectClip, int hrgnUpdate, ref RECT prcUpdate, int flags);


        // Creating and getting a hold of window handles
        // Class registration
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterClass(String className, IntPtr hInstance);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort RegisterClass([In] ref WNDCLASS wc);

        // RegisterClassEx
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort RegisterClassEx([In] ref WNDCLASSEX wc);
        
        [DllImport("user32.dll", CharSet=CharSet.Ansi, EntryPoint = "RegisterClassExA")]
        public static extern ushort RegisterClassExA([In] ref WNDCLASSEXA wc);

        [DllImport("user32.dll", CharSet=CharSet.Unicode, EntryPoint = "RegisterClassExW")]
        public static extern ushort RegisterClassExW([In] ref WNDCLASSEXW wc);

        // GetClassInfo
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClassInfo(IntPtr hInst, [In] string lpszClass, [Out] out WNDCLASS wc);



        // CreateWindowEx
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CreateWindowEx(int dwExStyle,
            string lpszClassName,
            string lpszWindowName,
            int style,
            int x, int y, int width, int height,
            IntPtr hWndParent,
            IntPtr hMenu,
            IntPtr hInst,
            [MarshalAs(UnmanagedType.AsAny)] object pvParam);

        [DllImportAttribute("user32.dll", CharSet=CharSet.Ansi, EntryPoint = "CreateWindowExA")]
        public static extern IntPtr CreateWindowExA(uint dwExStyle, 
            [In] [MarshalAs(UnmanagedType.LPStr)] string lpClassName, 
            [InAttribute()] [MarshalAs(UnmanagedType.LPStr)] string lpWindowName, 
            uint dwStyle, 
            int X, int Y, int nWidth, int nHeight, 
            System.IntPtr hWndParent, 
            System.IntPtr hMenu, 
            System.IntPtr hInstance, 
            System.IntPtr lpParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "CreateWindowExW")]
        public static extern IntPtr CreateWindowExW(uint dwExStyle, 
            [In][MarshalAs(UnmanagedType.LPWStr)] string lpClassName, 
            [In][MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, 
            uint dwStyle, 
            int X, int Y, int nWidth, int nHeight, 
            IntPtr hWndParent, 
            IntPtr hMenu, 
            IntPtr hInstance, 
            IntPtr lpParam);


        // GetDesktopWindow
        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();

        // WindowFromPoint
        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(int x, int y);

        // DestroyWindow
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyWindow(IntPtr hWnd);


        // UpdateWindow
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateWindow(IntPtr hWnd);

        // DrawMenuBar
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawMenuBar(IntPtr hWnd);

        // LockWindowUpdate
        [DllImport("user32.dll", EntryPoint = "LockWindowUpdate")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LockWindowUpdate([In] IntPtr hWndLock);

        // RedrawWindow
        [DllImport("user32.dll", EntryPoint = "RedrawWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RedrawWindow([In] IntPtr hWnd, [In] ref RECT updateRect, [In] IntPtr hrgnUpdate, uint flags);

        // SetWindowRgn
        [DllImportAttribute("user32.dll", EntryPoint = "SetWindowRgn")]
        public static extern int SetWindowRgn([In] IntPtr hWnd, [In] IntPtr hRgn, [MarshalAs(UnmanagedType.Bool)] bool bRedraw);

        // WindowFromDC
        [DllImport("user32.dll", EntryPoint = "WindowFromDC")]
        public static extern IntPtr WindowFromDC([In] IntPtr hDC);

        // GetWindowRgn
        [DllImportAttribute("user32.dll", EntryPoint = "GetWindowRgn")]
        public static extern int GetWindowRgn([In] IntPtr hWnd, [In] IntPtr hRgn);

        // GetWindowRgnBox
        [DllImportAttribute("user32.dll", EntryPoint = "GetWindowRgnBox")]
        public static extern int GetWindowRgnBox([In] IntPtr hWnd, [Out] out RECT lprc);


    }
}
