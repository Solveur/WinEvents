namespace WinEvents
{
	using System.Windows.Forms;
	using System.Runtime.InteropServices;
	using static SendInput.MouseMethods;
	using static SendInput.KeyboardMethods;

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			timer1.Enabled = !timer1.Enabled;
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			checkBox1.Checked = !checkBox1.Checked;
			SendKeyboardInput();
		}
	}
}
