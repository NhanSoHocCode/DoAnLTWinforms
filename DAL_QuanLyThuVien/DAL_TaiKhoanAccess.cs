using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyThuVien;

namespace DAL_QuanLyThuVien
{
    public class DAL_TaiKhoanAccess : DBConnect
    {
        public string CheckeLogin(DTO_TaiKhoan taikhoan)
        {
            string info = DBConnect.CheckLogin(taikhoan);
            return info;
        }
        public string DoiMatKhauBangOTP(string taikhoan, int OTP)
        {
            string info = "";
            string strSql = "proc_changepassbyOTP";
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                if (taikhoan == null)
                {
                    return "Tài khoản không tồn tại!";
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(strSql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", taikhoan);
                    cmd.Parameters.AddWithValue("@newpass", OTP);
                    cmd.ExecuteNonQuery();
                    info = "Đổi mật khẩu thành công!";
                    conn.Close();
                    return info;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DTO_TaiKhoan GetMail(string username)
        {
            string strSql = "proc_getemailtouser";
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", username);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                DTO_TaiKhoan tk = new DTO_TaiKhoan();
                tk.email = reader.GetString(0);
                tk.sMatKhau = reader.GetString(1);
                conn.Close();
                return tk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean MailHopLe(string email)
        {
            string strSql = "proc_mailhople";
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", email);
                SqlParameter outputParam = new SqlParameter("@result", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);
                cmd.ExecuteNonQuery(); // Thực thi Stored Procedure
                conn.Close();
                return Convert.ToBoolean(outputParam.Value);    // tra ve gia tri true false truc tiep 
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
        public string LayQuyenUser(string user)
        {
            string strSql = "proc_GetRoleUser";
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", user);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string role = reader["role"].ToString();
                conn.Close();
                return role;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
