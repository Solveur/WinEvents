namespace WinEvents
{
	using System.Windows.Forms;

	static class Events
	{
		[STAThread]
		static void Main()
		{
			Application.Run(new Form_Main());
		}
	}
}
