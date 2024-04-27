namespace WinEvents
{
	using System.Windows.Forms;
	using SendInput;

	public partial class InputControl : UserControl
	{
		public virtual Input Input { get; }
		public InputControl()
		{
			InitializeComponent();
		}
	}
}
