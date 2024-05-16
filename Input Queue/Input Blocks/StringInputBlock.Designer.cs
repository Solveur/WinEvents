namespace WinEvents
{
	partial class StringInputBlock
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			groupBox_String = new GroupBox();
			textBox_String = new TextBox();
			panel1 = new Panel();
			groupBox_String.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox_String
			// 
			groupBox_String.Controls.Add(panel1);
			groupBox_String.Controls.Add(textBox_String);
			groupBox_String.Location = new Point(6, 6);
			groupBox_String.Name = "groupBox_String";
			groupBox_String.Size = new Size(200, 108);
			groupBox_String.TabIndex = 0;
			groupBox_String.TabStop = false;
			groupBox_String.Text = "String";
			// 
			// textBox_String
			// 
			textBox_String.AcceptsReturn = true;
			textBox_String.Location = new Point(6, 22);
			textBox_String.Multiline = true;
			textBox_String.Name = "textBox_String";
			textBox_String.ScrollBars = ScrollBars.Both;
			textBox_String.Size = new Size(159, 77);
			textBox_String.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.AllowDrop = true;
			panel1.BackColor = SystemColors.ControlLight;
			panel1.Cursor = Cursors.SizeAll;
			panel1.Location = new Point(171, 22);
			panel1.Name = "panel1";
			panel1.Size = new Size(23, 77);
			panel1.TabIndex = 1;
			panel1.MouseDown += panel1_MouseDown;
			// 
			// StringInputBlock
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(groupBox_String);
			Name = "StringInputBlock";
			Size = new Size(212, 120);
			groupBox_String.ResumeLayout(false);
			groupBox_String.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox_String;
		private TextBox textBox_String;
		private Panel panel1;
	}
}
