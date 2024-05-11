namespace WinEvents
{
	partial class InputQueueForm
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
			components = new System.ComponentModel.Container();
			flowLayoutPanel_InputQueue = new FlowLayoutPanel();
			panel_MouseMoveGenerator = new Panel();
			panel_MouseDownGenerator = new Panel();
			panel_MouseUpGenerator = new Panel();
			panel_KeyDownGenerator = new Panel();
			panel_KeyUpGenerator = new Panel();
			contextMenuStrip_Delete = new ContextMenuStrip(components);
			deleteToolStripMenuItem = new ToolStripMenuItem();
			panel_Delete = new Panel();
			panel_StringInputGenerator = new Panel();
			contextMenuStrip_Delete.SuspendLayout();
			SuspendLayout();
			// 
			// flowLayoutPanel_InputQueue
			// 
			flowLayoutPanel_InputQueue.AllowDrop = true;
			flowLayoutPanel_InputQueue.AutoScroll = true;
			flowLayoutPanel_InputQueue.AutoSize = true;
			flowLayoutPanel_InputQueue.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			flowLayoutPanel_InputQueue.BorderStyle = BorderStyle.FixedSingle;
			flowLayoutPanel_InputQueue.Dock = DockStyle.Bottom;
			flowLayoutPanel_InputQueue.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel_InputQueue.Location = new Point(0, 87);
			flowLayoutPanel_InputQueue.MaximumSize = new Size(0, 120);
			flowLayoutPanel_InputQueue.MinimumSize = new Size(425, 155);
			flowLayoutPanel_InputQueue.Name = "flowLayoutPanel_InputQueue";
			flowLayoutPanel_InputQueue.Size = new Size(800, 155);
			flowLayoutPanel_InputQueue.TabIndex = 2;
			flowLayoutPanel_InputQueue.DragDrop += FlowLayoutPanel_InputQueue_DragDrop;
			flowLayoutPanel_InputQueue.DragEnter += FlowLayoutPanel_InputQueue_DragEnter;
			flowLayoutPanel_InputQueue.DragOver += FlowLayoutPanel_InputQueue_DragOver;
			flowLayoutPanel_InputQueue.DragLeave += FlowLayoutPanel_InputQueue_DragLeave;
			// 
			// panel_MouseMoveGenerator
			// 
			panel_MouseMoveGenerator.BackColor = Color.White;
			panel_MouseMoveGenerator.BackgroundImage = Properties.Resources._175081;
			panel_MouseMoveGenerator.BackgroundImageLayout = ImageLayout.Zoom;
			panel_MouseMoveGenerator.Cursor = Cursors.SizeAll;
			panel_MouseMoveGenerator.Location = new Point(12, 12);
			panel_MouseMoveGenerator.Name = "panel_MouseMoveGenerator";
			panel_MouseMoveGenerator.Size = new Size(50, 50);
			panel_MouseMoveGenerator.TabIndex = 3;
			panel_MouseMoveGenerator.MouseDown += MouseMoveGenerator_MouseDown;
			// 
			// panel_MouseDownGenerator
			// 
			panel_MouseDownGenerator.BackColor = Color.White;
			panel_MouseDownGenerator.BackgroundImage = Properties.Resources._1714463_200;
			panel_MouseDownGenerator.BackgroundImageLayout = ImageLayout.Zoom;
			panel_MouseDownGenerator.Cursor = Cursors.SizeAll;
			panel_MouseDownGenerator.Location = new Point(68, 12);
			panel_MouseDownGenerator.Name = "panel_MouseDownGenerator";
			panel_MouseDownGenerator.Size = new Size(50, 50);
			panel_MouseDownGenerator.TabIndex = 3;
			panel_MouseDownGenerator.MouseDown += MouseDownGenerator_MouseDown;
			// 
			// panel_MouseUpGenerator
			// 
			panel_MouseUpGenerator.BackColor = Color.White;
			panel_MouseUpGenerator.BackgroundImage = Properties.Resources._115746;
			panel_MouseUpGenerator.BackgroundImageLayout = ImageLayout.Zoom;
			panel_MouseUpGenerator.Cursor = Cursors.SizeAll;
			panel_MouseUpGenerator.Location = new Point(124, 12);
			panel_MouseUpGenerator.Name = "panel_MouseUpGenerator";
			panel_MouseUpGenerator.Size = new Size(50, 50);
			panel_MouseUpGenerator.TabIndex = 3;
			panel_MouseUpGenerator.MouseDown += MouseUpGenerator_MouseDown;
			// 
			// panel_KeyDownGenerator
			// 
			panel_KeyDownGenerator.BackgroundImage = Properties.Resources.keyboard_key_down;
			panel_KeyDownGenerator.BackgroundImageLayout = ImageLayout.Zoom;
			panel_KeyDownGenerator.Cursor = Cursors.SizeAll;
			panel_KeyDownGenerator.Location = new Point(180, 12);
			panel_KeyDownGenerator.Name = "panel_KeyDownGenerator";
			panel_KeyDownGenerator.Size = new Size(50, 50);
			panel_KeyDownGenerator.TabIndex = 3;
			panel_KeyDownGenerator.MouseDown += KeyDownGenerator_MouseDown;
			// 
			// panel_KeyUpGenerator
			// 
			panel_KeyUpGenerator.BackgroundImage = Properties.Resources.keyboard_key_up;
			panel_KeyUpGenerator.BackgroundImageLayout = ImageLayout.Zoom;
			panel_KeyUpGenerator.Cursor = Cursors.SizeAll;
			panel_KeyUpGenerator.Location = new Point(236, 12);
			panel_KeyUpGenerator.Name = "panel_KeyUpGenerator";
			panel_KeyUpGenerator.Size = new Size(50, 50);
			panel_KeyUpGenerator.TabIndex = 3;
			panel_KeyUpGenerator.MouseDown += KeyUpGenerator_MouseDown;
			// 
			// contextMenuStrip_Delete
			// 
			contextMenuStrip_Delete.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
			contextMenuStrip_Delete.Name = "contextMenuStrip_Delete";
			contextMenuStrip_Delete.Size = new Size(108, 26);
			// 
			// deleteToolStripMenuItem
			// 
			deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			deleteToolStripMenuItem.Size = new Size(107, 22);
			deleteToolStripMenuItem.Text = "Delete";
			deleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
			// 
			// panel_Delete
			// 
			panel_Delete.AllowDrop = true;
			panel_Delete.BackgroundImage = Properties.Resources.pngtree_rounded_flat_vector_icon_of_a_red_trash_can_vector_picture_image_9721363;
			panel_Delete.BackgroundImageLayout = ImageLayout.Zoom;
			panel_Delete.Location = new Point(738, 12);
			panel_Delete.Name = "panel_Delete";
			panel_Delete.Size = new Size(50, 50);
			panel_Delete.TabIndex = 4;
			panel_Delete.DragDrop += Panel_Delete_DragDrop;
			panel_Delete.DragEnter += Panel_Delete_DragEnter;
			// 
			// panel_StringInputGenerator
			// 
			panel_StringInputGenerator.AllowDrop = true;
			panel_StringInputGenerator.BackgroundImage = Properties.Resources._2911230;
			panel_StringInputGenerator.BackgroundImageLayout = ImageLayout.Zoom;
			panel_StringInputGenerator.Cursor = Cursors.SizeAll;
			panel_StringInputGenerator.Location = new Point(292, 12);
			panel_StringInputGenerator.Name = "panel_StringInputGenerator";
			panel_StringInputGenerator.Size = new Size(50, 50);
			panel_StringInputGenerator.TabIndex = 5;
			panel_StringInputGenerator.MouseDown += StringInputGenerator_MouseDown;
			// 
			// InputQueueForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 242);
			Controls.Add(panel_StringInputGenerator);
			Controls.Add(panel_Delete);
			Controls.Add(panel_KeyUpGenerator);
			Controls.Add(panel_KeyDownGenerator);
			Controls.Add(panel_MouseUpGenerator);
			Controls.Add(panel_MouseDownGenerator);
			Controls.Add(panel_MouseMoveGenerator);
			Controls.Add(flowLayoutPanel_InputQueue);
			Name = "InputQueueForm";
			Text = "Input queue builder";
			contextMenuStrip_Delete.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel_InputQueue;
		private Panel panel_MouseMoveGenerator;
		private Panel panel_MouseDownGenerator;
		private Panel panel_MouseUpGenerator;
		private Panel panel_KeyDownGenerator;
		private Panel panel_KeyUpGenerator;
		private ContextMenuStrip contextMenuStrip_Delete;
		private ToolStripMenuItem deleteToolStripMenuItem;
		private Panel panel_Delete;
		private Panel panel_StringInputGenerator;
	}
}