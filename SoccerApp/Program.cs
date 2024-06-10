using SoccerApp;
using System;
using System.Windows.Forms;

namespace SoccerApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());
            using (var appContext = new AppDbContext())
            {

            }
        }

    }

}
