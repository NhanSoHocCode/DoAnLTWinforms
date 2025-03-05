using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyThuVien;

namespace DAL_QuanLyThuVien
{
    public class DAL_TaiKhoanAccess : DBConnect
    {
        public string CheckeLogin(DTO_TaiKhoan taikhoan)
        {
            string info = DBConnect.CheckLogin(taikhoan);
            return info;
        }

    }
}
