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
			flowLayoutPanel_InputOverrides.Controls.Add(newOverride);
			int index = flowLayoutPanel_InputOverrides.Controls.GetChildIndex(button1_AddOverride);
			flowLayoutPanel_InputOverrides.Controls.SetChildIndex(newOverride, index);
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Input[] inputs = GetInputs(flowLayoutPanel_TestSurface.Controls);
			WinAPI.SendInput(inputs);
		}

		private static Input[] GetInputs(Control.ControlCollection collection)
		{
			return [.. collection.OfType<InputControl>().Cast<InputControl>().Select(con => con.Input)];
		}

		private void flowLayoutPanel_TestSurface_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}
	}
}
