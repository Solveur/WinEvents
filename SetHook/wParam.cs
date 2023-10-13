namespace WinEvents.SetHook
{
	public enum wParam
	{
		/// <summary>
		/// Posted to the window with the keyboard focus when a non-system key is pressed.
		/// A non-system key is a key that is pressed when the ALT key is not pressed.
		/// </summary>
		WM_KEYDOWN = 0x0100,

		/// <summary>
		/// Posted to the window with the keyboard focus when a non-system key is released.
		/// A non-system key is a key that is pressed when the ALT key is not pressed,
		/// or a keyboard key that is pressed when a window has the keyboard focus.
		/// </summary>
		WM_KEYUP = 0x0101,

		/// <summary>
		/// Posted to the window with the keyboard focus
		/// when the user presses the F10 key (which activates the menu bar)
		/// or holds down the ALT key and then presses another key.
		/// It also occurs when no window currently has the keyboard focus;
		/// in this case, the WM_SYSKEYDOWN message is sent to the active window.
		/// The window that receives the message can distinguish between these two contexts
		/// by checking the context code in the lParam parameter.
		/// </summary>
		WM_SYSKEYDOWN = 0x0104,

		/// <summary>
		/// Posted to the window with the keyboard focus
		/// when the user releases a key that was pressed while the ALT key was held down.
		/// It also occurs when no window currently has the keyboard focus;
		/// in this case, the WM_SYSKEYUP message is sent to the active window.
		/// The window that receives the message can distinguish between these two contexts
		/// by checking the context code in the lParam parameter.
		/// </summary>
		WM_SYSKEYUP = 0x0105,

		/// <summary>
		/// Posted when the user presses the left mouse button
		/// while the cursor is in the client area of a window.
		/// If the mouse is not captured, the message is posted to the window beneath the cursor.
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// </summary>
		WM_LBUTTONDOWN = 0x0201,

		/// <summary>
		/// Posted when the user releases the left mouse button
		/// while the cursor is in the client area of a window.
		/// If the mouse is not captured, the message is posted to the window beneath the cursor.
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// </summary>
		WM_LBUTTONUP = 0x0202,

		/// <summary>
		/// Posted to a window when the cursor moves.
		/// If the mouse is not captured, the message is posted to the window that contains the cursor.
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// </summary>
		WM_MOUSEMOVE = 0x0200,

		/// <summary>
		/// Sent to the focus window when the mouse wheel is rotated.
		/// The DefWindowProc function propagates the message to the window's parent.
		/// There should be no internal forwarding of the message,
		/// since DefWindowProc propagates it up the parent chain
		/// until it finds a window that processes it.
		/// </summary>
		WM_MOUSEWHEEL = 0x020A,

		/// <summary>
		/// Posted when the user presses the right mouse button
		/// while the cursor is in the client area of a window.
		/// If the mouse is not captured, the message is posted to the window beneath the cursor.
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// </summary>
		WM_RBUTTONDOWN = 0x0204,

		/// <summary>
		/// Posted when the user releases the right mouse button
		/// while the cursor is in the client area of a window.
		/// If the mouse is not captured, the message is posted to the window beneath the cursor.
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// </summary>
		WM_RBUTTONUP  = 0x0205,
		
		/// <summary>
		/// Posted when the user presses the middle mouse button
		/// while the cursor is in the client area of a window.
		/// If the mouse is not captured, the message is posted to the window beneath the cursor.
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// </summary>
		WM_MIDDOWN = 0x0207,
		
		/// <summary>
		/// Posted when the user releases the middle mouse button
		/// while the cursor is in the client area of a window.
		/// If the mouse is not captured, the message is posted to the window beneath the cursor.
		/// Otherwise, the message is posted to the window that has captured the mouse.
		/// </summary>
		WM_MIDUP = 0x0208,
	}
}