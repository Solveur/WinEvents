﻿namespace WinEvents
{
	partial class MouseDownBlock
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
			groupBox_MouseDown = new GroupBox();
			panel_Drag = new Panel();
			radioButton_RMB = new RadioButton();
			radioButton_MMB = new RadioButton();
			radioButton_MB5 = new RadioButton();
			radioButton_MB4 = new RadioButton();
			radioButton_LMB = new RadioButton();
			groupBox_MouseDown.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox_MouseDown
			// 
			groupBox_MouseDown.Controls.Add(panel_Drag);
			groupBox_MouseDown.Controls.Add(radioButton_RMB);
			groupBox_MouseDown.Controls.Add(radioButton_MMB);
			groupBox_MouseDown.Controls.Add(radioButton_MB5);
			groupBox_MouseDown.Controls.Add(radioButton_MB4);
			groupBox_MouseDown.Controls.Add(radioButton_LMB);
			groupBox_MouseDown.Location = new Point(6, 6);
			groupBox_MouseDown.Name = "groupBox_MouseDown";
			groupBox_MouseDown.Size = new Size(129, 108);
			groupBox_MouseDown.TabIndex = 0;
			groupBox_MouseDown.TabStop = false;
			groupBox_MouseDown.Text = "Mouse down";
			// 
			// panel_Drag
			// 
			panel_Drag.AllowDrop = true;
			panel_Drag.BackColor = SystemColors.ControlLight;
			panel_Drag.Cursor = Cursors.SizeAll;
			panel_Drag.Location = new Point(66, 72);
			panel_Drag.Name = "panel_Drag";
			panel_Drag.Size = new Size(57, 30);
			panel_Drag.TabIndex = 1;
			panel_Drag.MouseDown += Panel_Drag_MouseDown;
			// 
			// radioButton_RMB
			// 
			radioButton_RMB.AutoSize = true;
			radioButton_RMB.Location = new Point(6, 72);
			radioButton_RMB.Name = "radioButton_RMB";
			radioButton_RMB.Size = new Size(50, 19);
			radioButton_RMB.TabIndex = 0;
			radioButton_RMB.Text = "RMB";
			radioButton_RMB.UseVisualStyleBackColor = true;
			radioButton_RMB.CheckedChanged += RadioButton_RMB_CheckedChanged;
			// 
			// radioButton_MMB
			// 
			radioButton_MMB.AutoSize = true;
			radioButton_MMB.Location = new Point(6, 47);
			radioButton_MMB.Name = "radioButton_MMB";
			radioButton_MMB.Size = new Size(54, 19);
			radioButton_MMB.TabIndex = 0;
			radioButton_MMB.Text = "MMB";
			radioButton_MMB.UseVisualStyleBackColor = true;
			radioButton_MMB.CheckedChanged += RadioButton_MMB_CheckedChanged;
			// 
			// radioButton_MB5
			// 
			radioButton_MB5.AutoSize = true;
			radioButton_MB5.Location = new Point(66, 47);
			radioButton_MB5.Name = "radioButton_MB5";
			radioButton_MB5.Size = new Size(49, 19);
			radioButton_MB5.TabIndex = 0;
			radioButton_MB5.Text = "MB5";
			radioButton_MB5.UseVisualStyleBackColor = true;
			radioButton_MB5.CheckedChanged += RadioButton_MB5_CheckedChanged;
			// 
			// radioButton_MB4
			// 
			radioButton_MB4.AutoSize = true;
			radioButton_MB4.Location = new Point(66, 22);
			radioButton_MB4.Name = "radioButton_MB4";
			radioButton_MB4.Size = new Size(49, 19);
			radioButton_MB4.TabIndex = 0;
			radioButton_MB4.Text = "MB4";
			radioButton_MB4.UseVisualStyleBackColor = true;
			radioButton_MB4.CheckedChanged += RadioButton_MB4_CheckedChanged;
			// 
			// radioButton_LMB
			// 
			radioButton_LMB.AutoSize = true;
			radioButton_LMB.Checked = true;
			radioButton_LMB.Location = new Point(6, 22);
			radioButton_LMB.Name = "radioButton_LMB";
			radioButton_LMB.Size = new Size(49, 19);
			radioButton_LMB.TabIndex = 0;
			radioButton_LMB.TabStop = true;
			radioButton_LMB.Text = "LMB";
			radioButton_LMB.UseVisualStyleBackColor = true;
			radioButton_LMB.CheckedChanged += RadioButton_LMB_CheckedChanged;
			// 
			// MouseDownBlock
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(groupBox_MouseDown);
			MinimumSize = new Size(20, 120);
			Name = "MouseDownBlock";
			Size = new Size(141, 120);
			groupBox_MouseDown.ResumeLayout(false);
			groupBox_MouseDown.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox_MouseDown;
		private RadioButton radioButton_RMB;
		private RadioButton radioButton_MMB;
		private RadioButton radioButton_MB4;
		private RadioButton radioButton_LMB;
		private RadioButton radioButton_MB5;
		private Panel panel_Drag;
	}
}
