namespace WinEvents
{
	partial class MouseWheelBlock
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
			groupBox_Wheel = new GroupBox();
			panel_Drag = new Panel();
			numericUpDown_WheelAmount = new NumericUpDown();
			radioButton_WheelDown = new RadioButton();
			radioButton_WheelUp = new RadioButton();
			groupBox_Wheel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown_WheelAmount).BeginInit();
			SuspendLayout();
			// 
			// groupBox_Wheel
			// 
			groupBox_Wheel.Controls.Add(panel_Drag);
			groupBox_Wheel.Controls.Add(numericUpDown_WheelAmount);
			groupBox_Wheel.Controls.Add(radioButton_WheelDown);
			groupBox_Wheel.Controls.Add(radioButton_WheelUp);
			groupBox_Wheel.Location = new Point(6, 6);
			groupBox_Wheel.Name = "groupBox_Wheel";
			groupBox_Wheel.Size = new Size(122, 108);
			groupBox_Wheel.TabIndex = 0;
			groupBox_Wheel.TabStop = false;
			groupBox_Wheel.Text = "Wheel";
			// 
			// panel_Drag
			// 
			panel_Drag.BackColor = SystemColors.ControlLight;
			panel_Drag.Location = new Point(81, 67);
			panel_Drag.Name = "panel_Drag";
			panel_Drag.Size = new Size(35, 35);
			panel_Drag.TabIndex = 3;
			panel_Drag.MouseDown += Panel_Drag_MouseDown;
			// 
			// numericUpDown_WheelAmount
			// 
			numericUpDown_WheelAmount.Location = new Point(6, 22);
			numericUpDown_WheelAmount.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
			numericUpDown_WheelAmount.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
			numericUpDown_WheelAmount.Name = "numericUpDown_WheelAmount";
			numericUpDown_WheelAmount.Size = new Size(110, 23);
			numericUpDown_WheelAmount.TabIndex = 2;
			// 
			// radioButton_WheelDown
			// 
			radioButton_WheelDown.AutoSize = true;
			radioButton_WheelDown.Location = new Point(6, 76);
			radioButton_WheelDown.Name = "radioButton_WheelDown";
			radioButton_WheelDown.Size = new Size(56, 19);
			radioButton_WheelDown.TabIndex = 1;
			radioButton_WheelDown.Text = "Down";
			radioButton_WheelDown.UseVisualStyleBackColor = true;
			// 
			// radioButton_WheelUp
			// 
			radioButton_WheelUp.AutoSize = true;
			radioButton_WheelUp.Checked = true;
			radioButton_WheelUp.Location = new Point(6, 51);
			radioButton_WheelUp.Name = "radioButton_WheelUp";
			radioButton_WheelUp.Size = new Size(40, 19);
			radioButton_WheelUp.TabIndex = 0;
			radioButton_WheelUp.TabStop = true;
			radioButton_WheelUp.Text = "Up";
			radioButton_WheelUp.UseVisualStyleBackColor = true;
			// 
			// MouseWheelBlock
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			Controls.Add(groupBox_Wheel);
			MaximumSize = new Size(0, 120);
			MinimumSize = new Size(0, 120);
			Name = "MouseWheelBlock";
			Padding = new Padding(3);
			Size = new Size(134, 120);
			groupBox_Wheel.ResumeLayout(false);
			groupBox_Wheel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown_WheelAmount).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox_Wheel;
		private Panel panel_Drag;
		private NumericUpDown numericUpDown_WheelAmount;
		private RadioButton radioButton_WheelDown;
		private RadioButton radioButton_WheelUp;
	}
}
