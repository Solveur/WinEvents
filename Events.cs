namespace WinEvents
{
	using System.Diagnostics;
	using System.Runtime.InteropServices;
	using SetHook;
	using static SetHook.NativeMethods;

	public static class Events
	{
		public static void Main()
		{
			Hook mouse = new Hook()
			{
					Type = HookType.MouseLowLevel,
					Procedure = MouseCallback
			};
			Hook keyboard = new Hook()
			{
					Type = HookType.KeyboardLowLevel,
					Procedure = KeyboardCallback
			};

			mouse.Set();
			keyboard.Set();
			Application.Run();
			mouse.Unset();
			keyboard.Unset();
		}

		private static IntPtr SetHook(HookType type, HookProc proc)
		{
			using Process curProcess = Process.GetCurrentProcess();
			using ProcessModule? curModule = curProcess.MainModule;
			return SetWindowsHookEx(type, proc, GetModuleHandle(curModule?.ModuleName ?? "0"), 0);
		}

		private static Point PointFromLParam(IntPtr lParam)
		{
			IntPtr coords = (IntPtr)Marshal.ReadInt64(lParam);
			WordUnion point = new() {Word = coords};

			ushort x = point.High;
			if (x == ushort.MaxValue)
				x = 0;

			ushort y = point.Low;
			if (y == ushort.MaxValue)
				y = 0;

			return new(x, y);
		}

		private static HookProc MouseCallback(int nCode, wParam wParam, IntPtr lParam)
		{
			if (nCode >= 0 && wParam != wParam.MouseMove)
			{
				Console.WriteLine($"{nCode}, {wParam}, {PointFromLParam(lParam)}");
			}
			return CallNextHookEx(0, nCode, wParam, lParam);
		}

		private static HookProc KeyboardCallback(int nCode, wParam wParam, IntPtr lParam)
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
