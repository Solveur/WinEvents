namespace WinEvents.SendInput
{
	using System.Runtime.InteropServices;

	/// <summary>
	/// Used by SendInput to store information for synthesizing input events such as keystrokes, mouse movement, and mouse clicks.
	/// </summary>
	public struct Input
	{
		public InputType type;
		public InputUnion union;
	}

	public enum InputType : int
	{
		Mouse = 0,
		Keyboard = 1,
		Hardware = 2
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct InputUnion
	{
		[FieldOffset(0)]
		public MouseInput mouse;

		[FieldOffset(0)]
		public KeyboardInput keyboard;

		[FieldOffset(0)]
		public HardwareInput hardware;
	}
}
