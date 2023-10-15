namespace WinEvents
{
	using System.Diagnostics;
	using SetHook;
	using SendInput.Input;
	using static SetHook.NativeMethods;

	public class Hook
	{
		public HookType Type { get; init; }
		public HookProc? Procedure { get; set; }
		private List<InputStruct> record = new();
		private IntPtr hook = IntPtr.Zero;

		public void Set()
		{
			using Process curProcess = Process.GetCurrentProcess();
			using ProcessModule? curModule = curProcess.MainModule;
			hook = SetWindowsHookEx(Type, Procedure, GetModuleHandle(curModule?.ModuleName ?? "0"), 0);
		}
		
		public bool Unset()
		{
			return UnhookWindowsHookEx(hook);
		}
	}
}
