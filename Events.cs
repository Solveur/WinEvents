namespace WinEvents
{
	using System.Diagnostics;
	using System.Runtime.InteropServices;
	using SetHook;
	using static SetHook.NativeMethods;

	public static class Events
	{
		private static IntPtr _hookId = IntPtr.Zero;

		public static void Main()
		{
			_hookId = SetHook(HookCallback);
			Application.Run();
			UnhookWindowsHookEx(_hookId);
		}

		private static IntPtr SetHook(HookProc proc)
		{
			using Process curProcess = Process.GetCurrentProcess();
			using ProcessModule? curModule = curProcess.MainModule;
			return SetWindowsHookEx(HookId.KeyboardLowLevel, proc, GetModuleHandle(curModule?.ModuleName ?? "0"), 0);
		}

		[StructLayout(LayoutKind.Explicit)]
		private struct WordUnion
		{
			[FieldOffset(0)]
			public IntPtr Word;

			[FieldOffset(0)]
			public ushort Low;

			[FieldOffset(4)]
			public ushort High;
		}

		private static Point PointFromLParam(IntPtr lParam)
		{
			IntPtr coords = (IntPtr)Marshal.ReadInt64(lParam);
			WordUnion point = new() {Word = coords};
			return new(point.High, point.Low);
		}
		
		private static IntPtr HookCallback(int nCode, wParam wParam, IntPtr lParam)
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
