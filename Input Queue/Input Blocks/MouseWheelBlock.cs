namespace WinEvents
{
	using SendInput;

	public partial class MouseWheelBlock : InputBlock
	{
		public override Input[] Input
		{
			get
			{
				int mouseData;
				if (radioButton_WheelUp.Checked)
					mouseData = (int)numericUpDown_WheelAmount.Value * 120;
				else if (radioButton_WheelDown.Checked)
					mouseData = (int)numericUpDown_WheelAmount.Value * -120;
				else mouseData = 0;

				MouseInput mouseInput = new()
				{
					Dx = 0,
					Dy = 0,
					Flags = MouseFlags.VerticalWheel,
					MouseData = mouseData,
					Time = 0,
					ExtraInfo = WinAPI.GetMessageExtraInfo(),
				};

				return [new(mouseInput)];
			}
		}

		public MouseWheelBlock()
		{
			InitializeComponent();
		}
	}
}
