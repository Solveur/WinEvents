namespace WinEvents
{
	using System.Runtime.InteropServices;
	using Hooks;

	static class Events
	{
		static void Main(string[] args)
		{
			MouseHook mouse = new();
			KeyboardHook kbd = new();

			kbd.KeyPress += new KeyPressEventHandler(onKeyPress);
			kbd.KeyDown += new KeyEventHandler(onKeyDown);

			mouse.Click += new EventHandler(onClick);
			mouse.MouseDown += new MouseEventHandler(onClick);

			kbd.Start();
			mouse.Start();
			Application.Run();
			mouse.Stop();
			kbd.Stop();
		}

		public static void onClick(object? sender, EventArgs e)
		{

		}

		public static void onMouseDown(object? sender, MouseEventArgs e)
		{

		}

		public static void onKeyPress(object? sender, KeyPressEventArgs e)
		{
			Console.WriteLine($"{e.KeyChar}");
		}

		public static void onKeyDown(object? sender, KeyEventArgs e)
		{
			Console.WriteLine($"{e.KeyValue}, {e.KeyCode}, {e.KeyData}, {e.Control}, {e.Shift}, {e.Alt}, {e.GetType}");
		}
	}
}
