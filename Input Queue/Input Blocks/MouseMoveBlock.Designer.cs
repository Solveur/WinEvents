﻿namespace WinEvents
{
	partial class MouseMoveBlock
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
			numericUpDown_X = new NumericUpDown();
			numericUpDown_Y = new NumericUpDown();
			label1 = new Label();
			label2 = new Label();
			groupBox_MouseMove = new GroupBox();
			panel_Drag = new Panel();
			checkBox_Place = new CheckBox();
			((System.ComponentModel.ISupportInitialize)numericUpDown_X).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Y).BeginInit();
			groupBox_MouseMove.SuspendLayout();
			SuspendLayout();
			// 
			// numericUpDown_X
			// 
			numericUpDown_X.Location = new Point(26, 21);
			numericUpDown_X.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
			numericUpDown_X.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
			numericUpDown_X.Name = "numericUpDown_X";
			numericUpDown_X.Size = new Size(73, 23);
			numericUpDown_X.TabIndex = 0;
			// 
			// numericUpDown_Y
			// 
			numericUpDown_Y.Location = new Point(26, 50);
			numericUpDown_Y.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
			numericUpDown_Y.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
			numericUpDown_Y.Name = "numericUpDown_Y";
			numericUpDown_Y.Size = new Size(73, 23);
			numericUpDown_Y.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 23);
			label1.Name = "label1";
			label1.Size = new Size(17, 15);
			label1.TabIndex = 3;
			label1.Text = "X:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 52);
			label2.Name = "label2";
			label2.Size = new Size(17, 15);
			label2.TabIndex = 3;
			label2.Text = "Y:";
			// 
			// groupBox_MouseMove
			// 
			groupBox_MouseMove.Controls.Add(panel_Drag);
			groupBox_MouseMove.Controls.Add(checkBox_Place);
			groupBox_MouseMove.Controls.Add(numericUpDown_X);
			groupBox_MouseMove.Controls.Add(numericUpDown_Y);
			groupBox_MouseMove.Controls.Add(label2);
			groupBox_MouseMove.Controls.Add(label1);
			groupBox_MouseMove.Location = new Point(6, 6);
			groupBox_MouseMove.Name = "groupBox_MouseMove";
			groupBox_MouseMove.Size = new Size(113, 108);
			groupBox_MouseMove.TabIndex = 5;
			groupBox_MouseMove.TabStop = false;
			groupBox_MouseMove.Text = "Mouse move";
			// 
			// panel_Drag
			// 
			panel_Drag.AllowDrop = true;
			panel_Drag.BackColor = SystemColors.ControlLight;
			panel_Drag.Cursor = Cursors.SizeAll;
			panel_Drag.Location = new Point(66, 79);
			panel_Drag.Name = "panel_Drag";
			panel_Drag.Size = new Size(41, 23);
			panel_Drag.TabIndex = 6;
			panel_Drag.MouseDown += Panel_Drag_MouseDown;
			// 
			// checkBox_Place
			// 
			checkBox_Place.AutoSize = true;
			checkBox_Place.Location = new Point(6, 79);
			checkBox_Place.Name = "checkBox_Place";
			checkBox_Place.Size = new Size(54, 19);
			checkBox_Place.TabIndex = 5;
			checkBox_Place.Text = "Place";
			checkBox_Place.UseVisualStyleBackColor = true;
			// 
			// MouseMoveBlock
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(groupBox_MouseMove);
			Name = "MouseMoveBlock";
			Padding = new Padding(3);
			Size = new Size(125, 120);
			((System.ComponentModel.ISupportInitialize)numericUpDown_X).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Y).EndInit();
			groupBox_MouseMove.ResumeLayout(false);
			groupBox_MouseMove.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private NumericUpDown numericUpDown_X;
		private NumericUpDown numericUpDown_Y;
		private Label label1;
		private Label label2;
		private GroupBox groupBox_MouseMove;
		private CheckBox checkBox_Place;
		private Panel panel_Drag;
	}
}
