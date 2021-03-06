﻿using System;
using System.Runtime.InteropServices;

namespace TOAPI.Types
{

    [StructLayoutAttribute(LayoutKind.Sequential)]
    public struct WAVEFORMAT
    {
        public ushort wFormatTag;       /// WORD->unsigned short
        public ushort nChannels;        /// Number of channels of data
        public uint nSamplesPerSec;     /// Number of samples per second.  This is essentially doubling the sampling frequency
        public uint nAvgBytesPerSec;    /// Number of bytes per second
        public ushort nBlockAlign;      /// WORD->unsigned short
    }

    [StructLayoutAttribute(LayoutKind.Sequential)]
    public struct WAVEFORMATEX
    {
        public ushort wFormatTag;       /// WAVE_FORMAT.PCM, 
        public ushort nChannels;        /// 1 or 2
        public uint nSamplesPerSec;     /// 
        public uint nAvgBytesPerSec;    /// DWORD->unsigned int
        public ushort nBlockAlign;      /// WORD->unsigned short
        public ushort wBitsPerSample;   /// WORD->unsigned short
        public ushort cbSize;           /// 0 == PCM, otherwise, more specific
    }
}
