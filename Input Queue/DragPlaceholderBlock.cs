namespace WinEvents
{
	using System.Drawing;

	public partial class DragPlaceholderBlock : InputBlock
	{
		public DragPlaceholderBlock()
		{
			InitializeComponent();
		}

		public DragPlaceholderBlock(Size placeholderSize)
		{
			InitializeComponent();
			Size = placeholderSize;
		}
	}
}
