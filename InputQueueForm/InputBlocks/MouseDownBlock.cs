namespace WinEvents.InputBlocks
{
	using System;
	using SendInput;

	public partial class MouseDownBlock : InputBlock
	{
		private MouseFlags button = MouseFlags.LeftDown;
		private int mouseData = 0;

		public override Input[] Input
		{
			get
			{
				MouseInput input = new()
				{
					Dx = 0,
					Dy = 0,
					Flags = button,
					MouseData = mouseData,
					Time = 0,
					ExtraInfo = WinAPI.GetMessageExtraInfo(),
				};
				return [new(input)];
			}
		}

		public MouseDownBlock()
		{
			InitializeComponent();
		}

		private void RadioButton_LMB_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_LMB.Checked)
				button = MouseFlags.LeftDown;
		}

		private void RadioButton_MMB_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_MMB.Checked)
				button = MouseFlags.MiddleDown;
		}

		private void RadioButton_RMB_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_RMB.Checked)
				button = MouseFlags.RightDown;
		}

		private void RadioButton_MB4_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_MB4.Checked)
			{
				button = MouseFlags.XDown;
				mouseData = 0x0001;
			}
			else
				mouseData = 0;

		}

		private void RadioButton_MB5_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_MB5.Checked)
			{
				button = MouseFlags.XDown;
				mouseData = 0x0002;
			}
			else
				mouseData = 0;
		}
	}
}
