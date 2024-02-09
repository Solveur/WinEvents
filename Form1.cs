namespace WinEvents
{
	using System.Runtime.InteropServices;
	using System.Diagnostics;
	using System.Windows.Forms;
	using SetHook;
	using static SetHook.NativeMethods;
	using SendInput;
	using static SendInput.MouseMethods;
	using static SendInput.KeyboardMethods;

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = SendMouseLClick().ToString();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
		}
	}
}
