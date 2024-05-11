namespace WinEvents
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

	public partial class StringInputBlock : InputBlock
	{
		public override Input[] Input
		{
			get
			{
				string text = textBox_String.Text;
				List<Input> inputs = [];
				foreach (char c in text)
				{
					var keyDown = new KeyboardInput()
					{
						VirtualKeyCode = 0,
						ScanCode = c,
						Flags = KeyboardFlags.KeyDown | KeyboardFlags.Unicode,
						Time = 0,
						ExtraInfo = WinAPI.GetMessageExtraInfo()
					};
					var keyUp = new KeyboardInput()
					{
						VirtualKeyCode = 0,
						ScanCode = c,
						Flags = KeyboardFlags.KeyUp | KeyboardFlags.Unicode,
						Time = 0,
						ExtraInfo = WinAPI.GetMessageExtraInfo()
					};
					inputs.Add(new(keyDown));
					inputs.Add(new(keyUp));
				}
				return [.. inputs];
			}
		}

		public StringInputBlock()
		{
			InitializeComponent();
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;

			Visible = false;
			Parent?.DoDragDrop(this, DragDropEffects.Move);
			Visible = true;
		}
	}
}
