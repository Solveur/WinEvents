namespace WinEvents
{
	using System;
	using SendInput;

	public partial class KeyUpBlock : KeyboardInputBlock
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
					Flags = KeyboardFlags.KeyUp,
					Time = 0,
					ExtraInfo = WinAPI.GetMessageExtraInfo()
				};

				Input[] inputs = 
				[
					new(keyboardInput),
					checkBox_Shift.Checked ? _shiftUp : new(),
					checkBox_Control.Checked ? _ctrlUp : new(),
					checkBox_Alt.Checked ? _altUp : new(),
					checkBox_Win.Checked ? _winUp : new(),
				];
				return inputs;
			}
		}

		public KeyUpBlock()
		{
			InitializeComponent();
			comboBox_Key.DataSource = Enum.GetValues<_Keys>();
		}
	}
}
