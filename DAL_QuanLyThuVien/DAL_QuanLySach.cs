using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DTO_QuanLyThuVien;

namespace DAL_QuanLyThuVien
{
    public class DAL_QuanLySach : DBConnect
    {
        public DataTable XemDanhSachToanBoSach()
        {
            string strSql = "proc_viewbooklist";
            DataTable dt = DBConnect.Select(CommandType.StoredProcedure, strSql);
            return dt;
        }
        public String ThemSach( DTO_Sach book)
        {
            string strSql = "proc_insertbook";
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tacgia", book.sTacGia);
                cmd.Parameters.AddWithValue("@dongia", book.sDonGia);
                cmd.Parameters.AddWithValue("@soluong", book.sSoLuong);
                cmd.Parameters.AddWithValue("@theloai", book.sTheLoai);
                cmd.Parameters.AddWithValue("@tensach", book.sTenSach);
                cmd.Parameters.AddWithValue("@mathuthu", book.sMaThuThu);
                cmd.Parameters.AddWithValue("@source_image", book.sSourceImange);
                cmd.Parameters.AddWithValue("@nhaxb", book.sNhaXuatBan);
                cmd.ExecuteNonQuery();
                conn.Close();  // nho dong ket noi
                return "Thêm thành công";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable TimKiemSach(DTO_Sach book)
        {
            if (book.sMaSach != -1)
            {
                return ExecuteStoredProc("proc_searchbookbymasach", "@masach", book.sMaSach);
            }
            else if (!string.IsNullOrEmpty(book.sTenSach))
            {
                return ExecuteStoredProc("proc_searchbookbytensachGanDung", "@tensach", book.sTenSach);
            }
            else
            {
                return null;
            }
        }

        // Hàm phụ dùng chung để gọi stored procedure
        private DataTable ExecuteStoredProc(string procName, string paramName, object value)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(paramName, value);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public String XoaSach(int ma) // chi xoa theo ma sach 
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_deletebook", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masach", ma);
                cmd.ExecuteNonQuery();
                conn.Close();  // nho dong ket noi
                return "Xóa thành công";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String SuaSach(DTO_Sach book) // chi xoa theo ma sach 
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_updatebook", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masach", book.sMaSach);
                cmd.Parameters.AddWithValue("@tacgia", book.sTacGia);
                cmd.Parameters.AddWithValue("@dongia", book.sDonGia);
                cmd.Parameters.AddWithValue("@soluong", book.sSoLuong);
                cmd.Parameters.AddWithValue("@theloai", book.sTheLoai);
                cmd.Parameters.AddWithValue("@tensach", book.sTenSach);
                cmd.Parameters.AddWithValue("@mathuthu", book.sMaThuThu);
                cmd.Parameters.AddWithValue("@source_image", book.sSourceImange);
                cmd.Parameters.AddWithValue("@nhaxb", book.sNhaXuatBan);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Edit thành công";
            }
            //catch (FormatException ex)
            //{
            //    return $"Error: {ex.Message}";
            //}
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ListMaThuThu()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_listMaThuThu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                conn.Close();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ListBookToCart(int maDocGia)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_LoadCart", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maDocGia", maDocGia);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            //catch (FormatException ex)
            //{
            //    return $"Error: {ex.Message}";
            //}
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetTheLoaiSach()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_getTheLoaiSach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string InsertBookToCart(DTO_Sach book, int maDocGia)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_insertBookToCart", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maSach", book.sMaSach);
                cmd.Parameters.AddWithValue("@soLuong", book.sSoLuong);
                cmd.Parameters.AddWithValue("@maDocGia", maDocGia);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Insert thành công";
            }
            catch (FormatException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string DelBookToCart(int maSach, int maDocGia)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_delBookToCart", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maSach", maSach);
                cmd.Parameters.AddWithValue("@maDocGia", maDocGia);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Del thành công";
            }
            catch (FormatException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string giamSoLuongSach(DTO_Sach book)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_giamsoluongsach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maSach", book.sMaSach);
                cmd.Parameters.AddWithValue("@soLuong", book.sSoLuong);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Giảm thành công";
            }
            catch (FormatException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string tangSoLuongSach(DTO_Sach book)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_tangsoluongsach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maSach", book.sMaSach);
                cmd.Parameters.AddWithValue("@soLuong", book.sSoLuong);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Tăng thành công";
            }
            catch (FormatException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable DanhSachReport()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_viewbooklistReport", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
