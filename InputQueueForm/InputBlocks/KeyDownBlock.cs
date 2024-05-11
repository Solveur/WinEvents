namespace WinEvents
{
	using System;
	using SendInput;


	public partial class KeyDownBlock : InputBlock
	{
		Input shiftDown = new(
			new KeyboardInput()
			{
				VirtualKeyCode = (ushort)Keys.ShiftKey,
				ScanCode = 0,
				Flags = KeyboardFlags.KeyDown,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);
		Input ctrlDown = new(
			new KeyboardInput()
			{
				VirtualKeyCode = (ushort)Keys.ControlKey,
				ScanCode = 0,
				Flags = KeyboardFlags.KeyDown,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);
		Input altDown = new(
			new KeyboardInput()
			{
				VirtualKeyCode = (ushort)Keys.Menu,
				ScanCode = 0,
				Flags = KeyboardFlags.KeyDown,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);
		Input winDown = new(
			new KeyboardInput()
			{
				VirtualKeyCode = (ushort)Keys.LWin,
				ScanCode = 0,
				Flags = KeyboardFlags.KeyDown,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);
		public override Input[] Input
		{
			get
			{
				Keys key = (Keys)(comboBox_Key.SelectedItem ?? 0);
				Input[] inputs = [
					checkBox_Shift.Checked ? shiftDown : new(),
					checkBox_Control.Checked ? ctrlDown : new(),
					checkBox_Alt.Checked ? altDown : new(),
					checkBox_Win.Checked ? winDown : new(),
					new
					(
						new KeyboardInput()
						{
							VirtualKeyCode = (ushort)key,
							ScanCode = 0,
							Flags = KeyboardFlags.KeyDown,
							Time = 0,
							ExtraInfo = WinAPI.GetMessageExtraInfo()
						}
					),
				];
				return inputs;
			}
		}

		public KeyDownBlock()
		{
			InitializeComponent();
			comboBox_Key.DataSource = Enum.GetValues<Keys>();
		}
	}
}
