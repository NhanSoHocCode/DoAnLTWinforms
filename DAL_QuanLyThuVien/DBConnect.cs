using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_QuanLyThuVien;

namespace DAL_QuanLyThuVien
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strCon = @"Data Source=DANGNGOCNHAN;Initial Catalog=QuanLyThuVIenNew;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(strCon);
            return conn;
        }

    }
    public class DBConnect
    {
        public static string CheckLogin(DTO_TaiKhoan taikhoan)
        {
            string user = null;
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_login", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taikhoan.sTenTK);
            command.Parameters.AddWithValue("@pass", taikhoan.sMatKhau);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) 
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                conn.Close();
            } else
            {
                return "Tai khoan hoac mat khau khong dung!";
            }
            return user;
        }
        public static string ThemTKDocGia(DTO_Person dtoPerson)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("proc_addUser", conn);
                command.CommandType = CommandType.StoredProcedure;

           
                command.Parameters.AddWithValue("@hoTen", dtoPerson.sHoTen);
                command.Parameters.AddWithValue("@ngaySinh", dtoPerson.sNgaySinh);
                command.Parameters.AddWithValue("@diaChi", dtoPerson.sDiaChi);
                command.Parameters.AddWithValue("@gioiTinh", dtoPerson.sGioiTinh);
                command.Parameters.AddWithValue("@soDT", dtoPerson.sSDT);
                command.Parameters.AddWithValue("@email", dtoPerson.sEmail);
                command.Parameters.AddWithValue("@username", dtoPerson.sUsername);

                command.Parameters.AddWithValue("@password", dtoPerson.sPassword);
                command.ExecuteNonQuery();
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

        public static DataTable Select(CommandType cmdType, String strSql)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.CommandType = cmdType;
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
        public string DoiMatKhau(string username, string passwordNew)
        {
            SqlConnection conn = new SqlConnection();
            conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_doimatkhau", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", passwordNew);
                cmd.ExecuteNonQuery();
                return "Đổi mật khẩu thành công!";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
