namespace WinEvents
{
	using System;
	using System.Windows.Forms;
	using SendInput;

	public partial class InputOverride : UserControl
	{
		private Input[] inputs = [];
		static InputQueueForm nf = new();

		public InputOverride()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			inputs = BuildInputs();
		}

		private static Input[] BuildInputs()
		{
			nf.ShowDialog();
			Input[] inputs = nf.Inputs;
			return inputs;
		}
	}
}
