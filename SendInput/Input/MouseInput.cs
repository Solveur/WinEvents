namespace WinEvents.SendInput
{
	using System.Runtime.InteropServices;

	/// <summary>
	/// Contains information about a simulated mouse event.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct MouseInput
	{
		public long deltaX;
		public long deltaY;
		public int mouseData;
		public MouseFlags flags;
		public uint time;
		public IntPtr extraInfo;
	}
}
