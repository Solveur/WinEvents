namespace WinEvents
{
	partial class MainForm
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
			inputOverride1 = new InputOverride();
			button1_AddOverride = new Button();
			button1 = new Button();
			flowLayoutPanel_InputOverrides.SuspendLayout();
			SuspendLayout();
			// 
			// flowLayoutPanel_InputOverrides
			// 
			flowLayoutPanel_InputOverrides.BackColor = SystemColors.Control;
			flowLayoutPanel_InputOverrides.Controls.Add(inputOverride1);
			flowLayoutPanel_InputOverrides.Controls.Add(button1_AddOverride);
			flowLayoutPanel_InputOverrides.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel_InputOverrides.Location = new Point(0, 0);
			flowLayoutPanel_InputOverrides.Margin = new Padding(3, 0, 3, 0);
			flowLayoutPanel_InputOverrides.Name = "flowLayoutPanel_InputOverrides";
			flowLayoutPanel_InputOverrides.Padding = new Padding(5, 5, 0, 0);
			flowLayoutPanel_InputOverrides.Size = new Size(370, 631);
			flowLayoutPanel_InputOverrides.TabIndex = 0;
			// 
			// inputOverride1
			// 
			inputOverride1.Location = new Point(5, 5);
			inputOverride1.Margin = new Padding(0);
			inputOverride1.Name = "inputOverride1";
			inputOverride1.Size = new Size(360, 85);
			inputOverride1.TabIndex = 0;
			// 
			// button1_AddOverride
			// 
			button1_AddOverride.Location = new Point(7, 93);
			button1_AddOverride.Margin = new Padding(2, 3, 3, 3);
			button1_AddOverride.Name = "button1_AddOverride";
			button1_AddOverride.Size = new Size(356, 60);
			button1_AddOverride.TabIndex = 1;
			button1_AddOverride.Text = "Add override";
			button1_AddOverride.UseVisualStyleBackColor = true;
			button1_AddOverride.Click += Button1_AddOverride_Click;
			// 
			// button1
			// 
			button1.Location = new Point(617, 188);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(1026, 631);
			Controls.Add(button1);
			Controls.Add(flowLayoutPanel_InputOverrides);
			Name = "MainForm";
			Text = "Form1";
			flowLayoutPanel_InputOverrides.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel_InputOverrides;
		private InputOverride inputOverride1;
		private Button button1_AddOverride;
		private Button button1;
	}
}