namespace WinEvents
{
	using System.ComponentModel;
	using SendInput;

	[TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<KeyboardInputBlock, UserControl>))]
	public abstract partial class KeyboardInputBlock : InputBlock
	{
		protected Input _shiftDown = new(
			new KeyboardInput()
			{
				VirtualKeyCode = (ushort)_Keys.ShiftKey,
				ScanCode = 0,
				Flags = KeyboardFlags.KeyDown,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);

		protected Input _ctrlDown = new(
			new KeyboardInput()
			{
				VirtualKeyCode = (ushort)_Keys.ControlKey,
				ScanCode = 0,
				Flags = KeyboardFlags.KeyDown,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);

		protected Input _altDown = new(
			new KeyboardInput()
			{
				VirtualKeyCode = (ushort)_Keys.Menu,
				ScanCode = 0,
				Flags = KeyboardFlags.KeyDown,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);

		protected Input _winDown = new(
			new KeyboardInput()
			{
				VirtualKeyCode = (ushort)_Keys.LWin,
				ScanCode = 0,
				Flags = KeyboardFlags.KeyDown,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);


		protected Input _shiftUp = new(
			new KeyboardInput()
			{
				VirtualKeyCode = (ushort)_Keys.ShiftKey,
				ScanCode = 0,
				Flags = KeyboardFlags.KeyUp,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);

		protected Input _ctrlUp = new(
			new KeyboardInput()
			{
				VirtualKeyCode = (ushort)_Keys.ControlKey,
				ScanCode = 0,
				Flags = KeyboardFlags.KeyUp,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);

		protected Input _altUp = new(
			new KeyboardInput()
			{
				VirtualKeyCode = (ushort)_Keys.Menu,
				ScanCode = 0,
				Flags = KeyboardFlags.KeyUp,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);

		protected Input _winUp = new(
			new KeyboardInput()
			{
				VirtualKeyCode = (ushort)_Keys.LWin,
				ScanCode = 0,
				Flags = KeyboardFlags.KeyUp,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);
	}
}
