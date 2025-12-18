using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAL01E_MORATA
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
            Application.Run(new Lesson3_Example2());

            // Lesson 14 - Activity 11: User Login Form with Database Connection
            // Lesson 14 - Activity 9: User Account Management System
            // Lesson 14 - Activity 4: Employee Registration Form
        }
    }
}
