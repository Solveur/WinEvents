namespace WinEvents
{
  using System.Diagnostics;
  using System.Runtime.InteropServices;
  using static MouseMethods;
  using static NativeMethods;

  public delegate bool CallBack(int hwnd, int lParam);
  public partial class Form1 : Form
  {
    private const int WM_KEYDOWN = 0x0100;
    private static HookProc _proc = HookCallback;
    private static IntPtr _hookID = IntPtr.Zero;

    public static void Main()
    {
      _hookID = SetHook(_proc);
      Application.Run();
      UnhookWindowsHookEx(_hookID);
    }

    private static IntPtr SetHook(HookProc proc)
    {
      using (Process curProcess = Process.GetCurrentProcess())
      using (ProcessModule curModule = curProcess.MainModule)
      {
        return SetWindowsHookEx(HookId.MouseLowLevel, proc, GetModuleHandle(curModule.ModuleName), 0);
      }
    }

    public static Point PointFromLParam(IntPtr lParam)
    {
			return new Point((ushort)lParam, (ushort)lParam >> 16);
    }

    private static IntPtr HookCallback(int nCode, wParam wParam, IntPtr lParam)
    {
      if (nCode >= 0)
      {
        Point p = PointFromLParam(lParam);
        Console.WriteLine($"{nCode}, {wParam}, {Convert.ToString(p, 2)}");
      }
      return CallNextHookEx(0, nCode, wParam, lParam);
    }
  }
}