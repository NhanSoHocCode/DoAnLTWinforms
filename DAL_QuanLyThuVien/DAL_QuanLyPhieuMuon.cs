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
            if (pm.sMaDocGia != 0)
            {
                String strSql = "proc_searchphieumuonbymadocgia";
                SqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(strSql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@madocgia", pm.sMaDocGia);
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
            return null;
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




    }
}
