using BookManagement._1.Forms;
using BookManagement._4.Helpers;
using Microsoft.EntityFrameworkCore.Internal;
using System.Security.Cryptography.X509Certificates;

namespace BookManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static BookManagementDbContext BookManagementDb;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            AppPaths.EnsureDataFolder();
            BookManagementDbContextFactory bookManagementDbContextFactory = new BookManagementDbContextFactory();
            BookManagementDb = bookManagementDbContextFactory.CreateDbContext(null);
            Application.Run(new MainForm());

        }
    }
}