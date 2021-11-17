using Steam.WinForms.Account;
using System;
using System.Windows.Forms;

namespace Steam.WinForms
{
    class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            if (Launcher.Start)
            {
                Application.Run(new Launcher());
            }

        }
    }
}
