using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace wryt
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

            var mui = new MainUI(3);
            Application.Run(mui);
        }
    }
}
