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
    public class DAL_XuLyHinhAnh
    {
        public string GetImage(string username)
        {
            string strSql = "proc_getImage";
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", username);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string image = reader["anhthe"].ToString();
                conn.Close();
                return image;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
