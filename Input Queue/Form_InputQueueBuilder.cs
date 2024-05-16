namespace WinEvents
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Linq;
	using System.Windows.Forms;
	using SendInput;

	public partial class Form_InputQueueBuilder : Form
	{
		private readonly DragPlaceholderBlock placeholder = new();
		public Input[] Inputs
		{
			get => GetInputs(flowLayoutPanel_InputQueue.Controls);
		}

		public Form_InputQueueBuilder()
		{
			InitializeComponent();
			ToolTip tt = new();
			tt.SetToolTip(panel_MouseMoveGenerator, "Drag from here, to add MouseMove input in queue");
			tt.SetToolTip(panel_MouseDownGenerator, "Drag from here, to add MouseDown input in queue");
			tt.SetToolTip(panel_MouseUpGenerator, "Drag from here, to add MouseUp input in queue");
			tt.SetToolTip(panel_KeyDownGenerator, "Drag from here, to add KeyDown input in queue");
			tt.SetToolTip(panel_KeyUpGenerator, "Drag from here, to add KeyUp input in queue");
		}

		private void FlowLayoutPanel_InputQueue_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
			FlowLayoutPanel? destination = sender as FlowLayoutPanel;
			InputBlock? child = GetInputBlock(e.Data);

			placeholder.Size = child?.Size ?? new(5, 120);
			destination?.Controls.Add(placeholder);
		}

		private void FlowLayoutPanel_InputQueue_DragOver(object sender, DragEventArgs e)
		{
			Point screenCursorPosition = new(e.X, e.Y);
			FlowLayoutPanel? destination = sender as FlowLayoutPanel;
			Point containerCursorPosition = destination?.PointToClient(screenCursorPosition) ?? new(0, 0);

			// Move scroll when dragging on edge of the container


			Control? childOnDragPoint = destination?.GetChildAtPoint(containerCursorPosition);
			int index = destination?.Controls.GetChildIndex(childOnDragPoint!, false) ?? 0;

			destination?.Controls.SetChildIndex(placeholder, index);
		}

		private void FlowLayoutPanel_InputQueue_DragLeave(object sender, EventArgs e)
		{
			Control? destination = sender as Control;
			destination?.Controls.Remove(placeholder);
		}

		private void FlowLayoutPanel_InputQueue_DragDrop(object sender, DragEventArgs e)
		{
			if (sender is not FlowLayoutPanel destination)
				return;

			InputBlock? draggedChild = GetInputBlock(e.Data);

			// Get index of block on drop point
			Point pointOfDrop = destination.PointToClient(new Point(e.X, e.Y));
			Control? childOnDropPoint = destination?.GetChildAtPoint(pointOfDrop);
			int index = destination?.Controls.GetChildIndex(childOnDropPoint!, false) ?? 0;

			// Place daragged block on drop point
			destination?.Controls.Add(draggedChild);
			if (draggedChild != null)
				destination?.Controls.SetChildIndex(draggedChild, index);

			destination?.Controls.Remove(placeholder);
		}

		private void MouseMoveGenerator_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;

			MouseMoveBlock newMouseMove = new()
			{
				ContextMenuStrip = contextMenuStrip_Delete
			};
			DoDragDrop(newMouseMove, DragDropEffects.All);
			newMouseMove.Focus();
		}

		private void MouseDownGenerator_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;

			MouseDownBlock newMouseDown = new()
			{
				ContextMenuStrip = contextMenuStrip_Delete
			};
			DoDragDrop(newMouseDown, DragDropEffects.All);
			newMouseDown.Focus();
		}

		private void MouseUpGenerator_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;

			MouseUpBlock newMouseUp = new()
			{
				ContextMenuStrip = contextMenuStrip_Delete
			};
			DoDragDrop(newMouseUp, DragDropEffects.All);
			newMouseUp.Focus();
		}

		private void MouseWheelGenerator_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;

			MouseWheelBlock newMouseWheel = new()
			{
				ContextMenuStrip = contextMenuStrip_Delete
			};
			DoDragDrop(newMouseWheel, DragDropEffects.All);
			newMouseWheel.Focus();
		}

		private void KeyDownGenerator_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;

			KeyDownBlock newKeyDown = new()
			{
				ContextMenuStrip = contextMenuStrip_Delete
			};
			DoDragDrop(newKeyDown, DragDropEffects.All);
			newKeyDown.Focus();
		}

		private void KeyUpGenerator_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;

			KeyUpBlock newKeyUp = new()
			{
				ContextMenuStrip = contextMenuStrip_Delete
			};
			DoDragDrop(newKeyUp, DragDropEffects.All);
			newKeyUp.Focus();
		}

		private void StringInputGenerator_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;

			StringInputBlock newStringInput = new()
			{
				ContextMenuStrip = contextMenuStrip_Delete
			};
			DoDragDrop(newStringInput, DragDropEffects.All);
			newStringInput.Focus();
		}

		private void Panel_Delete_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
		}

		private void Panel_Delete_DragDrop(object sender, DragEventArgs e)
		{
			InputBlock? block = GetInputBlock(e.Data);
			block?.Dispose();
		}

		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripItem? deleteButton = sender as ToolStripItem;
			ContextMenuStrip? contextMenu = deleteButton?.Owner as ContextMenuStrip;
			InputBlock? block = contextMenu?.SourceControl as InputBlock;

			block?.Dispose();
		}

		private static InputBlock? GetInputBlock(IDataObject? data)
		{
			if (data == null)
				return null;

			InputBlock? maybeMouseMove = data.GetData(typeof(MouseMoveBlock)) as MouseMoveBlock;
			InputBlock? maybeMouseDown = data.GetData(typeof(MouseDownBlock)) as MouseDownBlock;
			InputBlock? maybeMouseUp = data.GetData(typeof(MouseUpBlock)) as MouseUpBlock;
			InputBlock? maybeKeyDown = data.GetData(typeof(KeyDownBlock)) as KeyDownBlock;
			InputBlock? maybeKeyUp = data.GetData(typeof(KeyUpBlock)) as KeyUpBlock;
			InputBlock? maybeStringInput = data.GetData(typeof(StringInputBlock)) as StringInputBlock;

			return maybeMouseDown ?? maybeMouseMove ?? maybeMouseUp ?? maybeKeyDown ?? maybeKeyUp ?? maybeStringInput;
		}

		private static Input[] GetInputs(Control.ControlCollection collection)
		{
			return collection
				.OfType<InputBlock>()
				.Cast<InputBlock>()
				.Select(block => block.Input)
				.Aggregate((Input[])[], (a, b) => [.. a, .. b]);
		}
	}
}
