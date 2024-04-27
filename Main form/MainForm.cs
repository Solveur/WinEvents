namespace WinEvents
{
	using System;
	using System.Windows.Forms;
	using SendInput;
	using System.Collections;
	using System.Linq;

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Button1_AddOverride_Click(object sender, EventArgs e)
		{
			InputOverride newOverride = new();
			flowLayoutPanel1.Controls.Add(newOverride);
			int index = flowLayoutPanel1.Controls.GetChildIndex(button1_AddOverride);
			flowLayoutPanel1.Controls.SetChildIndex(newOverride, index);
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Input[] inputs = GetInputs(flowLayoutPanel2.Controls);
			WinAPI.SendInput(inputs);
		}

		private static Input[] GetInputs(Control.ControlCollection collection)
		{
			return [.. collection.OfType<InputControl>().Cast<InputControl>().Select(con => con.Input)];
		}
	}
}
