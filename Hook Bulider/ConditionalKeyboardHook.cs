namespace WinEvents
{
	using System.Runtime.InteropServices;
	using Hooks;

	public class ConditionalKeyboardHook : KeyboardHook
	{
		public MessageType EventToCatch;
		public Keys KeyToCatch;

		protected override IntPtr HookCallbackProcedure(HookType nCode, MessageType messageType, nint lParam)
		{
			KeyboardLLHookStruct keyboardInfo = Marshal.PtrToStructure<KeyboardLLHookStruct>(lParam);

			bool control = ((GetKeyState(Keys.LControlKey) & 0x80) != 0) || ((GetKeyState(Keys.RControlKey) & 0x80) != 0);
			bool shift = ((GetKeyState(Keys.LShiftKey) & 0x80) != 0) || ((GetKeyState(Keys.RShiftKey) & 0x80) != 0);
			bool alt = ((GetKeyState(Keys.LMenu) & 0x80) != 0) || ((GetKeyState(Keys.RMenu) & 0x80) != 0);
			Keys keyboardEventKey = (Keys)(keyboardInfo.VirtualKeyCode | (control ? (uint)Keys.Control : 0) | (shift ? (uint)Keys.Shift : 0) | (alt ? (uint)Keys.Alt : 0));

			if (messageType != EventToCatch || keyboardEventKey != KeyToCatch)
				return CallNextHookEx(_handleToHook, nCode, messageType, lParam);

			return base.HookCallbackProcedure(nCode, messageType, lParam);
		}
	}
}
