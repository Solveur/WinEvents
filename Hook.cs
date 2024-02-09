namespace WinEvents
{
	using System.Diagnostics;
	using SetHook;
	using static SetHook.NativeMethods;

	public class Hook
	{
		public HookType Type { get; init; }
		public HookProc Procedure { get; set; }
		private IntPtr hook = IntPtr.Zero;
		private IntPtr module = IntPtr.Zero;

		public Hook(HookType type)
		{
			Type = type;
			Procedure = (n, wp, lp) => CallNextHookEx(0, n, wp, lp);

			using Process curProcess = Process.GetCurrentProcess();
			using ProcessModule? curModule = curProcess.MainModule;
			module = GetModuleHandle(curModule?.ModuleName ?? "0");
		}

		public Hook(HookType type, HookProc proc)
		{
			Type = type;
			Procedure = proc;

			using Process curProcess = Process.GetCurrentProcess();
			using ProcessModule? curModule = curProcess.MainModule;
			module = GetModuleHandle(curModule?.ModuleName ?? "0");
		}

		public void Set()
		{
			hook = SetWindowsHookEx(Type, Procedure, module, 0);
		}
		
		public bool Unset()
		{
			return UnhookWindowsHookEx(hook);
		}

		~Hook()
		{
			Unset();
		}
	}
}
