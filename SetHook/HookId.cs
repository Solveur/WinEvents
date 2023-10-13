namespace WinEvents.SetHook
{
	public enum HookId : int
	{
		/// <summary>
		/// Installs a hook procedure that monitors messages
		/// before the system sends them to the destination window procedure.
		/// </summary>
		CallWindowProcedure = 4,

		/// <summary>
		/// Installs a hook procedure that monitors messages
		/// after they have been processed by the destination window procedure.
		/// </summary>
		CallWindowProcedureRet = 12,

		/// <summary>
		/// Installs a hook procedure that receives
		/// notifications useful to a CBT application.
		/// </summary>
		ComputerBasedTraining = 5,

		/// <summary>
		/// Installs a hook procedure useful for
		/// debugging other hook procedures.
		/// </summary>
		Debug = 9,

		/// <summary>
		/// Installs a hook procedure that will be called 
		/// when the application's foreground thread is about to become idle.
		/// </summary>
		ForegroundIdle = 11, 

		/// <summary>
		/// Installs a hook procedure that monitors
		/// messages posted to a message queue. 
		/// </summary>
		GetMessageProcedure = 3,
		
		/// <summary>
		/// Installs a hook procedure that monitors 
		/// keystroke messages.
		/// </summary>
		Keyboard = 2,

		/// <summary>
		/// Installs a hook procedure that monitors 
		/// low-level keyboard input events.
		/// </summary>
		KeyboardLowLevel = 13,

		/// <summary>
		/// Installs a hook procedure that monitors mouse messages.
		/// </summary>
		Mouse = 7,

		/// <summary>
		/// Installs a hook procedure that monitors low-level mouse input events. 
		/// </summary>
		MouseLowLevel = 14,

		/// <summary>
		/// Installs a hook procedure that monitors messages
		/// generated as a result of an input event in a dialog box,
		/// message box, menu, or scroll bar. 
		/// </summary>
		MessageFilter = -1,

		/// <summary>
		/// Installs a hook procedure that receives
		/// notifications useful to shell applications. 
		/// </summary>
		Shell = 10,

		/// <summary>
		/// Installs a hook procedure that monitors
		/// messages generated as a result of an input event in
		/// a dialog box, message box, menu, or scroll bar.
		/// The hook procedure monitors these messages for all 
		/// applications in the same desktop as the calling thread. 
		/// </summary>
		SystemMessageFilter = 6
	}
}