using BookManagement._1.Forms;
using BookManagement._4.Helpers;

namespace BookManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            AppPaths.EnsureDataFolder();
            Application.Run(new MainForm());
        }
    }
}