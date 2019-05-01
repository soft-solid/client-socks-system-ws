using System;
using System.Windows.Forms;
using TestTypeApp.Factories;
using TestTypeApp.View.Entries;

namespace TestTypeApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(PresenterFactory.Instance));
        }
    }
}
