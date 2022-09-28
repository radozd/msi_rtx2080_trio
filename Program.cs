using System;
using System.Globalization;
using System.Security.Principal;

namespace RTX2080
{
	class Program
	{
		private static bool IsAdministrator => new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);

		private static bool ParseHexColor(string color, out byte r, out byte g, out byte b)
		{
			//string colorcode = "#FFEEDDCC";
			int rgb;
			if( !Int32.TryParse(color.Replace("#", ""), NumberStyles.HexNumber, null, out rgb) )
			{
				r = g = b = 0;
				return false;
			}

			r = (byte)((rgb & 0xff0000) >> 16);
			g = (byte)((rgb & 0xff00) >> 8);
			b = (byte)(rgb & 0xff);
			return true;
		}

		static void Main(string[] args)
		{
			if( args.Length < 1 )
			{
				Console.WriteLine("Usage: RTX2080.exe <static|breathe|flashing|rainbow> [hex color]");
				return;
			}

			byte r=255, g=255, b=0;
			if( args.Length == 2 && !ParseHexColor(args[1], out r, out g, out b) )
			{
				Console.WriteLine("Bad color format. Use html hex (FFFF00)");
				return;
			}

			if( !IsAdministrator )
			{
				Console.WriteLine("Need admin rights");
				return;
			}

			if( !Class_NDA.NDA_Initialize() )
			{
				Console.WriteLine("Failed to initialize NDA");
				return;
			}

			if( RTX2080_TRIO.NDA_GetGPUCounts() == 0 )
			{
				Console.WriteLine("GPU not found");
				return;
			}

			NDA_GraphicsInfo graphicsInfo;
			if( !Class_NDA.NDA_GetGraphicsInfo(0, out graphicsInfo) )
			{
				Console.WriteLine("Failed to retrieve GPU info");
				return;
			}

			if( graphicsInfo.Card_FullName != "NVIDIA GeForce RTX 2080" )
			{
				Console.WriteLine("Unsupported video card");
				return;
			}

			var trio = new RTX2080_TRIO();

			bool res = false;
			switch( args[0] )
			{
			case "static":   res = trio.Style_Static(r, g, b); break;
			case "breathe":  res = trio.Style_Breathe(r, g, b); break;
			case "flashing": res = trio.Style_Flashing(r, g, b); break;
			case "rainbow":  res = trio.Style_Rainbow(); break;
			}
			Console.WriteLine(res ? "success":"error");

			Class_NDA.NDA_Unload();
		}
	}
}
