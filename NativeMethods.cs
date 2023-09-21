namespace WinEvents
{
	using System.Runtime.InteropServices;

	internal partial class NativeMethods
	{
		/// <summary>
		/// Synthesizes keystrokes, mouse motions, and button clicks.
		/// </summary>
		/// <param name="nInputs">The number of structures in the pInputs array.</param>
		/// <param name="pInputs">An array of INPUT structures. Each structure represents an event to be inserted into the keyboard or mouse input stream.</param>
		/// <param name="cbSize">The size, in bytes, of an INPUT structure.</param>
		/// <returns></returns>
		[LibraryImport("user32.dll", EntryPoint = "SendInput")]
		private static partial uint _sendInputs(uint nInputs, INPUT[] pInputs, int cbSize);

		/// <summary>
		/// Synthesizes keystrokes, mouse motions, and button clicks.
		/// </summary>
		/// <param name="pInputs">An array of INPUT structures. Each structure represents an event to be inserted into the keyboard or mouse input stream.</param>
		/// <returns></returns>
		public static uint SendInput(INPUT[] pInputs) =>
			_sendInputs((uint)pInputs.Length, pInputs, Marshal.SizeOf(typeof(INPUT)));

		/// <summary>
		/// Synthesizes keystroke, mouse motion, or button click.
		/// </summary>
		/// <param name="pInput"></param>
		/// <returns></returns>
		public static uint SendInput(INPUT pInput) =>
			_sendInputs(1, [pInput], Marshal.SizeOf(typeof(INPUT)));
	}
}
