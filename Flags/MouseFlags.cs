﻿namespace WinEvents
{
	using System;

	internal partial class NativeMethods
	{
		/// <summary>
		/// <para>A set of bit flags that specify various aspects of mouse motion and button clicks. The bits in this member can be any reasonable combination of the following values.</para>
		/// <para>You can specify multiple flags by using binary OR operator - "|".</para>
		/// </summary>
		[Flags]
		public enum MouseFlags : uint
		{
			/// <summary>
			/// Specifies that movement occurred.
			/// </summary>
			Move = 0x0001,

			/// <summary>
			/// Specifies that the left button was pressed.
			/// </summary>
			LeftDown = 0x0002,

			/// <summary>
			/// Specifies that the left button was released.
			/// </summary>
			LeftUp = 0x0004,

			/// <summary>
			/// Specifies that the right button was pressed.
			/// </summary>
			RightDown = 0x0008,

			/// <summary>
			/// Specifies that the right button was released.
			/// </summary>
			RightUp = 0x0010,

			/// <summary>
			/// Specifies that the middle button was pressed.
			/// </summary>
			MiddleDown = 0x0020,

			/// <summary>
			/// Specifies that the middle button was released.
			/// </summary>
			MiddleUp = 0x0040,

			/// <summary>
			/// Windows 2000/XP: Specifies that an X button was pressed.
			/// </summary>
			XDown = 0x0080,

			/// <summary>
			/// Windows 2000/XP: Specifies that an X button was released.
			/// </summary>
			XUp = 0x0100,

			/// <summary>
			/// Windows NT/2000/XP: Specifies that the wheel was moved, if the mouse has a wheel. The amount of movement is specified in mouseData. 
			/// </summary>
			VerticalWheel = 0x0800,

			/// <summary>
			/// Specifies that the wheel was moved horizontally, if the mouse has a wheel. The amount of movement is specified in mouseData. Windows 2000/XP:  Not supported.
			/// </summary>
			HorizontalWheel = 0x1000,

			/// <summary>
			/// Windows 2000/XP: Maps coordinates to the entire desktop. Must be used with MOUSEEVENTF_ABSOLUTE.
			/// </summary>
			VirtualDesk = 0x4000,

			/// <summary>
			/// Specifies that the dx and dy members contain normalized absolute coordinates. If the flag is not set, dx and dy contain relative data (the change in position since the last reported position).
			/// </summary>
			Absolute = 0x8000,
		}
	}
}
