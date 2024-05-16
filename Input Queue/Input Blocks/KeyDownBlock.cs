namespace WinEvents
{
	using System;
	using SendInput;


	public partial class KeyDownBlock : KeyboardInputBlock
	{
		public override Input[] Input
		{
			get
			{
				_Keys key = (_Keys)(comboBox_Key.SelectedItem ?? 0);

				KeyboardInput keyboardInput = new()
				{
					VirtualKeyCode = (ushort)key,
					ScanCode = 0,
					Flags = KeyboardFlags.KeyDown,
					Time = 0,
					ExtraInfo = WinAPI.GetMessageExtraInfo()
				};

				Input[] inputs =
				[
					checkBox_Shift.Checked ? _shiftDown : new(),
					checkBox_Control.Checked ? _ctrlDown : new(),
					checkBox_Alt.Checked ? _altDown : new(),
					checkBox_Win.Checked ? _winDown : new(),
					new(keyboardInput),
					checkBox_Shift.Checked ? _shiftUp : new(),
					checkBox_Control.Checked ? _ctrlUp : new(),
					checkBox_Alt.Checked ? _altUp : new(),
					checkBox_Win.Checked ? _winUp : new(),
				];

				return inputs;
			}
		}

		public KeyDownBlock()
		{
			InitializeComponent();
			comboBox_Key.DataSource = Enum.GetValues<_Keys>();
		}
	}
}
