using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyThuVien;
using DTO_QuanLyThuVien;
namespace BLL_QuanLyThuVien
{
    public class BLL_QuanLyPhieuMuon
    {
        DAL_QuanLyPhieuMuon dllPhieuMuon = new DAL_QuanLyPhieuMuon();
        public string ThemPhieuMuon(DTO_PhieuMuon phieumuon)
        {
            return dllPhieuMuon.ThemPhieuMuon(phieumuon);
        }
        public string ThemSachVaoPhieuMuon(DTO_Sach book, int maPhieuMuon)
        {
            return dllPhieuMuon.ThemsachVaoPhieuMuon( book, maPhieuMuon);
        }
        public DataTable TimKiemPhieuMuon(DTO_PhieuMuon pm)
        {
            return dllPhieuMuon.TimKiemPhieuMuon(pm);
        }
        public string XoaPhieuMuon(int MaPhieuMuon)
        {
            return dllPhieuMuon.XoaPhieuMuon(MaPhieuMuon);
        }
        public string ChinhSuaPhieuMuon(DTO_PhieuMuon pm)
        {
            return dllPhieuMuon.ChinhSuaPhieuMuon(pm);
        }
        public DataTable viewListPM()
        {
            return dllPhieuMuon.ViewListPM();
        }
        public DataTable ListCanhCaoQuaHan()
        {
            return dllPhieuMuon.ListCanhCaoQuaHan();
        }
        public DataTable XemChiTietPhieuMuon(int maPM)
        {
            return dllPhieuMuon.XemChiTietPhieuMuon((int)maPM);
        }
        public int CreatePMtoDocGia(DTO_PhieuMuon pm)
        {
            return dllPhieuMuon.CreatePM(pm);  // them sach nua 
        }
        public string DelBookToCartOnDocGia(int maDocGia)
        {
            return dllPhieuMuon.DelBookToCartOnDocGia(maDocGia);
        }
        public string ThemSachVaoPhieuMuonV3(int maDG, int maPM)
        {
            return dllPhieuMuon.ThemSachVaoPhieuMuonV3(maPM, maDG);
        }
    }
}
