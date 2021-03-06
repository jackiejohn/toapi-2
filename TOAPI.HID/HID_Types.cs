﻿using System;
using System.Runtime.InteropServices;

namespace TOAPI.HID
{

    [StructLayout(LayoutKind.Sequential)]
    internal struct HIDD_ATTRIBUTES
    {
        internal Int32 Size;
        internal Int16 VendorID;
        internal Int16 ProductID;
        internal Int16 VersionNumber;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct HIDP_CAPS
    {
        internal Int16 Usage;
        internal Int16 UsagePage;
        internal Int16 InputReportByteLength;
        internal Int16 OutputReportByteLength;
        internal Int16 FeatureReportByteLength;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)]
        internal Int16[] Reserved;
        internal Int16 NumberLinkCollectionNodes;
        internal Int16 NumberInputButtonCaps;
        internal Int16 NumberInputValueCaps;
        internal Int16 NumberInputDataIndices;
        internal Int16 NumberOutputButtonCaps;
        internal Int16 NumberOutputValueCaps;
        internal Int16 NumberOutputDataIndices;
        internal Int16 NumberFeatureButtonCaps;
        internal Int16 NumberFeatureValueCaps;
        internal Int16 NumberFeatureDataIndices;
    }

    //  If IsRange is false, UsageMin is the Usage and UsageMax is unused.
    //  If IsStringRange is false, StringMin is the String index and StringMax is unused.
    //  If IsDesignatorRange is false, DesignatorMin is the designator index and DesignatorMax is unused.

    [StructLayout(LayoutKind.Sequential)]
    internal struct HidP_Value_Caps
    {
        internal Int16 UsagePage;
        internal Byte ReportID;
        internal Int32 IsAlias;
        internal Int16 BitField;
        internal Int16 LinkCollection;
        internal Int16 LinkUsage;
        internal Int16 LinkUsagePage;
        internal Int32 IsRange;
        internal Int32 IsStringRange;
        internal Int32 IsDesignatorRange;
        internal Int32 IsAbsolute;
        internal Int32 HasNull;
        internal Byte Reserved;
        internal Int16 BitSize;
        internal Int16 ReportCount;
        internal Int16 Reserved2;
        internal Int16 Reserved3;
        internal Int16 Reserved4;
        internal Int16 Reserved5;
        internal Int16 Reserved6;
        internal Int32 LogicalMin;
        internal Int32 LogicalMax;
        internal Int32 PhysicalMin;
        internal Int32 PhysicalMax;
        internal Int16 UsageMin;
        internal Int16 UsageMax;
        internal Int16 StringMin;
        internal Int16 StringMax;
        internal Int16 DesignatorMin;
        internal Int16 DesignatorMax;
        internal Int16 DataIndexMin;
        internal Int16 DataIndexMax;
    }

}