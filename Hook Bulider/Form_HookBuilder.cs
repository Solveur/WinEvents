namespace WinEvents
{
	using System;
	using System.Windows.Forms;
	using Hooks;

	public partial class Form_HookBuilder : Form
	{


		// Default values of radio buttons checked by deafult. By UI/UX guidelines
		private MouseHook.MouseEventType _mouseEventToCatch = MouseHook.MouseEventType.MouseMove;
		private MouseButtons _buttonToCatch = MouseButtons.Left;
		private MessageType _keyboardEventToCatch = MessageType.KeyDown;
		/// <summary>
		/// <see langword="true"/> up, <see langword="false"/> down.
		/// </summary>
		bool _wheelDirection = true;

		public MessageType KeyboardEventType => _keyboardEventToCatch;
		public MouseHook.MouseEventType MouseEventType => _mouseEventToCatch;
		public Hook Hook
		{
			get
			{
				return HookType switch
				{
					HookType.MouseLL => new ConditionalMouseHook()
					{
						EventToCatch = _mouseEventToCatch,
						ButtonToCatch = _buttonToCatch,
						WheelDirection = _wheelDirection,
						BlockPropagation = checkBox_BlockMousePropagation.Checked
					},
					HookType.KeyboardLL => new ConditionalKeyboardHook()
					{
						EventToCatch = _keyboardEventToCatch,
						KeyToCatch = (Keys?)comboBox_Key.SelectedItem ?? Keys.None,
						BlockPropagation = checkBox_BlockKeyboardPropagation.Checked
					},
					_ => throw new NotImplementedException()
				};
			}
		}

		public HookType HookType
		{
			get
			{
				return tabControl1.SelectedIndex switch
				{
					0 => HookType.MouseLL,
					1 => HookType.KeyboardLL,
					_ => throw new NotImplementedException()
				};
			}
		}

		public Form_HookBuilder()
		{
			InitializeComponent();
			comboBox_Key.DataSource = Enum.GetValues<InputBlock._Keys>();
		}

		private void RadioButton_ActionMouseMove_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_ActionMove.Checked)
			{
				groupBox_MouseButton.Enabled = false;
				groupBox_MouseWheel.Enabled = false;
				_mouseEventToCatch = MouseHook.MouseEventType.MouseMove;
			}
		}

		private void RadioButton_ActionMouseDown_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_ActionMouseDown.Checked)
			{
				groupBox_MouseButton.Enabled = true;
				groupBox_MouseWheel.Enabled = false;
				_mouseEventToCatch = MouseHook.MouseEventType.MouseDown;
			}
		}

		private void RadioButton_ActionMouseUp_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_ActionMouseUp.Checked)
			{
				groupBox_MouseButton.Enabled = true;
				groupBox_MouseWheel.Enabled = false;
				_mouseEventToCatch = MouseHook.MouseEventType.MouseUp;
			}
		}

		private void RadioButton_ActionMouseWheel_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_ActionWheel.Checked)
			{
				groupBox_MouseButton.Enabled = false;
				groupBox_MouseWheel.Enabled = true;
				_mouseEventToCatch = MouseHook.MouseEventType.MouseWheel;
			}
		}

		private void RadioButton_ButtonLMB_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_ButtonLMB.Checked)
				_buttonToCatch = MouseButtons.Left;
		}

		private void RadioButton_ButtonMMB_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_ButtonMMB.Checked)
				_buttonToCatch = MouseButtons.Middle;
		}

		private void RadioButton_ButtonRMB_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_ButtonRMB.Checked)
				_buttonToCatch = MouseButtons.Right;
		}

		private void RadioButton_ButtonMB4_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_ButtonMB4.Checked)
				_buttonToCatch = MouseButtons.XButton2;
		}

		private void RadioButton_ButtonMB5_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_ButtonMB5.Checked)
				_buttonToCatch = MouseButtons.XButton1;
		}

		private void RadioButton_KeyboardKeyDown_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_KeyboardKeyDown.Checked)
				_keyboardEventToCatch = MessageType.KeyDown;
		}

		private void RadioButton_KeyboardKeyUp_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_KeyboardKeyUp.Checked)
				_keyboardEventToCatch = MessageType.KeyUp;
		}

		private void radioButton_MouseWheelUp_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_MouseWheelUp.Checked)
				_wheelDirection = true;
		}

		private void radioButton_WheelDown_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_MouseWheelDown.Checked)
				_wheelDirection = false;
		}
	}
}
