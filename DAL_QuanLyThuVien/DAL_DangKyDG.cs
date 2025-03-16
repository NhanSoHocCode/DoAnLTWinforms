using DTO_QuanLyThuVien;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyThuVien
{
    public class DAL_DangKyDG
    {
        public string ThemTKDocGia(DTO_Person dtoPerson)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("proc_addTKnew", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@email", dtoPerson.sEmail);
                command.Parameters.AddWithValue("@username", dtoPerson.sUsername);
                command.Parameters.AddWithValue("@password", dtoPerson.sPassword);
                command.ExecuteNonQuery();
                SqlCommand command1 = new SqlCommand("proc_addDocGia", conn);
                command1.CommandType = CommandType.StoredProcedure;
                command1.Parameters.AddWithValue("@hoten", dtoPerson.sHoTen);
                command1.Parameters.AddWithValue("@ngaysinh", dtoPerson.sNgaySinh);
                command1.Parameters.AddWithValue("@email", dtoPerson.sEmail);
                command1.Parameters.AddWithValue("@diachi", dtoPerson.sDiaChi);
                command1.Parameters.AddWithValue("@set", dtoPerson.sGioiTinh);
                command1.Parameters.AddWithValue("@sdt", dtoPerson.sSDT);
                command1.Parameters.AddWithValue("@username", dtoPerson.sUsername);
                command1.ExecuteNonQuery();
                conn.Close();
                return "Tài khoản đã được thêm thành công!";
            }
            catch (Exception ex)
            {
                return "Lỗi kết nối: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
