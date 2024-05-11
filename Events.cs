namespace WinEvents
{
	using System.Runtime.CompilerServices;
	using System.Runtime.InteropServices;
	using SendInput;
	using Hooks;
	using System.Windows.Forms;

	static class Events
	{
		[STAThread]
		static void Main()
		{
			Application.Run(new MainForm());
		}
	}
}
