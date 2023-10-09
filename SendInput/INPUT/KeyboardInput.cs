namespace WinEvents
{
	using System;
	using System.Runtime.InteropServices;

	internal partial class NativeMethods
	{
		/// <summary>
		/// Contains information about a simulated keyboard event.
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct KeyboardInput
		{
			public ushort virtualKey;
			public ushort scanCode;
			public KeyboardFlags flags;
			public uint timeStamp;
			public IntPtr extraInfo;
		}
	}
}
