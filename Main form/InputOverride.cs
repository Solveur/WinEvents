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

	public partial class InputOverride : UserControl
	{
		public EventHandler? InputSelected;
		public EventHandler? ActionSelected;
		public InputOverride()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			InputSelected?.Invoke(this, e);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ActionSelected?.Invoke(this, e);
		}
	}
}
