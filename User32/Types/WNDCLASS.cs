﻿using System;
using System.Runtime.InteropServices;

using TOAPI.Types;

namespace TOAPI.User32
{

    #region WNDCLASS
    /// <summary>
    /// An definition of the Basic Window Class structure that is
    /// used for CreateWindow
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct WNDCLASS
    {
        public uint style;
        public MessageProc lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public IntPtr hInstance;
        public IntPtr hIcon;
        public IntPtr hCursor;
        public IntPtr hbrBackground;
        public string lpszMenuName;
        public string lpszClassName;
    }
    #endregion

    #region WNDCLASSEX
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct WNDCLASSEX
    {
        public int cbSize;
        public int style;
        public MessageProc lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public IntPtr hInstance;
        public IntPtr hIcon;
        public IntPtr hCursor;
        public IntPtr hbrBackground;
        public string lpszMenuName;
        public string lpszClassName;
        public IntPtr hIconSm;

        public void Init()
        {
            cbSize = Marshal.SizeOf(this);
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WNDCLASSEXA
    {
        public uint cbSize;
        public uint style;
        public MessageProc lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public IntPtr hInstance;
        public IntPtr hIcon;
        public IntPtr hCursor;
        public IntPtr hbrBackground;
        public string lpszMenuName;
        public string lpszClassName;
        public IntPtr hIconSm;

        public void Init()
        {
            cbSize = (uint)Marshal.SizeOf(this);
        }
    }


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WNDCLASSEXW
    {
        public uint cbSize;
        public uint style;
        public MessageProc lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public System.IntPtr hInstance;
        public System.IntPtr hIcon;
        public System.IntPtr hCursor;
        public System.IntPtr hbrBackground;
        public string lpszMenuName;
        public string lpszClassName;
        public System.IntPtr hIconSm;

        public void Init()
        {
            cbSize = (uint)Marshal.SizeOf(this);
        }

    }
    #endregion
}
