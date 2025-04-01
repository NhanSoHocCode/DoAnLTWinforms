using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyThuVien;
using DAL_QuanLyThuVien;
using System.Net.Mail;
using System.Net;

namespace BLL_QuanLyThuVien
{
    public class BLL_TaiKhoan
    {
        DAL_TaiKhoanAccess dal_taikhoan = new DAL_TaiKhoanAccess();
        public string ChangePassByOTP(string tk, int OTP)
        {
            if (tk == null)
            {
                return "Vui long nhap email!";
            }
            else
            {
                return dal_taikhoan.DoiMatKhauBangOTP(tk, OTP);
            }
        }
        public string CheckeLogin(DTO_TaiKhoan taikhoan)
        {
            if (taikhoan.sTenTK == "" || taikhoan.sTenTK == "Username")
            {
                return "nonename";
            } else if (taikhoan.sMatKhau == "" || taikhoan.sMatKhau == "Password" )
            {
                return "nonepass";
            } else
            {
                string info = dal_taikhoan.CheckeLogin(taikhoan);
                return info;
            }
        }
        public Boolean MailHopLe(string email)
        {
            return dal_taikhoan.MailHopLe(email);
        }
        public string LayQuyenUser(string username)
        {
            return dal_taikhoan.LayQuyenUser(username);
        }
        public string LuuThoiGianLogin(string username, DateTime time)
        {
            return dal_taikhoan.LuuThoiGianDangNhap(username, time);
        }
    }
}
