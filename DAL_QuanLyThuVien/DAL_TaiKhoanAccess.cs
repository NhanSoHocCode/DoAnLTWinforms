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
    }
}
