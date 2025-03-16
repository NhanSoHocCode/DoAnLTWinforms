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
        
    }
}
