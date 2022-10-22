using System;
using System.Windows.Forms;

namespace Csharp_DB_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new HomePage("eliyonzm"));
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.StackTrace);
            }
        }
    }
}
