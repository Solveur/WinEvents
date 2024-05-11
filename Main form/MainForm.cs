namespace WinEvents
{
	using System;
	using System.Windows.Forms;
	using SendInput;
	using System.Collections;
	using System.Linq;
	using System.Runtime.InteropServices;
	using Hooks;
	using System.Reflection.Metadata.Ecma335;
	using System.Runtime.CompilerServices;

	public partial class MainForm : Form
	{
		Input[] inputs = [];
		Input mouseDown = new(
			new MouseInput()
			{
				Dx = 0,
				Dy = 0,
				Flags = MouseFlags.LeftDown,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);

		Input mouseUp = new(
			new MouseInput()
			{
				Dx = 0,
				Dy = 0,
				Flags = MouseFlags.LeftUp,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);

		Input mouseMove = new(
			new MouseInput()
			{
				Dx = 100,
				Dy = 0,
				Flags = MouseFlags.Move,
				Time = 0,
				ExtraInfo = WinAPI.GetMessageExtraInfo()
			}
		);

		public MainForm()
		{
			InitializeComponent();
			MouseHook mh = new();
			mh.MouseDown += Mh_MouseDown;
			mh.Start();
		}

		private async void Mh_MouseDown(object? sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.XButton2)
				await WinAPI.SendInputAsync(inputs);
			//WinAPI.SendInputAsync([mouseUp, mouseDown, mouseMove, mouseUp]);

		}

		private void Button_AddOverride_Click(object sender, EventArgs e)
		{
			InputOverride newOverride = new();
			flowLayoutPanel_InputOverrides.Controls.Add(newOverride);
			int index = flowLayoutPanel_InputOverrides.Controls.GetChildIndex(button_AddOverride);
			flowLayoutPanel_InputOverrides.Controls.SetChildIndex(newOverride, index);
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			InputQueueForm qf = new();
			qf.ShowDialog();
			inputs = qf.Inputs;
		}
	}
}
