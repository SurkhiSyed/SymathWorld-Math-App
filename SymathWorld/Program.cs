using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymathWorld
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
            Application.Run(new MainScreen());
            Application.Run(new SignInScreen());
            Application.Run(new GateWay());
            Application.Run(new MainMenu());
            Application.Run(new Unit1Screen());
            Application.Run(new Unit1Lesson1());

        }
    }
}
