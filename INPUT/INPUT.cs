namespace WinEvents
{
	internal partial class NativeMethods
	{
		/// <summary>
		/// Used by SendInput to store information for synthesizing input events such as keystrokes, mouse movement, and mouse clicks.
		/// </summary>
		public struct INPUT
		{
			public InputType type;
			public InputUnion union;
		}
	}
}
