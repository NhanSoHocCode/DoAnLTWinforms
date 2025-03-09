using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyThuVien;
using DTO_QuanLyThuVien;
namespace BLL_QuanLyThuVien
{
    public class BLL_QuanLyPhieuMuon
    {
        BLL_QuanLyPhieuMuon bllPhieuMuon = new BLL_QuanLyPhieuMuon();
        public string XemChiTiet()
        {
            return bllPhieuMuon.XemChiTiet();
        }
        public string ThemPhieuMuon(DTO_PhieuMuon phieumuon)
        {
            return bllPhieuMuon.ThemPhieuMuon(phieumuon);
        }
        public string ThemSachVaoPhieuMuon(DTO_Sach book, string maPhieuMuon)
        {
            return bllPhieuMuon.ThemSachVaoPhieuMuon(book, maPhieuMuon);
        }
        public string TimKiemPhieuMuon(DTO_PhieuMuon pm)
        {
            return bllPhieuMuon.TimKiemPhieuMuon(pm);
        }
        public string XoaPhieuMuon(int MaPhieuMuon)
        {
            return bllPhieuMuon.XoaPhieuMuon(MaPhieuMuon);
        }
        public string ChinhSuaPhieuMuon(DTO_PhieuMuon pm)
        {
            return bllPhieuMuon.ChinhSuaPhieuMuon(pm);
        }
    }
}
