using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyThuVien;
using System.Data;
using DTO_QuanLyThuVien;

namespace BLL_QuanLyThuVien
{
    public class BLL_QuanLySach
    {
        DAL_QuanLySach dal_QuanLySach = new DAL_QuanLySach();
        public DataTable XemDanhSachToanBoSach()
        {
            return dal_QuanLySach.XemDanhSachToanBoSach();
        }
        public String ThemSachMoi(DTO_Sach book) // tra ve thong bao khi them sach
        {
            return dal_QuanLySach.ThemSach(book);
        }
        public DataTable TimKiemSach(DTO_Sach book)   // tim kiem theo 3 chuc nang : tim theo ma sach, ten sach, tac gia , fill ra data grid view
        {
            return dal_QuanLySach.TimKiemSach(book);
        }

    }
}
