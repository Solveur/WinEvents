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
			flowLayoutPanel1 = new FlowLayoutPanel();
			inputOverride1 = new InputOverride();
			button1_AddOverride = new Button();
			flowLayoutPanel2 = new FlowLayoutPanel();
			mouseMoveBlock2 = new MouseMoveBlock();
			mouseDownBlock1 = new InputBlocks.MouseDownBlock();
			mouseUpBlock1 = new InputBlocks.MouseUpBlock();
			button1 = new Button();
			button2 = new Button();
			flowLayoutPanel1.SuspendLayout();
			flowLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.BackColor = SystemColors.Control;
			flowLayoutPanel1.Controls.Add(inputOverride1);
			flowLayoutPanel1.Controls.Add(button1_AddOverride);
			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel1.Location = new Point(0, 0);
			flowLayoutPanel1.Margin = new Padding(3, 0, 3, 0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Padding = new Padding(5, 5, 0, 0);
			flowLayoutPanel1.Size = new Size(370, 631);
			flowLayoutPanel1.TabIndex = 0;
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
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.AutoSize = true;
			flowLayoutPanel2.Controls.Add(mouseMoveBlock2);
			flowLayoutPanel2.Controls.Add(mouseDownBlock1);
			flowLayoutPanel2.Controls.Add(mouseUpBlock1);
			flowLayoutPanel2.Controls.Add(button2);
			flowLayoutPanel2.Location = new Point(376, 12);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Size = new Size(494, 149);
			flowLayoutPanel2.TabIndex = 1;
			// 
			// mouseMoveBlock2
			// 
			mouseMoveBlock2.AutoSize = true;
			mouseMoveBlock2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			mouseMoveBlock2.Location = new Point(3, 3);
			mouseMoveBlock2.MinimumSize = new Size(20, 20);
			mouseMoveBlock2.Name = "mouseMoveBlock2";
			mouseMoveBlock2.Padding = new Padding(3);
			mouseMoveBlock2.Size = new Size(125, 120);
			mouseMoveBlock2.TabIndex = 0;
			// 
			// mouseDownBlock1
			// 
			mouseDownBlock1.AutoSize = true;
			mouseDownBlock1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			mouseDownBlock1.Location = new Point(134, 3);
			mouseDownBlock1.MinimumSize = new Size(20, 120);
			mouseDownBlock1.Name = "mouseDownBlock1";
			mouseDownBlock1.Size = new Size(135, 120);
			mouseDownBlock1.TabIndex = 2;
			// 
			// mouseUpBlock1
			// 
			mouseUpBlock1.AutoSize = true;
			mouseUpBlock1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			mouseUpBlock1.Location = new Point(275, 3);
			mouseUpBlock1.MinimumSize = new Size(20, 120);
			mouseUpBlock1.Name = "mouseUpBlock1";
			mouseUpBlock1.Size = new Size(135, 120);
			mouseUpBlock1.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new Point(428, 192);
			button1.Name = "button1";
			button1.Size = new Size(129, 39);
			button1.TabIndex = 2;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += Button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(416, 3);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 3;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(1026, 631);
			Controls.Add(button1);
			Controls.Add(flowLayoutPanel2);
			Controls.Add(flowLayoutPanel1);
			Name = "MainForm";
			Text = "Form1";
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel2.ResumeLayout(false);
			flowLayoutPanel2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
		private InputOverride inputOverride1;
		private Button button1_AddOverride;
		private FlowLayoutPanel flowLayoutPanel2;
		private MouseMoveBlock mouseMoveBlock2;
		private Button button1;
		private InputBlocks.MouseDownBlock mouseDownBlock1;
		private InputBlocks.MouseUpBlock mouseUpBlock1;
		private Button button2;
	}
}