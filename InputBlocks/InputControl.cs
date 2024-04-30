namespace WinEvents
{
	using System.Windows.Forms;
	using SendInput;

	public partial class InputBlock : UserControl
	{
		public virtual Input Input { get; }
		public InputBlock()
		{
			InitializeComponent();
		}
	}
}
