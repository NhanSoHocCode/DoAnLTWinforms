using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyThuVien;
using DAL_QuanLyThuVien;

namespace BLL_QuanLyThuVien
{
    public class BLL_TaiKhoan
    {
        DAL_TaiKhoanAccess dal_taikhoan = new DAL_TaiKhoanAccess();
        public string CheckeLogin(DTO_TaiKhoan taikhoan)
        {
            if (taikhoan.sTenTK == "")
            {
                return "Vui long nhap ten tai khoan!";
            }
            if (taikhoan.sMatKhau == "")
            {
                return "Vui long nhap mat khau!";
            }
            string info = dal_taikhoan.CheckeLogin(taikhoan);
            return info;
        }
    }
}
