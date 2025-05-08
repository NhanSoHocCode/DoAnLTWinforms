using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyThuVien;

namespace DAL_QuanLyThuVien
{
    public class DAL_QuanLyPhieuMuon : DBConnect
    {
        public DataTable XemChiTietPM()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_viewphieumuon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public string ThemPhieuMuon(DTO_PhieuMuon pm)  // THEM THONG TIN PHIEU MUON 
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_insertphieumuon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maphieumuon", pm.sMaPhieuMuon);
                cmd.Parameters.AddWithValue("@madocgia", pm.sMaDocGia);
                cmd.Parameters.AddWithValue("@trangthai", pm.sTrangThai);
                cmd.Parameters.AddWithValue("@ngaymuon", pm.sNgayMuon);
                cmd.Parameters.AddWithValue("@ngaytra", pm.sNgayTra);
                cmd.Parameters.AddWithValue("@mathuthu", pm.sMaThuThu);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Thêm thành công";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ThemsachVaoPhieuMuon(DTO_Sach book, int maPhieuMuon) // THEM TUNG QUYEN SACH 1 VAO PHIEU MUON 
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_insertchitietphieumuon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masach", book.sMaSach);
                cmd.Parameters.AddWithValue("@maphieumuon", maPhieuMuon);
                cmd.Parameters.AddWithValue("@soluong", book.sSoLuong);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Them sach vao phieu muon thanh cong";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable TimKiemPhieuMuon(DTO_PhieuMuon pm) // TIM KIEM PHIEU MUON THEO MA PHIEU MUON
        {
            DataTable dt = new DataTable();
            if (pm.sMaPhieuMuon != 0)
            {
                String strSql = "proc_searchphieumuonbymaphieumuon";
                SqlConnection conn = SqlConnectionData.Connect();
                conn.Open();  
                try
                {
                    SqlCommand cmd = new SqlCommand(strSql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maphieumuon", pm.sMaPhieuMuon);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            if (pm.sTenDocGia != null)
            {
                String strSql = "proc_searchphieumuonbymadocgia";
                SqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(strSql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tendocgia", pm.sTenDocGia);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return dt;
        }
        public string XoaPhieuMuon(int maPhieuMuon) // XOA PHIEU MUON THEO MA PHIEU MUON
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_deletephieumuon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maphieumuon", maPhieuMuon);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Xoa phieu muon thanh cong";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DTO_PhieuMuon viewphieumuontheoma(int maPhieuMuon)  // hien thi thong tin phieu muon theo ma roi chinh sua (ra text box) 
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_viewphieumuontheoma", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);
                DTO_PhieuMuon dTO_PhieuMuon = new DTO_PhieuMuon();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dTO_PhieuMuon.sMaPhieuMuon = dr.GetInt32(0);
                    dTO_PhieuMuon.sMaDocGia = dr.GetInt32(1);
                    dTO_PhieuMuon.sTenDocGia = dr.GetString(2);
                    dTO_PhieuMuon.sTrangThai = dr.GetString(3);
                    dTO_PhieuMuon.sNgayMuon = dr.GetDateTime(4);
                    dTO_PhieuMuon.sNgayTra = dr.GetDateTime(5);
                    dTO_PhieuMuon.sMaThuThu = dr.GetInt32(6);
                    dTO_PhieuMuon.sTenThuThu = dr.GetString(7);
                }
                return dTO_PhieuMuon;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ViewListPM()
        {
            return Select(CommandType.StoredProcedure, "proc_viewphieumuon");
        }
        public string ChinhSuaPhieuMuon(DTO_PhieuMuon pm) // CHINH SUA THONG TIN PHIEU MUON
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_updatephieumuon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maphieumuon", pm.sMaPhieuMuon);
                cmd.Parameters.AddWithValue("@trangthai", pm.sTrangThai);
                cmd.Parameters.AddWithValue("@ngaymuon", pm.sNgayMuon);
                cmd.Parameters.AddWithValue("@ngaytra", pm.sNgayTra);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Chinh sua thanh cong";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ChinhSuaSoLuongSachMuon(int maphieumuon, int soluongsach)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_updatesoluongsachmuon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maphieumuon", maphieumuon);
                cmd.Parameters.AddWithValue("@soluongsach", soluongsach);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Chinh sua so luong sach muon thanh cong";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ListCanhCaoQuaHan()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_listCanhCaoQuaHan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable XemChiTietPhieuMuon(int maPM)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_xemchitietphieu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maphieumuon", maPM);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int CreatePM(DTO_PhieuMuon pm)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_CreatePMtoDocGia", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maDocGia", pm.sMaDocGia);
                cmd.Parameters.AddWithValue("@ngayTra", pm.sNgayTra);
                SqlParameter outputId = new SqlParameter("@maPhieuMuon", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputId);
                cmd.ExecuteNonQuery();
                int maPhieuMuonMoi = (int)outputId.Value;
                conn.Close();
                return maPhieuMuonMoi;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string DelBookToCartOnDocGia(int maDocGia)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_DelBookCartOnDocGia", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maDocGia", maDocGia);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Xoas thành công";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ThemSachVaoPhieuMuonV3(int maPM, int maDG)  // THEM THONG TIN PHIEU MUON 
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_ThemSachVaoPhieuMuonV3", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maPM", maPM);
                cmd.Parameters.AddWithValue("@maDG", maDG);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Thêm thành công";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
