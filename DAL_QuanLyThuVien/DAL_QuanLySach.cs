using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyThuVien;
using static Guna.UI2.Native.WinApi;

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
        public DataTable TimKiemSach(DTO_Sach book)   // co tim kiem ten sach gan dung , ex: nhap ten sach la "Yeu" thi ket qua la "Tinh Yeu"
        {
            if (book.sMaSach != null)
            {
                String strSql = "proc_searchbookbymasach";
                SqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(strSql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@masach", book.sMaSach);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable(); 
                    da.Fill(dt);
                    conn.Close();  // nho dong ket noi
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            if (book.sTenSach != null)
            {
                String strSql = "proc_searchbookbytensachGanDung";
                SqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(strSql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tensach", book.sTenSach);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conn.Close();  // nho dong ket noi
                    return dt;   // theo thu tu truong trong database 
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                return null;
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

    }
}
