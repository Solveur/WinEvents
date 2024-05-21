namespace WinEvents
{
	partial class Form_HookBuilder
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
			tabControl1 = new TabControl();
			tabPage_MouseHookBuilder = new TabPage();
			groupBox_MouseWheel = new GroupBox();
			radioButton_MouseWheelDown = new RadioButton();
			radioButton_MouseWheelUp = new RadioButton();
			groupBox_MouseButton = new GroupBox();
			radioButton_ButtonMB5 = new RadioButton();
			radioButton_ButtonMB4 = new RadioButton();
			radioButton_ButtonRMB = new RadioButton();
			radioButton_ButtonMMB = new RadioButton();
			radioButton_ButtonLMB = new RadioButton();
			groupBox_MouseAction = new GroupBox();
			radioButton_ActionWheel = new RadioButton();
			radioButton_ActionMouseUp = new RadioButton();
			radioButton_ActionMouseDown = new RadioButton();
			radioButton_ActionMove = new RadioButton();
			tabPage_KeyboardHookBuilder = new TabPage();
			groupBox_KeyboardKey = new GroupBox();
			checkBox_Win = new CheckBox();
			checkBox_Alt = new CheckBox();
			checkBox_Control = new CheckBox();
			checkBox_Shift = new CheckBox();
			comboBox_Key = new ComboBox();
			groupBox_KeyboardAction = new GroupBox();
			radioButton_KeyboardKeyUp = new RadioButton();
			radioButton_KeyboardKeyDown = new RadioButton();
			checkBox_BlockMousePropagation = new CheckBox();
			checkBox_BlockKeyboardPropagation = new CheckBox();
			tabControl1.SuspendLayout();
			tabPage_MouseHookBuilder.SuspendLayout();
			groupBox_MouseWheel.SuspendLayout();
			groupBox_MouseButton.SuspendLayout();
			groupBox_MouseAction.SuspendLayout();
			tabPage_KeyboardHookBuilder.SuspendLayout();
			groupBox_KeyboardKey.SuspendLayout();
			groupBox_KeyboardAction.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage_MouseHookBuilder);
			tabControl1.Controls.Add(tabPage_KeyboardHookBuilder);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(410, 209);
			tabControl1.TabIndex = 0;
			// 
			// tabPage_MouseHookBuilder
			// 
			tabPage_MouseHookBuilder.Controls.Add(checkBox_BlockMousePropagation);
			tabPage_MouseHookBuilder.Controls.Add(groupBox_MouseWheel);
			tabPage_MouseHookBuilder.Controls.Add(groupBox_MouseButton);
			tabPage_MouseHookBuilder.Controls.Add(groupBox_MouseAction);
			tabPage_MouseHookBuilder.Location = new Point(4, 24);
			tabPage_MouseHookBuilder.Name = "tabPage_MouseHookBuilder";
			tabPage_MouseHookBuilder.Padding = new Padding(3);
			tabPage_MouseHookBuilder.Size = new Size(402, 181);
			tabPage_MouseHookBuilder.TabIndex = 0;
			tabPage_MouseHookBuilder.Text = "Mouse hook";
			tabPage_MouseHookBuilder.UseVisualStyleBackColor = true;
			// 
			// groupBox_MouseWheel
			// 
			groupBox_MouseWheel.Controls.Add(radioButton_MouseWheelDown);
			groupBox_MouseWheel.Controls.Add(radioButton_MouseWheelUp);
			groupBox_MouseWheel.Enabled = false;
			groupBox_MouseWheel.Location = new Point(287, 6);
			groupBox_MouseWheel.Name = "groupBox_MouseWheel";
			groupBox_MouseWheel.Size = new Size(104, 72);
			groupBox_MouseWheel.TabIndex = 2;
			groupBox_MouseWheel.TabStop = false;
			groupBox_MouseWheel.Text = "Wheel";
			// 
			// radioButton_MouseWheelDown
			// 
			radioButton_MouseWheelDown.AutoSize = true;
			radioButton_MouseWheelDown.Location = new Point(6, 47);
			radioButton_MouseWheelDown.Name = "radioButton_MouseWheelDown";
			radioButton_MouseWheelDown.Size = new Size(91, 19);
			radioButton_MouseWheelDown.TabIndex = 0;
			radioButton_MouseWheelDown.Text = "Wheel down";
			radioButton_MouseWheelDown.UseVisualStyleBackColor = true;
			radioButton_MouseWheelDown.CheckedChanged += radioButton_WheelDown_CheckedChanged;
			// 
			// radioButton_MouseWheelUp
			// 
			radioButton_MouseWheelUp.AutoSize = true;
			radioButton_MouseWheelUp.Checked = true;
			radioButton_MouseWheelUp.Location = new Point(6, 22);
			radioButton_MouseWheelUp.Name = "radioButton_MouseWheelUp";
			radioButton_MouseWheelUp.Size = new Size(75, 19);
			radioButton_MouseWheelUp.TabIndex = 0;
			radioButton_MouseWheelUp.TabStop = true;
			radioButton_MouseWheelUp.Text = "Wheel up";
			radioButton_MouseWheelUp.UseVisualStyleBackColor = true;
			radioButton_MouseWheelUp.CheckedChanged += radioButton_MouseWheelUp_CheckedChanged;
			// 
			// groupBox_MouseButton
			// 
			groupBox_MouseButton.Controls.Add(radioButton_ButtonMB5);
			groupBox_MouseButton.Controls.Add(radioButton_ButtonMB4);
			groupBox_MouseButton.Controls.Add(radioButton_ButtonRMB);
			groupBox_MouseButton.Controls.Add(radioButton_ButtonMMB);
			groupBox_MouseButton.Controls.Add(radioButton_ButtonLMB);
			groupBox_MouseButton.Enabled = false;
			groupBox_MouseButton.Location = new Point(122, 6);
			groupBox_MouseButton.Name = "groupBox_MouseButton";
			groupBox_MouseButton.Size = new Size(159, 147);
			groupBox_MouseButton.TabIndex = 1;
			groupBox_MouseButton.TabStop = false;
			groupBox_MouseButton.Text = "Button";
			// 
			// radioButton_ButtonMB5
			// 
			radioButton_ButtonMB5.AutoSize = true;
			radioButton_ButtonMB5.Location = new Point(6, 122);
			radioButton_ButtonMB5.Name = "radioButton_ButtonMB5";
			radioButton_ButtonMB5.Size = new Size(109, 19);
			radioButton_ButtonMB5.TabIndex = 0;
			radioButton_ButtonMB5.Text = "Mouse button 5";
			radioButton_ButtonMB5.UseVisualStyleBackColor = true;
			radioButton_ButtonMB5.CheckedChanged += RadioButton_ButtonMB5_CheckedChanged;
			// 
			// radioButton_ButtonMB4
			// 
			radioButton_ButtonMB4.AutoSize = true;
			radioButton_ButtonMB4.Location = new Point(6, 97);
			radioButton_ButtonMB4.Name = "radioButton_ButtonMB4";
			radioButton_ButtonMB4.Size = new Size(109, 19);
			radioButton_ButtonMB4.TabIndex = 0;
			radioButton_ButtonMB4.Text = "Mouse button 4";
			radioButton_ButtonMB4.UseVisualStyleBackColor = true;
			radioButton_ButtonMB4.CheckedChanged += RadioButton_ButtonMB4_CheckedChanged;
			// 
			// radioButton_ButtonRMB
			// 
			radioButton_ButtonRMB.AutoSize = true;
			radioButton_ButtonRMB.Location = new Point(6, 72);
			radioButton_ButtonRMB.Name = "radioButton_ButtonRMB";
			radioButton_ButtonRMB.Size = new Size(131, 19);
			radioButton_ButtonRMB.TabIndex = 0;
			radioButton_ButtonRMB.Text = "Right mouse button";
			radioButton_ButtonRMB.UseVisualStyleBackColor = true;
			radioButton_ButtonRMB.CheckedChanged += RadioButton_ButtonRMB_CheckedChanged;
			// 
			// radioButton_ButtonMMB
			// 
			radioButton_ButtonMMB.AutoSize = true;
			radioButton_ButtonMMB.Location = new Point(6, 47);
			radioButton_ButtonMMB.Name = "radioButton_ButtonMMB";
			radioButton_ButtonMMB.Size = new Size(140, 19);
			radioButton_ButtonMMB.TabIndex = 0;
			radioButton_ButtonMMB.Text = "Middle mouse button";
			radioButton_ButtonMMB.UseVisualStyleBackColor = true;
			radioButton_ButtonMMB.CheckedChanged += RadioButton_ButtonMMB_CheckedChanged;
			// 
			// radioButton_ButtonLMB
			// 
			radioButton_ButtonLMB.AutoSize = true;
			radioButton_ButtonLMB.Checked = true;
			radioButton_ButtonLMB.Location = new Point(6, 22);
			radioButton_ButtonLMB.Name = "radioButton_ButtonLMB";
			radioButton_ButtonLMB.Size = new Size(123, 19);
			radioButton_ButtonLMB.TabIndex = 0;
			radioButton_ButtonLMB.TabStop = true;
			radioButton_ButtonLMB.Text = "Left mouse button";
			radioButton_ButtonLMB.UseVisualStyleBackColor = true;
			radioButton_ButtonLMB.CheckedChanged += RadioButton_ButtonLMB_CheckedChanged;
			// 
			// groupBox_MouseAction
			// 
			groupBox_MouseAction.Controls.Add(radioButton_ActionWheel);
			groupBox_MouseAction.Controls.Add(radioButton_ActionMouseUp);
			groupBox_MouseAction.Controls.Add(radioButton_ActionMouseDown);
			groupBox_MouseAction.Controls.Add(radioButton_ActionMove);
			groupBox_MouseAction.Location = new Point(8, 6);
			groupBox_MouseAction.Name = "groupBox_MouseAction";
			groupBox_MouseAction.Size = new Size(108, 122);
			groupBox_MouseAction.TabIndex = 0;
			groupBox_MouseAction.TabStop = false;
			groupBox_MouseAction.Text = "Action";
			// 
			// radioButton_ActionWheel
			// 
			radioButton_ActionWheel.AutoSize = true;
			radioButton_ActionWheel.Location = new Point(6, 97);
			radioButton_ActionWheel.Name = "radioButton_ActionWheel";
			radioButton_ActionWheel.Size = new Size(58, 19);
			radioButton_ActionWheel.TabIndex = 3;
			radioButton_ActionWheel.Text = "Wheel";
			radioButton_ActionWheel.UseVisualStyleBackColor = true;
			radioButton_ActionWheel.CheckedChanged += RadioButton_ActionMouseWheel_CheckedChanged;
			// 
			// radioButton_ActionMouseUp
			// 
			radioButton_ActionMouseUp.AutoSize = true;
			radioButton_ActionMouseUp.Location = new Point(6, 72);
			radioButton_ActionMouseUp.Name = "radioButton_ActionMouseUp";
			radioButton_ActionMouseUp.Size = new Size(76, 19);
			radioButton_ActionMouseUp.TabIndex = 3;
			radioButton_ActionMouseUp.Text = "MouseUp";
			radioButton_ActionMouseUp.UseVisualStyleBackColor = true;
			radioButton_ActionMouseUp.CheckedChanged += RadioButton_ActionMouseUp_CheckedChanged;
			// 
			// radioButton_ActionMouseDown
			// 
			radioButton_ActionMouseDown.AutoSize = true;
			radioButton_ActionMouseDown.Location = new Point(6, 47);
			radioButton_ActionMouseDown.Name = "radioButton_ActionMouseDown";
			radioButton_ActionMouseDown.Size = new Size(92, 19);
			radioButton_ActionMouseDown.TabIndex = 3;
			radioButton_ActionMouseDown.Text = "MouseDown";
			radioButton_ActionMouseDown.UseVisualStyleBackColor = true;
			radioButton_ActionMouseDown.CheckedChanged += RadioButton_ActionMouseDown_CheckedChanged;
			// 
			// radioButton_ActionMove
			// 
			radioButton_ActionMove.AutoSize = true;
			radioButton_ActionMove.Checked = true;
			radioButton_ActionMove.Location = new Point(6, 22);
			radioButton_ActionMove.Name = "radioButton_ActionMove";
			radioButton_ActionMove.Size = new Size(55, 19);
			radioButton_ActionMove.TabIndex = 3;
			radioButton_ActionMove.TabStop = true;
			radioButton_ActionMove.Text = "Move";
			radioButton_ActionMove.UseVisualStyleBackColor = true;
			radioButton_ActionMove.CheckedChanged += RadioButton_ActionMouseMove_CheckedChanged;
			// 
			// tabPage_KeyboardHookBuilder
			// 
			tabPage_KeyboardHookBuilder.Controls.Add(checkBox_BlockKeyboardPropagation);
			tabPage_KeyboardHookBuilder.Controls.Add(groupBox_KeyboardKey);
			tabPage_KeyboardHookBuilder.Controls.Add(groupBox_KeyboardAction);
			tabPage_KeyboardHookBuilder.Location = new Point(4, 24);
			tabPage_KeyboardHookBuilder.Name = "tabPage_KeyboardHookBuilder";
			tabPage_KeyboardHookBuilder.Padding = new Padding(3);
			tabPage_KeyboardHookBuilder.Size = new Size(402, 181);
			tabPage_KeyboardHookBuilder.TabIndex = 1;
			tabPage_KeyboardHookBuilder.Text = "Keyboard hook";
			tabPage_KeyboardHookBuilder.UseVisualStyleBackColor = true;
			// 
			// groupBox_KeyboardKey
			// 
			groupBox_KeyboardKey.Controls.Add(checkBox_Win);
			groupBox_KeyboardKey.Controls.Add(checkBox_Alt);
			groupBox_KeyboardKey.Controls.Add(checkBox_Control);
			groupBox_KeyboardKey.Controls.Add(checkBox_Shift);
			groupBox_KeyboardKey.Controls.Add(comboBox_Key);
			groupBox_KeyboardKey.Location = new Point(103, 6);
			groupBox_KeyboardKey.Name = "groupBox_KeyboardKey";
			groupBox_KeyboardKey.Size = new Size(145, 108);
			groupBox_KeyboardKey.TabIndex = 2;
			groupBox_KeyboardKey.TabStop = false;
			groupBox_KeyboardKey.Text = "Key select";
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
			// comboBox_Key
			// 
			comboBox_Key.FormattingEnabled = true;
			comboBox_Key.Location = new Point(6, 22);
			comboBox_Key.Name = "comboBox_Key";
			comboBox_Key.Size = new Size(133, 23);
			comboBox_Key.TabIndex = 1;
			// 
			// groupBox_KeyboardAction
			// 
			groupBox_KeyboardAction.Controls.Add(radioButton_KeyboardKeyUp);
			groupBox_KeyboardAction.Controls.Add(radioButton_KeyboardKeyDown);
			groupBox_KeyboardAction.Location = new Point(8, 6);
			groupBox_KeyboardAction.Name = "groupBox_KeyboardAction";
			groupBox_KeyboardAction.Size = new Size(89, 72);
			groupBox_KeyboardAction.TabIndex = 0;
			groupBox_KeyboardAction.TabStop = false;
			groupBox_KeyboardAction.Text = "Action";
			// 
			// radioButton_KeyboardKeyUp
			// 
			radioButton_KeyboardKeyUp.AutoSize = true;
			radioButton_KeyboardKeyUp.Location = new Point(6, 47);
			radioButton_KeyboardKeyUp.Name = "radioButton_KeyboardKeyUp";
			radioButton_KeyboardKeyUp.Size = new Size(61, 19);
			radioButton_KeyboardKeyUp.TabIndex = 2;
			radioButton_KeyboardKeyUp.Text = "Key up";
			radioButton_KeyboardKeyUp.UseVisualStyleBackColor = true;
			radioButton_KeyboardKeyUp.CheckedChanged += RadioButton_KeyboardKeyUp_CheckedChanged;
			// 
			// radioButton_KeyboardKeyDown
			// 
			radioButton_KeyboardKeyDown.AutoSize = true;
			radioButton_KeyboardKeyDown.Checked = true;
			radioButton_KeyboardKeyDown.Location = new Point(6, 22);
			radioButton_KeyboardKeyDown.Name = "radioButton_KeyboardKeyDown";
			radioButton_KeyboardKeyDown.Size = new Size(77, 19);
			radioButton_KeyboardKeyDown.TabIndex = 2;
			radioButton_KeyboardKeyDown.TabStop = true;
			radioButton_KeyboardKeyDown.Text = "Key down";
			radioButton_KeyboardKeyDown.UseVisualStyleBackColor = true;
			radioButton_KeyboardKeyDown.CheckedChanged += RadioButton_KeyboardKeyDown_CheckedChanged;
			// 
			// checkBox_BlockMousePropagation
			// 
			checkBox_BlockMousePropagation.AutoSize = true;
			checkBox_BlockMousePropagation.Location = new Point(267, 154);
			checkBox_BlockMousePropagation.Name = "checkBox_BlockMousePropagation";
			checkBox_BlockMousePropagation.Size = new Size(129, 19);
			checkBox_BlockMousePropagation.TabIndex = 3;
			checkBox_BlockMousePropagation.Text = "Block original input";
			checkBox_BlockMousePropagation.UseVisualStyleBackColor = true;
			// 
			// checkBox_BlockKeyboardPropagation
			// 
			checkBox_BlockKeyboardPropagation.AutoSize = true;
			checkBox_BlockKeyboardPropagation.Location = new Point(8, 154);
			checkBox_BlockKeyboardPropagation.Name = "checkBox_BlockKeyboardPropagation";
			checkBox_BlockKeyboardPropagation.Size = new Size(129, 19);
			checkBox_BlockKeyboardPropagation.TabIndex = 4;
			checkBox_BlockKeyboardPropagation.Text = "Block original input";
			checkBox_BlockKeyboardPropagation.UseVisualStyleBackColor = true;
			// 
			// Form_HookBuilder
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(410, 209);
			Controls.Add(tabControl1);
			Name = "Form_HookBuilder";
			Text = "Hook Builder";
			tabControl1.ResumeLayout(false);
			tabPage_MouseHookBuilder.ResumeLayout(false);
			tabPage_MouseHookBuilder.PerformLayout();
			groupBox_MouseWheel.ResumeLayout(false);
			groupBox_MouseWheel.PerformLayout();
			groupBox_MouseButton.ResumeLayout(false);
			groupBox_MouseButton.PerformLayout();
			groupBox_MouseAction.ResumeLayout(false);
			groupBox_MouseAction.PerformLayout();
			tabPage_KeyboardHookBuilder.ResumeLayout(false);
			tabPage_KeyboardHookBuilder.PerformLayout();
			groupBox_KeyboardKey.ResumeLayout(false);
			groupBox_KeyboardKey.PerformLayout();
			groupBox_KeyboardAction.ResumeLayout(false);
			groupBox_KeyboardAction.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage_MouseHookBuilder;
		private TabPage tabPage_KeyboardHookBuilder;
		private GroupBox groupBox_MouseWheel;
		private GroupBox groupBox_MouseButton;
		private GroupBox groupBox_MouseAction;
		private RadioButton radioButton_ActionWheel;
		private RadioButton radioButton_ActionMouseUp;
		private RadioButton radioButton_ActionMouseDown;
		private RadioButton radioButton_ActionMove;
		private RadioButton radioButton_ButtonMB5;
		private RadioButton radioButton_ButtonMB4;
		private RadioButton radioButton_ButtonRMB;
		private RadioButton radioButton_ButtonMMB;
		private RadioButton radioButton_ButtonLMB;
		private RadioButton radioButton_MouseWheelDown;
		private RadioButton radioButton_MouseWheelUp;
		private GroupBox groupBox_KeyboardAction;
		private RadioButton radioButton_KeyboardKeyUp;
		private RadioButton radioButton_KeyboardKeyDown;
		private GroupBox groupBox_KeyboardKey;
		private CheckBox checkBox_Win;
		private CheckBox checkBox_Alt;
		private CheckBox checkBox_Control;
		private CheckBox checkBox_Shift;
		private ComboBox comboBox_Key;
		private CheckBox checkBox_BlockMousePropagation;
		private CheckBox checkBox_BlockKeyboardPropagation;
	}
}