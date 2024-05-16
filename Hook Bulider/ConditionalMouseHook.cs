namespace WinEvents
{
	using System.Runtime.InteropServices;
	using Hooks;

	public class ConditionalMouseHook : MouseHook
	{
		public MouseEventType EventToCatch;
		public MouseButtons ButtonToCatch;
		/// <summary>
		/// <see langword="true"/> up, <see langword="false"/> down.
		/// </summary>
		public bool WheelDirection;

		protected override IntPtr HookCallbackProcedure(HookType nCode, MessageType messageType, nint lParam)
		{
			MouseEventType mouseEventType = GetEventType(messageType);
			MouseButtons mouseEventButton = GetButton(messageType);
			MouseLLHookStruct mouseInfo = Marshal.PtrToStructure<MouseLLHookStruct>(lParam);
			bool eventIsXButton = messageType == MessageType.XButtonDown || messageType == MessageType.XButtonUp;
			if (eventIsXButton)
				mouseEventButton = GetXButton(mouseInfo);

			bool eventRequiresButton = mouseEventType == MouseEventType.MouseDown || mouseEventType == MouseEventType.MouseUp || eventIsXButton;
			bool eventMatch = mouseEventType == EventToCatch;

			bool eventMoveCorrect = eventMatch;
			bool eventWheelCorrect = eventMatch && (mouseInfo.MouseData > 0) == WheelDirection;
			bool eventButtonCorrect = eventMatch && eventRequiresButton && mouseEventButton == ButtonToCatch;


			if (eventMoveCorrect || eventWheelCorrect || eventButtonCorrect)
				return base.HookCallbackProcedure(nCode, messageType, lParam);
			
			return CallNextHookEx(_handleToHook, nCode, messageType, lParam);
		}
	}
}
