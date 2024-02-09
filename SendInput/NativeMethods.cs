namespace WinEvents.SendInput
{
	using System.Runtime.InteropServices;

	internal static partial class NativeMethods
	{
		/// <summary>
		/// Synthesizes keystrokes, mouse motions, and button clicks.
		/// </summary>
		/// <param name="nInputs">The number of structures in the pInputs array.</param>
		/// <param name="pInputs">An array of INPUT structures. Each structure represents an event to be inserted into the keyboard or mouse input stream.</param>
		/// <param name="cbSize">The size, in bytes, of an INPUT structure.</param>
		/// <returns>
		/// </returns>
		[LibraryImport("user32.dll", EntryPoint = "SendInput", SetLastError = true)]
		private static partial uint _sendInputs(uint nInputs, Input[] pInputs, int cbSize);

		/// <summary>
		/// Retrieves the extra message information for the current thread.
		/// Extra message information is an application- or driver-defined value associated with the current thread's message queue.
		/// </summary>
		/// <returns>
		/// The return value specifies the extra information. The meaning of the extra information is device specific.
		/// </returns>
		[LibraryImport("user32.dll")]
		public static partial IntPtr GetMessageExtraInfo();

		/// <summary>
		/// Synthesizes keystrokes, mouse motions, and button clicks.
		/// </summary>
		/// <param name="pInputs">An array of INPUT structures. Each structure represents an event to be inserted into the keyboard or mouse input stream.</param>
		/// <returns>
		/// The number of events that it successfully inserted into the keyboard or mouse input stream.
		/// If the function returns zero, the input was already blocked by another thread.
		/// </returns>
		public static uint SendInput(Input[] Inputs) => _sendInputs((uint)Inputs.Length, Inputs, Marshal.SizeOf<Input>());

		/// <summary>
		/// Synthesizes keystroke, mouse motion, or button click.
		/// </summary>
		/// <param name="pInput"></param>
		/// <returns>
		/// The number of events that it successfully inserted into the keyboard or mouse input stream.
		/// If the function returns zero, the input was already blocked by another thread.
		/// </returns>
		public static uint SendInput(Input Input) => _sendInputs(1, new[] { Input }, Marshal.SizeOf<Input>());
	}
}
