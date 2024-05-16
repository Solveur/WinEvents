namespace WinEvents
{
	using System;
	using System.Windows.Forms;
	using Hooks;
	using SendInput;

	public partial class InputOverride : UserControl
	{
		private Input[] _inputs = [];
		private Hook? _hook;
		readonly Form_InputQueueBuilder _inputBuilderForm = new();
		readonly Form_HookBuilder _hookBuilderForm = new();

		public InputOverride()
		{
			InitializeComponent();
		}

		private async void Action()
		{
			await WinAPI.SendInputAsync(_inputs);
		}

		private void Button_SelecHook_Click(object sender, EventArgs e)
		{
			_hook?.Stop();
			_hookBuilderForm.ShowDialog();
			switch (_hookBuilderForm.HookType)
			{
				case HookType.MouseLL:
					MouseHook mouseHook = (MouseHook)_hookBuilderForm.Hook;
					switch (_hookBuilderForm.MouseEventType)
					{
						case MouseHook.MouseEventType.MouseMove:
							mouseHook.MouseMove += (s, e) => { Action(); };
							break;
						case MouseHook.MouseEventType.MouseDown:
							mouseHook.MouseDown += (s, e) => { Action(); };
							break;
						case MouseHook.MouseEventType.MouseUp:
							mouseHook.MouseUp += (s, e) => { Action(); };
							break;
						case MouseHook.MouseEventType.MouseWheel:
							mouseHook.MouseWheel += (s, e) => { Action(); };
							break;
					}
					_hook = mouseHook;
					break;
				case HookType.KeyboardLL:
					ConditionalKeyboardHook keyboardHook = (ConditionalKeyboardHook)_hookBuilderForm.Hook;
					switch (_hookBuilderForm.KeyboardEventType)
					{
						case MessageType.KeyDown:
							keyboardHook.KeyDown += (s, e) => { Action(); };
							break;
						case MessageType.KeyUp:
							keyboardHook.KeyUp += (s, e) => { Action(); };
							break;
					}
					_hook = keyboardHook;
					break;
			}
			_hook?.Start();
		}

		private void Button_SelectAction_Click(object sender, EventArgs e)
		{
			_inputs = BuildInputs();
		}

		private Input[] BuildInputs()
		{
			_inputBuilderForm.ShowDialog();
			return _inputBuilderForm.Inputs;
		}
	}
}
