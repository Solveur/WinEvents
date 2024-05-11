namespace WinEvents.InputBlocks
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using System.Windows.Forms;
	using SendInput;
	using static System.Windows.Forms.VisualStyles.VisualStyleElement;

	public partial class KeyUpBlock : InputBlock
	{
		Input shiftUp = new(
			new KeyboardInput()
			{
				VirtualKeyCode = (ushort)Keys.ShiftKey,
				ScanCode = 0,
				Flags = KeyboardFlags.KeyUp,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);
		Input ctrlUp = new(
			new KeyboardInput()
			{
				VirtualKeyCode = (ushort)Keys.ControlKey,
				ScanCode = 0,
				Flags = KeyboardFlags.KeyUp,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);
		Input altUp = new(
			new KeyboardInput()
			{
				VirtualKeyCode = (ushort)Keys.Menu,
				ScanCode = 0,
				Flags = KeyboardFlags.KeyUp,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);
		Input winUp = new(
			new KeyboardInput()
			{
				VirtualKeyCode = (ushort)Keys.LWin,
				ScanCode = 0,
				Flags = KeyboardFlags.KeyUp,
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
					new
					(
						new KeyboardInput()
						{
							VirtualKeyCode = (ushort)key,
							ScanCode = 0,
							Flags = KeyboardFlags.KeyUp,
							Time = 0,
							ExtraInfo = WinAPI.GetMessageExtraInfo()
						}
					),
					checkBox_Shift.Checked ? shiftUp : new(),
					checkBox_Control.Checked ? ctrlUp : new(),
					checkBox_Alt.Checked ? altUp : new(),
					checkBox_Win.Checked ? winUp : new(),
				];
				return inputs;
			}
		}

		public KeyUpBlock()
		{
			InitializeComponent();
			comboBox_Key.DataSource = Enum.GetValues<Keys>();
		}
	}
}
