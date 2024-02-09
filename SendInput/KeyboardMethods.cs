namespace WinEvents.SendInput
{
	using System.Runtime.InteropServices;
	using static NativeMethods;

	public static class KeyboardMethods
	{
		public static uint SendKeyboardInput()
		{
			Input[] inputs =
			[
				new Input
				{
					type = InputType.Keyboard,
					union = new InputUnion
					{
						keyboard = new KeyboardInput
						{
							scanCode = 17,
							flags = KeyboardFlags.KeyDown | KeyboardFlags.Unicode,
							extraInfo = GetMessageExtraInfo()
						}
					}
				},
				new Input
				{
					type = InputType.Keyboard,
					union = new InputUnion
					{
						keyboard = new KeyboardInput
						{
							scanCode = 17,
							flags = KeyboardFlags.KeyUp | KeyboardFlags.Unicode,
							extraInfo = GetMessageExtraInfo()
						}
					}
				}
			];

			Input input =
			new Input
			{
				type = InputType.Keyboard,
				union = new InputUnion
				{
					keyboard = new KeyboardInput
					{
						virtualKey = 0x44,
						flags = KeyboardFlags.KeyDown,
						extraInfo = GetMessageExtraInfo()
					}
				}
			};

			return SendInput(inputs);
		}
	}
}
