using System;
using System.Diagnostics;

namespace GordoTAS
{
    class WindowLogic
    {
        public static IntPtr GetWindowHandlerByName(string winName)
        {
            IntPtr hWnd = IntPtr.Zero;
            Process[] list = Process.GetProcesses();
            foreach (Process p in list)
            {
                if (p.MainWindowTitle.Contains( winName))
                {
                    Console.WriteLine("Process: " + p.ProcessName + " | Main Window name: " + p.MainWindowTitle);
                    hWnd = p.MainWindowHandle;
                    Console.WriteLine("found");
                }
            }
            return hWnd;
        }
    }
}
