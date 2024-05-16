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
			checkBox_Win = new CheckBox();
			checkBox_Alt = new CheckBox();
			checkBox_Control = new CheckBox();
			checkBox_Shift = new CheckBox();
			panel_Drag = new Panel();
			comboBox_Key = new ComboBox();
			groupBox_KeyDown.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox_KeyDown
			// 
			groupBox_KeyDown.Controls.Add(checkBox_Win);
			groupBox_KeyDown.Controls.Add(checkBox_Alt);
			groupBox_KeyDown.Controls.Add(checkBox_Control);
			groupBox_KeyDown.Controls.Add(checkBox_Shift);
			groupBox_KeyDown.Controls.Add(panel_Drag);
			groupBox_KeyDown.Controls.Add(comboBox_Key);
			groupBox_KeyDown.Location = new Point(6, 6);
			groupBox_KeyDown.Name = "groupBox_KeyDown";
			groupBox_KeyDown.Size = new Size(145, 108);
			groupBox_KeyDown.TabIndex = 0;
			groupBox_KeyDown.TabStop = false;
			groupBox_KeyDown.Text = "Key down";
			// 
			// checkBox_Win
			// 
			checkBox_Win.AutoSize = true;
			checkBox_Win.Location = new Point(58, 76);
			checkBox_Win.Name = "checkBox_Win";
			checkBox_Win.Size = new Size(52, 19);
			checkBox_Win.TabIndex = 5;
			checkBox_Win.Text = "Win?";
			checkBox_Win.UseVisualStyleBackColor = true;
			// 
			// checkBox_Alt
			// 
			checkBox_Alt.AutoSize = true;
			checkBox_Alt.Location = new Point(6, 76);
			checkBox_Alt.Name = "checkBox_Alt";
			checkBox_Alt.Size = new Size(46, 19);
			checkBox_Alt.TabIndex = 5;
			checkBox_Alt.Text = "Alt?";
			checkBox_Alt.UseVisualStyleBackColor = true;
			// 
			// checkBox_Control
			// 
			checkBox_Control.AutoSize = true;
			checkBox_Control.Location = new Point(67, 51);
			checkBox_Control.Name = "checkBox_Control";
			checkBox_Control.Size = new Size(71, 19);
			checkBox_Control.TabIndex = 6;
			checkBox_Control.Text = "Control?";
			checkBox_Control.UseVisualStyleBackColor = true;
			// 
			// checkBox_Shift
			// 
			checkBox_Shift.AutoSize = true;
			checkBox_Shift.Location = new Point(6, 51);
			checkBox_Shift.Name = "checkBox_Shift";
			checkBox_Shift.Size = new Size(55, 19);
			checkBox_Shift.TabIndex = 7;
			checkBox_Shift.Text = "Shift?";
			checkBox_Shift.UseVisualStyleBackColor = true;
			// 
			// panel_Drag
			// 
			panel_Drag.AllowDrop = true;
			panel_Drag.BackColor = SystemColors.ControlLight;
			panel_Drag.Cursor = Cursors.SizeAll;
			panel_Drag.Location = new Point(116, 76);
			panel_Drag.Name = "panel_Drag";
			panel_Drag.Size = new Size(23, 26);
			panel_Drag.TabIndex = 2;
			panel_Drag.MouseDown += Panel_Drag_MouseDown;
			// 
			// comboBox_Key
			// 
			comboBox_Key.FormattingEnabled = true;
			comboBox_Key.Location = new Point(6, 22);
			comboBox_Key.Name = "comboBox_Key";
			comboBox_Key.Size = new Size(133, 23);
			comboBox_Key.TabIndex = 1;
			// 
			// KeyDownBlock
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(groupBox_KeyDown);
			Name = "KeyDownBlock";
			Size = new Size(157, 120);
			groupBox_KeyDown.ResumeLayout(false);
			groupBox_KeyDown.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox_KeyDown;
		private ComboBox comboBox_Key;
		private Panel panel_Drag;
		private CheckBox checkBox_Alt;
		private CheckBox checkBox_Control;
		private CheckBox checkBox_Shift;
		private CheckBox checkBox_Win;
	}
}
