namespace WinEvents
{
	using System;
	using System.Reflection;
	using System.Windows.Forms;

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void button1_AddOverride_Click(object sender, EventArgs e)
		{
			InputOverride newOverride = new();
			flowLayoutPanel1.Controls.Add(newOverride);
			int index = flowLayoutPanel1.Controls.GetChildIndex(button1_AddOverride);
			flowLayoutPanel1.Controls.SetChildIndex(newOverride, index);
		}
	}
}
