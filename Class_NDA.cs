// Decompiled with JetBrains decompiler
// Type: MysticLight_AllDevice.Class_NDA
// Assembly: MysticLight_AllDevice, Version=1.0.0.63, Culture=neutral, PublicKeyToken=null
// MVID: EF87C2E4-42B0-49E8-84DC-2ADA40AA2D42

using System.Runtime.InteropServices;

namespace RTX2080
{
	public class Class_NDA
	{
		public const string NDA_DLL_FILE_NAME = "NDA.dll";

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_Initialize();

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_Unload();

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_GetGPUCounts(out long GpuCounts);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_GetGraphicsInfo(
		  int iAdapterIndex,
		  out NDA_GraphicsInfo graphicsInfo);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_SetFanSpeedPercent(int iAdapterIndex, int FanSpeedPercent);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_SetFanSpeedPercentForI2C(
		  int iAdapterIndex,
		  byte i2cDeviceAddr,
		  byte RegAddr,
		  int FanSpeedPercent);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_SetGPUClock(int iAdapterIndex, int GPUClock);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_SetGPUClock_2(int iAdapterIndex, int GPUClock, int Memory);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_SetGPUClock_Destroy(int iAdapterIndex, int GPUClock);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_Get_G_Sync(out bool G_Sync_State);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_Set_G_Sync(bool G_Sync_State);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_GetGPUClock(int iAdapterIndex, out int GPUClock);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_SetMemoryClock(int iAdapterIndex, int GPUClock);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_SetMemoryClock_2(int iAdapterIndex, int GPUClock);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_SetPowerCap(int iAdapterIndex, float power);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_SetDefaultFanSpeed();

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_QueryIlluminationSupport(int iAdapterIndex, int Attribute);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_SetIlluminationParm(int iAdapterIndex, int Attribute, int Value);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_SetIlluminationParmColor(
		  int iAdapterIndex,
		  int cmd,
		  int led1,
		  int led2,
		  int ontime,
		  int offtime,
		  int chgtime,
		  int darktime,
		  int duty,
		  bool One = false);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_SetIlluminationParmColor_RGB(
		  int iAdapterIndex,
		  int cmd,
		  int led1,
		  int led2,
		  int ontime,
		  int offtime,
		  int time,
		  int darktime,
		  int bright,
		  int r,
		  int g,
		  int b,
		  bool One = false);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_SetIlluminationParmColor_Music(
		  int iAdapterIndex,
		  int led,
		  int bright,
		  int r,
		  int g,
		  int b);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_GetIlluminationParm(
		  int iAdapterIndex,
		  int Attribute,
		  out int Value);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_SetGPUVoltage(int iAdapterIndex, int Voltage);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_GetFanSpeed(int iAdapterIndex, out int Value);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_GetFanRPM(int iAdapterIndex, int FanIndex, out int Value);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_GetVoltage(int iAdapterIndex, out int Value);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_GetVoltage_2(int iAdapterIndex, out int Value);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_SetIlluminationControl(string SLI_Command);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NDA_CheckSLIConnected();

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_SetI2C(int iAdapterIndex, int DAddress, int RAddress, int cmd);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_SetI2C_Block(
		  int iAdapterIndex,
		  int DAddress,
		  int RAddress,
		  byte[] cmd,
		  int size);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_Nu_SetAllShowInfo(
		  int iAdapterIndex,
		  int FanSpeed,
		  int Temperature,
		  int Frequency,
		  int Usage);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_Nu_SetShowInfo(int iAdapterIndex, int Type, int Data);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_Nu_SetShowPage(int iAdapterIndex, int Type, int Data);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_Nu_UploadGif(int iAdapterIndex, string filename);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_Nu_GetUploadInfo(out int FileLenth, out int UpIndex);

		[DllImport(NDA_DLL_FILE_NAME, CharSet = CharSet.Unicode)]
		public static extern bool NDA_GetMemoryUsed(int iAdapterIndex, out int MemoryUsed);
	}
}
