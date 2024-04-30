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

		private void button1_Click(object sender, EventArgs e)
		{
			InputQueueForm nf = new();
			nf.ShowDialog();
			Input[] inputs = nf.Inputs;
			MessageBox.Show(inputs.Length.ToString());
		}
	}
}
