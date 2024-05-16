namespace WinEvents
{
	using System;
	using System.Windows.Forms;
	using Hooks;
	using SendInput;

	public partial class Form_Main : Form
	{
		public Form_Main()
		{
			InitializeComponent();
			//MouseHook mh = new();
			//mh.MouseMove += Mh_MouseMove;
			//mh.MouseDown += Mh_MouseDown;
			//mh.MouseUp += Mh_MouseUp;

			//mh.BlockPropagation = true;
			//mh.CatchInjected = false;
			//mh.Start();
		}

		private void Kh_KeyDown(object? sender, KeyEventArgs e)
		{
			Console.WriteLine($"{e.KeyValue}, {e.KeyCode}, {e.KeyData}, {e.Modifiers}");
		}

		//Point? prevPos = null;

		//private void Mh_MouseMove(object? sender, MouseEventArgs e)
		//{
		//	if (prevPos == null)
		//	{
		//		prevPos = e.Location;
		//		return;
		//	}

		//	// Due to integer rounding, resulting numbers
		//	// tend to drift towards 0, so it's needed to include correction
		//	int correctionX = e.X > 0 ? 2 : -2;
		//	int correctionY = e.Y > 0 ? 2 : -2;

		//	int deltaX = e.X;
		//	int deltaY = e.Y;
		//	int screenWidth = Screen.PrimaryScreen?.Bounds.Width ?? 1920;
		//	int screenHeight = Screen.PrimaryScreen?.Bounds.Height ?? 1080;
		//	int xNormalized = (int)((double)deltaX / screenWidth * ushort.MaxValue) + correctionX;
		//	int yNormalized = (int)((double)deltaY / screenHeight * ushort.MaxValue) + correctionY;

		//	MouseInput mi = new()
		//	{
		//		Dx = xNormalized,
		//		Dy = yNormalized,
		//		Flags = MouseFlags.Move | MouseFlags.Absolute,
		//		Time = 0,
		//		MouseData = 0,
		//		ExtraInfo = WinAPI.GetMessageExtraInfo()
		//	};

		//	WinAPI.SendInput([new(mi)]);
		//	prevPos = e.Location;
		//}

		private void Button_AddOverride_Click(object sender, EventArgs e)
		{
			flowLayoutPanel_InputOverrides.Controls.Add(new InputOverride());
		}
	}
}
