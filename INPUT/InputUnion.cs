namespace WinEvents
{
	using System.Runtime.InteropServices;

	internal partial class NativeMethods
	{
		[StructLayout(LayoutKind.Explicit)]
		public struct InputUnion
		{
			[FieldOffset(0)]
			public MOUSEINPUT mouse;

			[FieldOffset(0)]
			public KEYBDINPUT keyboard;

			[FieldOffset(0)]
			public HARDWAREINPUT hardware;
		}
	}
}
