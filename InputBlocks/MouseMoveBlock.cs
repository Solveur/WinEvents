namespace WinEvents.InputBlocks
{
	using System;
	using System.Windows.Forms;
	using SendInput;

	public partial class MouseMoveBlock : InputControl
	{
		public override Input Input
		{
			get
			{
				MouseFlags absolute = checkBox_Place.Checked ? MouseFlags.Absolute : MouseFlags.None;
				int x = Convert.ToInt32(numericUpDown_X.Value);
				int y = Convert.ToInt32(numericUpDown_Y.Value);
				int screenWidth = Screen.PrimaryScreen?.Bounds.Width ?? 1920;
				int screenHeight = Screen.PrimaryScreen?.Bounds.Height ?? 1080;
				int xNormalized = (int)((double)x / screenWidth * ushort.MaxValue);
				int yNormalized = (int)((double)y / screenHeight * ushort.MaxValue);
				MouseInput input = new()
				{
					Dx = checkBox_Place.Checked ? xNormalized : x,
					Dy = checkBox_Place.Checked ? yNormalized : y,
					Flags = MouseFlags.Move | absolute,
					Time = 0,
					ExtraInfo = WinAPI.GetMessageExtraInfo()
				};
				return new Input(input);
			}
		}

		public MouseMoveBlock()
		{
			InitializeComponent();
		}
	}
}
