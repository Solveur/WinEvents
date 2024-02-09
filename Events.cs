namespace WinEvents
{
	using System.Diagnostics;
	using System.Runtime.InteropServices;
	using SetHook;
	using static SetHook.NativeMethods;
	using SendInput;
	using static SendInput.MouseMethods;
	using static SendInput.KeyboardMethods;

	public static class Events
	{
		public static void Main()
		{
			//Hook mouse = new(HookType.MouseLowLevel, MouseCallback);
			//Hook keyboard = new(HookType.KeyboardLowLevel, KeyboardCallback);

			//mouse.Set();
			//keyboard.Set();
			//Application.Run();
			//mouse.Unset();
			//keyboard.Unset();
			Application.Run(new Form1());
		}

		private static Point PointFromLParam(IntPtr lParam)
		{
			IntPtr coords = (IntPtr)Marshal.ReadInt64(lParam);
			DWord point = new(coords);

			ushort x = point.Low;
			ushort y = point.High;

			return new(x, y);
		}

		private static IntPtr MouseCallback(int nCode, wParam wParam, IntPtr lParam)
		{
			if (nCode >= 0 && wParam != wParam.MouseMove)
			{
				Point point = PointFromLParam(lParam);
				IntPtr window = WindowFromPoint(point);
				Console.WriteLine($"{nCode}, {wParam}, {PointFromLParam(lParam)}, {window}");
			}
			return CallNextHookEx(0, nCode, wParam, lParam);
		}

		private static IntPtr KeyboardCallback(int nCode, wParam wParam, IntPtr lParam)
		{
			Keys key = (Keys)Marshal.ReadInt32(lParam);
			if (nCode >= 0)
			{
				Console.WriteLine($"{nCode}, {wParam}, {key}");
			}
			return CallNextHookEx(0, nCode, wParam, lParam);
		}
	}
}
