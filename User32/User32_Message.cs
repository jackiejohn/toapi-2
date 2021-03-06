﻿using System;
using System.Text;  // For StringBuilder
using System.Runtime.InteropServices;

using TOAPI.Types;

namespace TOAPI.User32
{
    partial class User32
    {
        public delegate void CallbackFunction();

        // Posting Messages
        // PostMessage
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int PostMessage(IntPtr hwnd, int msg, int wparam, int lparam);

        // PostQuitMessage
        [DllImport("user32.dll")]
        public static extern void PostQuitMessage(int nExitCode);

        // PostThreadMessage
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostThreadMessage(uint idThread, uint msg,
            [MarshalAsAttribute(UnmanagedType.SysUInt)] uint wParam,
            [MarshalAsAttribute(UnmanagedType.SysInt)] int lParam);

        // PostThreadMessage
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostThreadMessage(uint idThread, uint Msg,
            IntPtr wParam, IntPtr lParam);

        // SendMessage
        [DllImportAttribute("user32.dll", EntryPoint = "SendMessageW")]
        public static extern int SendMessageW([In] IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);


        [DllImportAttribute("user32.dll", EntryPoint = "SendMessageW")]
        public static extern int SendMessageW([In] IntPtr hWnd, int Msg, uint wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        //[DllImportAttribute("user32.dll", EntryPoint = "SendMessageW")]
        //[return: MarshalAsAttribute(UnmanagedType.SysInt)]
        //public static extern int SendMessageW([In] IntPtr hWnd, int Msg, UIntPtr wParam, IntPtr lParam);

        //[DllImportAttribute("user32.dll", EntryPoint = "SendMessageW")]
        //[return: MarshalAsAttribute(UnmanagedType.SysInt)]
        //public static extern int SendMessageW([In] IntPtr hWnd, int Msg, [MarshalAs(UnmanagedType.SysUInt)] uint wParam, [MarshalAs(UnmanagedType.SysInt)] CallbackFunction fnProc);

        // TranslateMessage
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TranslateMessage([In] ref MSG msg);

        // DispatchMessage
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr DispatchMessage([In] ref MSG msg);

        // GetMessage
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMessage([Out] out MSG msg, IntPtr hWnd, uint uMsgFilterMin, uint uMsgFilterMax);

        // GetMessageExtraInfo
        [DllImport("user32.dll", EntryPoint = "GetMessageExtraInfo")]
        public static extern IntPtr GetMessageExtraInfo();

        // PeekMessage
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekMessage([Out] out MSG msg, IntPtr hwnd, uint msgMin, uint msgMax, uint remove);

        // WaitMessage
        [DllImport("user32.dll")]
        public static extern void WaitMessage();



        /// <summary>
        /// User32 Calls
        /// </summary>
        // CallWindowProc
        [DllImport("user32.dll")]
        public static extern int CallWindowProc(IntPtr wndProc, IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet=CharSet.Auto)]
        public static extern int DefWindowProc(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

    }
}
