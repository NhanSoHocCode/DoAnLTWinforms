using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyThuVien;
using DAL_QuanLyThuVien;

namespace BLL_QuanLyThuVien
{
    public class BLL_DangKyDG
    {
        DAL_DangKyDG dalDangKyDG = new DAL_DangKyDG();
        public string ThemTKDocGia(DTO_Person person)
        {
            if ( person.sMa == "")
            {
                return "Mã độc giả không được để trống";
            }
            if (person.sHoTen == "")
            {
                return "Họ tên độc giả không được để trống";
            }
            if (person.sNgaySinh == null)
            {
                return "Ngày sinh độc giả không được để trống";
            }
            if (person.sDiaChi == "")
            {
                return "Địa chỉ độc giả không được để trống";
            }
            if (person.sEmail == "")
            {
                return "Email độc giả không được để trống";
            }
            if (person.sSDT == "")
            {
                return "Số điện thoại độc giả không được để trống";
            }
            if (person.sUsername == "")
            {
                return "Username độc giả không được để trống";
            }
            if (person.sPassword == "")
            {
                return "Password độc giả không được để trống";
            }
            if (person.sChucVu == "")
            {
                return "Chức vụ độc giả không được để trống";
            }
            return dalDangKyDG.ThemTKDocGia(person);
        }
    }
}
