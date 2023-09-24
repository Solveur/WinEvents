namespace WinEvents
{
	using static MouseMethods;

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			//int width = Screen.AllScreens.Sum((screen) => { return screen.Bounds.Width; });
			//int height = Screen.AllScreens.Sum((screen) => { return screen.Bounds.Height; });

			//MessageBox.Show($"{width}x{height}");
			SendMouseMove(770, 450);
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			SendMouseLClick();
		}
	}
}
