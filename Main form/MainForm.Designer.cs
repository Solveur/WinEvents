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
			flowLayoutPanel_TestSurface = new FlowLayoutPanel();
			mouseMoveBlock1 = new InputBlocks.MouseMoveBlock();
			mouseDownBlock1 = new InputBlocks.MouseDownBlock();
			mouseUpBlock1 = new InputBlocks.MouseUpBlock();
			button1 = new Button();
			flowLayoutPanel_InputOverrides.SuspendLayout();
			flowLayoutPanel_TestSurface.SuspendLayout();
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
			// flowLayoutPanel_TestSurface
			// 
			flowLayoutPanel_TestSurface.AllowDrop = true;
			flowLayoutPanel_TestSurface.AutoSize = true;
			flowLayoutPanel_TestSurface.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			flowLayoutPanel_TestSurface.Controls.Add(mouseMoveBlock1);
			flowLayoutPanel_TestSurface.Controls.Add(mouseDownBlock1);
			flowLayoutPanel_TestSurface.Controls.Add(mouseUpBlock1);
			flowLayoutPanel_TestSurface.Location = new Point(376, 12);
			flowLayoutPanel_TestSurface.MinimumSize = new Size(425, 126);
			flowLayoutPanel_TestSurface.Name = "flowLayoutPanel_TestSurface";
			flowLayoutPanel_TestSurface.Size = new Size(425, 126);
			flowLayoutPanel_TestSurface.TabIndex = 1;
			flowLayoutPanel_TestSurface.DragEnter += flowLayoutPanel_TestSurface_DragEnter;
			// 
			// mouseMoveBlock1
			// 
			mouseMoveBlock1.AutoSize = true;
			mouseMoveBlock1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			mouseMoveBlock1.Location = new Point(3, 3);
			mouseMoveBlock1.MinimumSize = new Size(20, 20);
			mouseMoveBlock1.Name = "mouseMoveBlock1";
			mouseMoveBlock1.Padding = new Padding(3);
			mouseMoveBlock1.Size = new Size(125, 120);
			mouseMoveBlock1.TabIndex = 4;
			// 
			// mouseDownBlock1
			// 
			mouseDownBlock1.AutoSize = true;
			mouseDownBlock1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			mouseDownBlock1.Location = new Point(134, 3);
			mouseDownBlock1.MinimumSize = new Size(20, 120);
			mouseDownBlock1.Name = "mouseDownBlock1";
			mouseDownBlock1.Padding = new Padding(3);
			mouseDownBlock1.Size = new Size(141, 120);
			mouseDownBlock1.TabIndex = 2;
			// 
			// mouseUpBlock1
			// 
			mouseUpBlock1.AutoSize = true;
			mouseUpBlock1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			mouseUpBlock1.Location = new Point(281, 3);
			mouseUpBlock1.MinimumSize = new Size(20, 120);
			mouseUpBlock1.Name = "mouseUpBlock1";
			mouseUpBlock1.Padding = new Padding(3);
			mouseUpBlock1.Size = new Size(141, 120);
			mouseUpBlock1.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new Point(430, 212);
			button1.Name = "button1";
			button1.Size = new Size(129, 39);
			button1.TabIndex = 2;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += Button1_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(1026, 631);
			Controls.Add(flowLayoutPanel_TestSurface);
			Controls.Add(flowLayoutPanel_InputOverrides);
			Controls.Add(button1);
			Name = "MainForm";
			Text = "Form1";
			flowLayoutPanel_InputOverrides.ResumeLayout(false);
			flowLayoutPanel_TestSurface.ResumeLayout(false);
			flowLayoutPanel_TestSurface.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel_InputOverrides;
		private FlowLayoutPanel flowLayoutPanel_TestSurface;
		private InputOverride inputOverride1;
		private Button button1_AddOverride;
		private Button button1;
		private InputBlocks.MouseDownBlock mouseDownBlock1;
		private InputBlocks.MouseUpBlock mouseUpBlock1;
		private InputBlocks.MouseMoveBlock mouseMoveBlock1;
	}
}