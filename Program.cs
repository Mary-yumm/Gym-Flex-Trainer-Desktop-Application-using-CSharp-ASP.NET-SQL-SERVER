using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using DB_Project;
using DB_FormLab;



namespace FINAL_DB_PROJECT
{
    internal static class Program
    {
        private static AAPPMAINPAGE mainnPage;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OpenMainnPage();
            Application.Run(mainnPage);
        }

        private static void OpenMainnPage()
        {
            mainnPage = new AAPPMAINPAGE(() => Application.Exit());
        }

    }
}
