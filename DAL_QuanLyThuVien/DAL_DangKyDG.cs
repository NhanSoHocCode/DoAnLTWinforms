using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyThuVien
{
    public class DAL_DangKyDG : DBConnect
    {
        public string ThemTKDG(DTO_QuanLyThuVien.DTO_Person person)
        {
            string info = DBConnect.ThemTKDocGia(person);
            return info;
        }
    }
}
