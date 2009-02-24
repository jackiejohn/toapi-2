﻿using System;
using System.Runtime.InteropServices;

namespace TOAPI.Kernel32
{
    [StructLayoutAttribute(LayoutKind.Sequential)]
    public struct OVERLAPPED
    {
        public uint Internal;
        public uint InternalHigh;
        public Anonymous_09c34f72_48f5_4ebf_8c58_0e5ed7358919 Union1;
        public IntPtr hEvent;
    }

    [StructLayoutAttribute(LayoutKind.Explicit)]
    public struct Anonymous_09c34f72_48f5_4ebf_8c58_0e5ed7358919
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_17a2e8a7_9186_49d2_b3c5_2153812bf61f Struct1;
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public System.IntPtr Pointer;
    }

    [StructLayoutAttribute(LayoutKind.Sequential)]
    public struct Anonymous_17a2e8a7_9186_49d2_b3c5_2153812bf61f
    {

        /// DWORD->unsigned int
        public uint Offset;

        /// DWORD->unsigned int
        public uint OffsetHigh;
    }
}