namespace WinEvents
{
	using System.Runtime.InteropServices;

	[StructLayout(LayoutKind.Explicit)]
	internal struct WordUnion
	{
		[FieldOffset(0)]
		public IntPtr Word;

		[FieldOffset(0)]
		public ushort Low;

		[FieldOffset(4)]
		public ushort High;
	}
}
