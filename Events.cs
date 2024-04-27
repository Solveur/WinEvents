namespace WinEvents
{
	using System.Runtime.CompilerServices;
	using System.Runtime.InteropServices;
	using SendInput;
	using Hooks;
	using System.Windows.Forms;

	static class Events
	{
		static readonly MouseHook mouse = new();
		static readonly KeyboardHook keyboard = new();
		static readonly Timer t = new();
		[STAThread]
		static void Main()
		{
			//t.Interval = 100;
			//t.Tick += TimerTick;

			//mouse.MouseDown += OnMouseDown;
			//mouse.MouseUp += OnMouseUp;
			////mouse.MouseMove += OnMouseMove;
			//mouse.MouseWheel += OnMouseWheel;
			//mouse.Click += OnClick;
			////mouse.BlockPropagation = true;

			//keyboard.KeyDown += OnKeyDown;
			//keyboard.KeyUp += OnKeyUp;
			//keyboard.KeyPress += OnKeyPress;
			////keyboard.BlockPropagation = true;

			//mouse.Start();
			//keyboard.Start();
			//Application.Run();
			//mouse.Stop();
			//keyboard.Stop();

			Application.Run(new MainForm());
		}

		static void OnClick(object? sender, EventArgs e)
		{

		}

		static void TimerTick(object? sender, EventArgs e)
		{
			//Do something every tick
			//Console.WriteLine("Did something");
		}

		static void OnMouseDown(object? sender, MouseEventArgs e)
		{
			//WinAPI.SendInput([
			//	new(
			//		new KeyboardInput{
			//			ScanCode = 'ї',
			//			Flags = KeyboardFlags.KeyDown | KeyboardFlags.Unicode,
			//			ExtraInfo = WinAPI.GetMessageExtraInfo(),
			//		}
			//	)
			//]);
			Console.WriteLine($"{e.Button} down, X: {e.Location.X}, Y: {e.Location.Y}, {e.Clicks} click(s)");
			t.Start();
		}

		static void OnMouseUp(object? sender, MouseEventArgs e)
		{
			Console.WriteLine($"{e.Button} up, X: {e.Location.X}, Y: {e.Location.Y}, {e.Clicks} click(s)");
			t.Stop();
		}

		static void OnMouseWheel(object? sender, MouseEventArgs e)
		{
			string wheelDirection = e.Delta > 0 ? "Up" : "Down";
			int wheelClicks = Math.Abs(e.Delta / 120);
			Console.WriteLine($"Wheel: {wheelDirection}, {wheelClicks}");
		}

		static void OnMouseMove(object? sender, MouseEventArgs e)
		{
			//Console.WriteLine($"X: {e.Location.X}, Y: {e.Location.Y}");
		}

		static void OnKeyPress(object? sender, KeyPressEventArgs e)
		{
			Console.WriteLine($"{e.KeyChar}");
		}

		static void OnKeyDown(object? sender, KeyEventArgs e)
		{
			Console.WriteLine($"{e.KeyValue:X}, {e.KeyCode}, Modifiers: {e.Modifiers}");
		}

		private static void OnKeyUp(object? sender, KeyEventArgs e)
		{

		}
	}
}
