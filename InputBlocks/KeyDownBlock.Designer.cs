namespace WinEvents
{
	partial class KeyDownBlock
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
			groupBox_KeyDown = new GroupBox();
			SuspendLayout();
			// 
			// groupBox_KeyDown
			// 
			groupBox_KeyDown.Location = new Point(6, 6);
			groupBox_KeyDown.Name = "groupBox_KeyDown";
			groupBox_KeyDown.Size = new Size(156, 108);
			groupBox_KeyDown.TabIndex = 0;
			groupBox_KeyDown.TabStop = false;
			groupBox_KeyDown.Text = "Key down";
			// 
			// KeyDownBlock
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(groupBox_KeyDown);
			Name = "KeyDownBlock";
			Padding = new Padding(3);
			Size = new Size(168, 120);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox_KeyDown;
	}
}
