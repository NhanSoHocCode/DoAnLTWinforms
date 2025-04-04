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
            using (SqlConnection conn = SqlConnectionData.Connect()) 
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("proc_getImage", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user", username);

                    object result = cmd.ExecuteScalar();

                    return result != null && result != DBNull.Value ? result.ToString() : "";
                }
            }
        }
    }
}
