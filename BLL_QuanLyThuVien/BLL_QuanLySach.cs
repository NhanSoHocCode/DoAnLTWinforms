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
        public DataTable TimKiemSach(string search)
        {
            DTO_Sach dieuKienTimKiem = new DTO_Sach();
            search = search.Trim();
            if (string.IsNullOrEmpty(search))
            {
                return new DataTable(); 
            }
            if (int.TryParse(search, out int ma))
            {
                dieuKienTimKiem.sMaSach = ma;
            }
            else 
            {
                dieuKienTimKiem.sMaSach = -1;
                dieuKienTimKiem.sTenSach = search;
            }
            return dal_QuanLySach.TimKiemSach(dieuKienTimKiem);
        }

        public string XoaSach(string ma) 
        {
            return dal_QuanLySach.XoaSach(int.Parse(ma));
        }
        public string SuaSach(DTO_Sach book)
        {
            return dal_QuanLySach.SuaSach(book);
        }
        public DataTable ListMaThuThu()
        {
            return dal_QuanLySach.ListMaThuThu();
        }
        public DataTable ListBookToCart(int maDocGia)
        {
            return dal_QuanLySach.ListBookToCart(maDocGia);
        }
        public string InsertBookToCart(DTO_Sach book, int maDocGia)
        {
            return dal_QuanLySach.InsertBookToCart(book, maDocGia);
        }
        public string DelBookToCart(int maSach, int maDocGia)
        {
            return dal_QuanLySach.DelBookToCart(maSach, maDocGia);
        }
        public DataTable GetTheLoaiSach()
        {
            return dal_QuanLySach.GetTheLoaiSach();
        }
    }
}
