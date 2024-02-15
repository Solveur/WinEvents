namespace WinEvents
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			button1 = new Button();
			timer1 = new System.Windows.Forms.Timer(components);
			textBox1 = new TextBox();
			checkBox1 = new CheckBox();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(350, 163);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 0;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += Button1_Click;
			// 
			// timer1
			// 
			timer1.Tick += Timer1_Tick;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(116, 73);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(484, 23);
			textBox1.TabIndex = 1;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(350, 269);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(83, 19);
			checkBox1.TabIndex = 2;
			checkBox1.Text = "checkBox1";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(checkBox1);
			Controls.Add(textBox1);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private System.Windows.Forms.Timer timer1;
		private TextBox textBox1;
		private CheckBox checkBox1;
	}
}