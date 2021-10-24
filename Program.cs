using System;
using System.Windows.Forms;

namespace GordoTAS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            FPSSync.ins = new FPSSync();
            InputStorage.ins = new InputStorage();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow.main = new MainWindow();
            InputProcessing.ins = new InputProcessing();
            GlobalVars.ins = new GlobalVars();
            Application.EnableVisualStyles();
            Application.Run(MainWindow.main);
        }
    }
}
