﻿using System;
using System.Text;
using System.Runtime.InteropServices;

using TOAPI.Types;

namespace TOAPI.WinMM
{
    public partial class winmm
    {
        // WaveInAddBuffer
        [DllImportAttribute("winmm.dll", EntryPoint = "waveInAddBuffer")]
        public static extern int waveInAddBuffer(IntPtr hwi, ref WAVEHDR pwh, int cbwh);

        [DllImportAttribute("winmm.dll", EntryPoint = "waveInAddBuffer")]
        public static extern int waveInAddBuffer(IntPtr hwi, IntPtr pwh, int cbwh);

        
        // WaveInClose
        [DllImportAttribute("winmm.dll", EntryPoint = "waveInClose")]
        public static extern int waveInClose(IntPtr hwi);

        // WaveInGetDevCaps
        [DllImportAttribute("winmm.dll", EntryPoint = "waveInGetDevCapsW")]
        public static extern int waveInGetDevCapsW(IntPtr uDeviceID, ref WAVEINCAPSW pwic, int cbwic);

        // WaveInGetErrorText
        [DllImportAttribute("winmm.dll", EntryPoint = "waveInGetErrorTextW")]
        public static extern int waveInGetErrorTextW(int mmrError, [MarshalAsAttribute(UnmanagedType.LPWStr)] StringBuilder pszText, int cchText);

        // WaveInGetID
        [DllImport("winmm.dll", EntryPoint = "waveInGetID")]
        public static extern int waveInGetID(IntPtr hwi, ref int puDeviceID);

        // WaveInGetNumDevs
        [DllImport("winmm.dll", EntryPoint = "waveInGetNumDevs")]
        public static extern int waveInGetNumDevs();

        // WaveInGetPosition
        [DllImportAttribute("winmm.dll", EntryPoint = "waveInGetPosition")]
        public static extern int waveInGetPosition(IntPtr hwi, ref MMTIME pmmt, int cbmmt);

        // WaveInMessage
        [DllImport("winmm.dll", EntryPoint = "waveInMessage")]
        public static extern int waveInMessage(IntPtr hwi, int uMsg, int dw1, int dw2);

        // WaveInOpen
        [DllImportAttribute("winmm.dll", EntryPoint = "waveInOpen")]
        public static extern int waveInOpen(ref IntPtr phwi, int uDeviceID, ref WAVEFORMATEX pwfx, WaveAudioProc dwCallback, IntPtr dwInstance, int fdwOpen);

        // WaveInPrepareHeader
        [DllImport("winmm.dll", EntryPoint = "waveInPrepareHeader")]
        public static extern int waveInPrepareHeader(IntPtr hwi, ref WAVEHDR pwh, int cbwh);

        [DllImport("winmm.dll", EntryPoint = "waveInPrepareHeader")]
        public static extern int waveInPrepareHeader(IntPtr hwi, IntPtr pwh, int cbwh);

        // WaveInReset
        [DllImportAttribute("winmm.dll", EntryPoint = "waveInReset")]
        public static extern int waveInReset(IntPtr hwi);

        // WaveInStart
        [DllImportAttribute("winmm.dll", EntryPoint = "waveInStart")]
        public static extern int waveInStart(IntPtr hwi);

        // WaveInStop
        [DllImportAttribute("winmm.dll", EntryPoint = "waveInStop")]
        public static extern int waveInStop(IntPtr hwi);

        // WaveInUnprepareHeader
        [DllImportAttribute("winmm.dll", EntryPoint = "waveInUnprepareHeader")]
        public static extern int waveInUnprepareHeader(IntPtr hwi, ref WAVEHDR pwh, int cbwh);

        [DllImportAttribute("winmm.dll", EntryPoint = "waveInUnprepareHeader")]
        public static extern int waveInUnprepareHeader(IntPtr hwi, IntPtr pwh, int cbwh);
    }
}
