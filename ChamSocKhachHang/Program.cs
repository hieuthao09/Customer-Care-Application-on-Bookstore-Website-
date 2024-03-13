using ChamSocKhachHang.BLL;
using ChamSocKhachHang.DAL;
using ChamSocKhachHang.gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamSocKhachHang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static Dashboard db;
        public static Login lg;
        [STAThread]
        static void Main()
        {

            //KhachHangBLL t = new KhachHangBLL();
            //foreach (var e in t.getListKhachHang())
            //{
            //    Console.WriteLine(e);
            //}


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            lg = new Login();
            Application.Run(lg);
        }
    }
}
