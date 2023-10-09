﻿namespace WinEvents
{
	using System.Runtime.InteropServices;
	using Handle = IntPtr;
	using hHook = IntPtr;
	using hInstance = IntPtr;
	using lParam = IntPtr;
	using lResult = IntPtr;
	using DWORD = UIntPtr;

	public delegate IntPtr HookProc(int nCode, wParam wParam, lParam lParam);
	public enum wParam
	{
		/// <summary>
		/// Posted to the window with the keyboard focus when a nonsystem key is pressed.
		/// A nonsystem key is a key that is pressed when the ALT key is not pressed.
		/// </summary>
		WM_KEYDOWN = 0x0100,

		/// <summary>
		/// Posted to the window with the keyboard focus when a nonsystem key is released.
		/// A nonsystem key is a key that is pressed when the ALT key is not pressed,
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
	}

	internal partial class NativeMethods
	{
		/// <summary>
		/// Installs an application-defined hook procedure into a hook chain.
		/// </summary>
		/// 
		/// <param name="IdHook">
		/// The type of hook procedure to be installed.
		/// </param>
		/// 
		/// <param name="lpfn">
		/// A pointer to the hook procedure.
		///		<para>
		///		If the dwThreadId parameter is zero or specifies the identifier
		///		of a thread created by a different process, the lpfn parameter
		///		must point to a hook procedure in a DLL. Otherwise, lpfn can point
		///		to a hook procedure in the code associated with the current process.
		///		</para>
		/// </param>
		/// 
		/// <param name="hInstance">
		/// A handle to the DLL containing the hook procedure
		/// pointed to by the lpfn parameter.
		///		<para>
		///		The hMod parameter must be set to NULL
		///		if the dwThreadId parameter specifies a thread created by the
		///		current process and if the hook procedure is within the
		///		code associated with the current process.
		///		</para>
		/// </param>
		/// 
		/// <param name="dwThreadId">
		/// The identifier of the thread with which the hook procedure is to be
		/// associated.
		///		<para>
		///		For desktop apps, if this parameter is zero,
		///		the hook procedure is associated with all existing threads running
		///		in the same desktop as the calling thread.
		///		</para>
		/// </param>
		/// 
		/// <returns>
		/// If the function succeeds, the return value is the handle to the hook procedure.
		/// <para>
		/// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
		/// </para>
		/// </returns>
		[LibraryImport("user32.dll", EntryPoint = "SetWindowsHookExA", SetLastError = true)]
		public static partial hHook SetWindowsHookEx(HookId idHook, HookProc lpfn, hInstance hmod, DWORD dwThreadId);

		/// <summary>
		/// Passes the hook information to the next hook procedure in the current hook chain. A hook procedure can call this function either before or after processing the hook information.
		/// </summary>
		/// 
		/// <param name="hhk">
		/// This parameter is ignored.
		/// </param>
		/// 
		/// <param name="nCode">
		/// The hook code passed to the current hook procedure.
		/// The next hook procedure uses this code to determine
		/// how to process the hook information.
		/// </param>
		/// 
		/// <param name="wParam">
		/// The wParam value passed to the current hook procedure.
		/// The meaning of this parameter depends on the type of hook 
		/// associated with the current hook chain.
		/// </param>
		/// 
		/// <param name="lParam">
		/// The lParam value passed to the current hook procedure.
		/// The meaning of this parameter depends on the type of hook
		/// associated with the current hook chain.
		/// </param>
		/// 
		/// <returns>
		/// This value is returned by the next hook procedure in the chain.
		/// The current hook procedure must also return this value.
		/// The meaning of the return value depends on the hook type.
		/// </returns>
		[LibraryImport("user32.dll", EntryPoint = "CallNextHookEx", SetLastError = true)]
		public static partial lResult CallNextHookEx(hHook hhk, int nCode, wParam wParam, lParam lParam);


		/// <summary>
		/// Removes a hook procedure installed in a hook chain by the SetWindowsHookEx function.
		/// </summary>
		/// 
		/// <param name="hhk">
		/// A handle to the hook to be removed.
		/// This parameter is a hook handle obtained by a previous call
		/// to SetWindowsHookEx.
		/// </param>
		/// 
		/// <returns>
		/// If the function succeeds, the return value is nonzero.
		/// If the function fails, the return value is zero.
		/// To get extended error information, call GetLastError.
		/// </returns>
		[LibraryImport("user32.dll", EntryPoint = "UnhookWindowsHookEx", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static partial bool UnhookWindowsHookEx(hHook hhk);
		
		/// <summary>
		/// Retrieves a module handle for the specified module.
		/// The module must have been loaded by the calling process.
		/// </summary>
		/// 
		/// <param name="lpModuleName">
		/// The name of the loaded module (either a .dll or .exe file).
		///		<para>
		///		If the file name extension is omitted, the default library extension .dll is appended.
		///		The file name string can include a trailing point character (.)
		///		to indicate that the module name has no extension.
		///		</para>
		///		<para>
		///		The string does not have to specify a path.
		///		When specifying a path, be sure to use backslashes (\), not forward slashes (/).
		///		The name is compared (case independently) to the names of modules currently
		///		mapped into the address space of the calling process.
		///		</para>
		/// </param>
		/// 
		/// <returns>
		/// If the function succeeds, the return value is a handle to the specified module.
		/// If the function fails, the return value is NULL.
		/// </returns>
    [LibraryImport("kernel32.dll", EntryPoint = "GetModuleHandleW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    public static partial Handle GetModuleHandle(string lpModuleName);
	}
}