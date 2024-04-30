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
	using SendInput;

	public partial class KeyDownBlock : InputBlock
	{
		public override Input Input
		{ 
			get
			{
				return new();
			} 
		}

		public KeyDownBlock()
		{
			InitializeComponent();
		}
	}
}
