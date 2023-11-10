using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyNoiThat.View;

namespace DoAnQuanLyNoiThat
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseHelper.dbName = "QuanLyNoiThat2";
            DatabaseHelper.serverName = "MSI\\SQLEXPRESS01";
            DatabaseHelper.userDb = "sa";
            DatabaseHelper.password = "2606";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}
