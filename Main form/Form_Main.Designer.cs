namespace WinEvents
{
	partial class Form_Main
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
			flowLayoutPanel_InputOverrides = new FlowLayoutPanel();
			button_AddOverride = new Button();
			flowLayoutPanel_InputOverrides.SuspendLayout();
			SuspendLayout();
			// 
			// flowLayoutPanel_InputOverrides
			// 
			flowLayoutPanel_InputOverrides.AutoScroll = true;
			flowLayoutPanel_InputOverrides.BackColor = SystemColors.Control;
			flowLayoutPanel_InputOverrides.Controls.Add(button_AddOverride);
			flowLayoutPanel_InputOverrides.Dock = DockStyle.Left;
			flowLayoutPanel_InputOverrides.Location = new Point(0, 0);
			flowLayoutPanel_InputOverrides.Margin = new Padding(3, 0, 3, 0);
			flowLayoutPanel_InputOverrides.MaximumSize = new Size(420, 0);
			flowLayoutPanel_InputOverrides.Name = "flowLayoutPanel_InputOverrides";
			flowLayoutPanel_InputOverrides.Padding = new Padding(5, 5, 0, 0);
			flowLayoutPanel_InputOverrides.Size = new Size(389, 631);
			flowLayoutPanel_InputOverrides.TabIndex = 0;
			// 
			// button_AddOverride
			// 
			button_AddOverride.Location = new Point(7, 8);
			button_AddOverride.Margin = new Padding(2, 3, 3, 3);
			button_AddOverride.Name = "button_AddOverride";
			button_AddOverride.Size = new Size(356, 60);
			button_AddOverride.TabIndex = 1;
			button_AddOverride.Text = "Add override";
			button_AddOverride.UseVisualStyleBackColor = true;
			button_AddOverride.Click += Button_AddOverride_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(389, 631);
			Controls.Add(flowLayoutPanel_InputOverrides);
			Name = "MainForm";
			Text = "Form1";
			flowLayoutPanel_InputOverrides.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel_InputOverrides;
		private Button button_AddOverride;
	}
}