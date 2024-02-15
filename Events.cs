namespace WinEvents
{
	using System.Runtime.InteropServices;
	using Hooks;

	public class Events
	{
		public static void Main()
		{
			MouseHook mouse = new();
			mouse.Click += new EventHandler(onClick);
			mouse.MouseDown += new MouseEventHandler(onClick);

			mouse.Start();
			Application.Run();
			mouse.Stop();
			//Application.Run(new Form1());
		}

		public static void onClick(object? sender, EventArgs e)
		{

		}

		public static void onMouseDown(object? sender, MouseEventArgs e)
		{

		}
	}
}
