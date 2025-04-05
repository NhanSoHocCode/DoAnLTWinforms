using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyThuVien;
using System.Data;
using DTO_QuanLyThuVien;
using System.Diagnostics.Eventing.Reader;

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
        public DataTable TimKiemSach(string search)   // tim kiem theo 2 chuc nang : tim theo ma sach, ten sach
        {
            DTO_Sach book = new DTO_Sach();
            if (int.TryParse(search, out int ma))
            {
                book.sMaSach = search;
            } else
            {
                book.sTenSach = search;
            }
            return dal_QuanLySach.TimKiemSach(book);
        }
        public string XoaSach(DTO_Sach book) // tra ve thong{
        {
            return dal_QuanLySach.XoaSach(book);
        }
        public string SuaSach(DTO_Sach book)
        {
            return dal_QuanLySach.SuaSach(book);
        }
    }
}
