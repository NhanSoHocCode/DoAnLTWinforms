using GUI_QuanLyThuVien.Administration;
using GUI_QuanLyThuVien.Administration.QLThuThu;
using GUI_QuanLyThuVien.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using GUI_QuanLyThuVien.Administration.QLPhieuMuon;

namespace GUI_QuanLyThuVien
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
            //Application.Run(new GUI_QuanLyThuThu());
            //Application.Run(new GUI_DangKyDG());
           Application.Run(new GUI_DangNhap());
            //Application.Run(new GUI_HomeManager());
            //Application.Run(new GUI_AddPhieuMuon());
        }
    }
}
