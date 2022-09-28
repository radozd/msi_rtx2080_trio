﻿// Decompiled with JetBrains decompiler
// Type: MysticLight_AllDevice.NDA_GraphicsInfo
// Assembly: MysticLight_AllDevice, Version=1.0.0.63, Culture=neutral, PublicKeyToken=null
// MVID: EF87C2E4-42B0-49E8-84DC-2ADA40AA2D42

using System.Runtime.InteropServices;

namespace RTX2080
{
	public struct NDA_GraphicsInfo
	{
		internal int iAdapterIndex;
		internal bool IsPrimaryDisplay;
		[MarshalAs(UnmanagedType.BStr)]
		internal string DisplayName;
		[MarshalAs(UnmanagedType.BStr)]
		internal string Card_PNP;
		[MarshalAs(UnmanagedType.BStr)]
		internal string Card_pDeviceId;
		[MarshalAs(UnmanagedType.BStr)]
		internal string Card_pSubSystemId;
		[MarshalAs(UnmanagedType.BStr)]
		internal string Card_pRevisionId;
		[MarshalAs(UnmanagedType.BStr)]
		internal string Card_FullName;
		[MarshalAs(UnmanagedType.BStr)]
		internal string Card_BIOS_Date;
		[MarshalAs(UnmanagedType.BStr)]
		internal string Card_BIOS_PartNumber;
		[MarshalAs(UnmanagedType.BStr)]
		internal string Card_BIOS_Version;
		internal int GPU_Usage;
		internal int GPU_Clock_Current;
		internal int GPU_Clock_Base;
		internal int GPU_Clock_Set;
		internal int GPU_Clock_Max;
		internal int GPU_Clock_Min;
		internal int VRAM_Usage;
		internal int VRAM_Clock_Current;
		internal int VRAM_Clock_Base;
		internal int VRAM_Clock_Max;
		internal int VRAM_Clock_Min;
		internal int GPU_Temperature_Current;
		internal float GPU_Voltage_Current;
		internal int GPU_FanPercent_Current;
		internal int GPU_PowerLimit_Current;
		internal int Memory_TotalSize;
		internal int Memory_TypeID;
		internal int Memory_BusWidth;
	}
}
