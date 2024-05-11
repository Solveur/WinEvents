namespace WinEvents
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using System.Windows.Forms;
	using System.Windows.Forms.Design;

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
