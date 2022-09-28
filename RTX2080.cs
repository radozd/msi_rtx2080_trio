// Decompiled with JetBrains decompiler
// Type: MysticLight_AllDevice.Device.GPU.NVIDIA.RTX2080_TRIO
// Assembly: MysticLight_AllDevice, Version=1.0.0.63, Culture=neutral, PublicKeyToken=null
// MVID: EF87C2E4-42B0-49E8-84DC-2ADA40AA2D42

using System;
using System.Threading;

namespace RTX2080
{
	public class RTX2080_TRIO
	{
		public static int NDA_GetGPUCounts()
		{
			long count;
			Class_NDA.NDA_GetGPUCounts(out count);
			return Convert.ToInt32(count);
		}

		public bool Set_Style(Style style)
		{
			bool flag = Class_NDA.NDA_SetI2C(0, 208, 34, (int)style);
			Thread.Sleep(20);
			return flag;
		}

		public bool Set_Brightness(byte brightness)
		{
			if( brightness > 100 )
				return false;
			bool flag2 = Class_NDA.NDA_SetI2C(0, 208, 54, brightness) && Class_NDA.NDA_SetI2C(1, 208, 54, brightness);
			Thread.Sleep(20);
			return flag2;
		}

		public bool Set_Speed(Speed speed)
		{
			if( speed != Speed.Low && speed != Speed.Medium && speed != Speed.High )
				return false;
			bool flag2 = Class_NDA.NDA_SetI2C(0, 208, 56, (byte)speed) && Class_NDA.NDA_SetI2C(1, 208, 56, (byte)speed);
			Thread.Sleep(20);
			return flag2;
		}

		public bool Set_Color(byte r, byte g, byte b)
		{
			Set_Brightness(100);
			var flag1 = Class_NDA.NDA_SetI2C(0, 208, 48, r) && Class_NDA.NDA_SetI2C(1, 208, 48, r);
			Thread.Sleep(20);
			var flag2 = Class_NDA.NDA_SetI2C(0, 208, 49, g);
			var flag3 = flag1 && flag2 && Class_NDA.NDA_SetI2C(1, 208, 49, g);
			Thread.Sleep(20);
			var flag4 = Class_NDA.NDA_SetI2C(0, 208, 50, b);
			var flag5 = flag3 && flag4 && Class_NDA.NDA_SetI2C(1, 208, 50, b);
			Thread.Sleep(20);
			return flag5;
		}

		public bool Set_Color_AutoRgbShift(byte r, byte g, byte b)
		{
			int r1 = r;
			int g1 = g;
			int b1 = b;
			int num1 = 0;
			var array = new []{ r1, g1, b1 };
			Array.Sort(array);
			foreach( int num2 in array )
			{
				if( num2 != 0 )
				{
					num1 = num2;
					break;
				}
			}
			if( num1 != 0 && (r < 10 || g < 10 || b < 10) && r1+g1+b1 < 30 )
			{
				byte num3 = (byte) (10 / num1 + (10 % num1 > 0 ? 1 : 0));
				r1 = r*num3;
				g1 = g*num3;
				b1 = b*num3;
				if( r1 > byte.MaxValue )
					r1 = byte.MaxValue;
				if( g1 > byte.MaxValue )
					g1 = byte.MaxValue;
				if( b1 > byte.MaxValue )
					b1 = byte.MaxValue;
			}
			return Set_Color((byte)r1, (byte)g1, (byte)b1);
		}

		public bool Style_Static(byte r, byte g, byte b)
		{
			return Set_Color(r, g, b) && Set_Style(Style.Static);
		}

		public bool Style_Breathe(byte r, byte g, byte b)
		{
			Set_Speed(Speed.Medium);
			return Set_Color(r, g, b) && Set_Style(Style.Breathing);
		}

		public bool Style_Flashing(byte r, byte g, byte b)
		{
			Set_Speed(Speed.Medium);
			return Set_Color(r, g, b) && Set_Style(Style.Flashing);
		}

		public bool Style_Rainbow()
		{
			Set_Speed(Speed.Medium);
			return Set_Style(Style.Rainbow);
		}

		public enum Style
		{
			Off = 1,
			Flashing = 2,
			DualFlashing = 3,
			Breathing = 4,
			Patrolling = 5,
			Streaming = 6,
			Magic = 7,
			Rainbow = 8,
			Flowing = 9,
			FlowingRainbow = 10, // 0x0000000A
			Rhythm = 11, // 0x0000000B
			RhythmRainbow = 12, // 0x0000000C
			Stack = 13, // 0x0000000D
			StackRainbow = 14, // 0x0000000E
			Whirling = 15, // 0x0000000F
			WhirlingRainbow = 16, // 0x00000010
			Twisting = 17, // 0x00000011
			TwistingRainbow = 18, // 0x00000012
			Static = 19, // 0x00000013
			FadeIn = 20, // 0x00000014
			Lightning = 21, // 0x00000015
			Meteor = 22, // 0x00000016
			MeteorRainbow = 23, // 0x00000017
			Marquee = 24, // 0x00000018
			MarqueeRainbow = 25, // 0x00000019
			RainDrop = 26, // 0x0000001A
			RainDropRainbow = 27, // 0x0000001B
			Laminating = 28, // 0x0000001C
			LaminatingRainbow = 29, // 0x0000001D
			Wave = 30, // 0x0000001E
		}

		public enum Speed
		{
			High = 1,
			Medium = 2,
			Low = 4,
		}
	}
}
