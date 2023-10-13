namespace WinEvents
{
	using System.Diagnostics;
	using SetHook;
	using static SetHook.NativeMethods;

	public class Events
	{
		private static readonly HookProc _proc = HookCallback;
		private static IntPtr _hookId = IntPtr.Zero;

		public static void Main()
		{
			_hookId = SetHook(_proc);
			Application.Run();
			UnhookWindowsHookEx(_hookId);
		}

		private static IntPtr SetHook(HookProc proc)
		{
			using Process curProcess = Process.GetCurrentProcess();
			using ProcessModule? curModule = curProcess.MainModule;
			return SetWindowsHookEx(HookId.MouseLowLevel, proc, GetModuleHandle(curModule.ModuleName), 0);
		}

		public static Point PointFromLParam(IntPtr lParam)
		{
			return new((ushort)lParam, (ushort)lParam >> 16);
		}

		private static IntPtr HookCallback(int nCode, wParam wParam, IntPtr lParam)
		{
			if (nCode >= 0)
			{
				Console.WriteLine($"{nCode}, {wParam}, {Convert.ToString(lParam, 2)}");
			}
			return CallNextHookEx(0, nCode, wParam, lParam);
		}
	}
}
