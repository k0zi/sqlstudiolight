using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using DatabaseLib;

namespace DatabaseTest
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    SQLConnection conn = new SQLConnection();
        //    SQLProgram prog = new SQLProgram();
        //    prog.Run();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login l = new Login();
            l.ShowDialog();
            Credentials c = l.LoginCredentials;
            Application.Run(new ManagementStudioVeryLight(c));
        }
    }
}
