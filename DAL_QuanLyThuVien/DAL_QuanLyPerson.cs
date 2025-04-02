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
    public class DAL_QuanLyPerson : DBConnect
    {
        public DTO_Person  TimKiemTheoMa(string strSql,string ma)     // proc_searchthuthutoma, proc_searchdocgiatoma
        {
            DTO_Person ps = new DTO_Person();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ma", ma);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ps.sMa = dr[0].ToString();
                    ps.sHoTen = dr[1].ToString();
                    ps.sNgaySinh = Convert.ToDateTime(dr[2]);
                    ps.sGioiTinh = Convert.ToBoolean(dr[3]);
                    ps.sDiaChi = dr[4].ToString();
                    ps.sSDT = dr[5].ToString();
                    ps.sEmail = dr[6].ToString();
                    ps.sChucVu = dr[7].ToString();
                    ps.sPassword = dr[8].ToString();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return ps;
        }
        public DataTable ViewPerson(string Sqlstr)    // proc_viewthuthu, proc_viewdocgia
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand( Sqlstr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public string EditPerson(DTO_Person ps, string strSql)  // proc_editthuthu, proc_editdocgia
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(strSql, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ma",int.Parse(ps.sMa));
                        cmd.Parameters.AddWithValue("@anhthe", ps.sSourceImage);
                        cmd.Parameters.AddWithValue("@diachi", ps.sDiaChi);
                        cmd.Parameters.AddWithValue("@sdt", ps.sSDT);
                        cmd.Parameters.AddWithValue("@email", ps.sEmail);
                        cmd.Parameters.AddWithValue("@username", ps.sUsername);
                        cmd.ExecuteNonQuery();
                        return "Sửa thành công!";
                    }
                }
                catch (Exception ex)
                {
                    return "Lỗi kết nối: " + ex.Message;
                }
            }
        }
        public string DelPerson(int ma, string strSql)  // proc_delthuthu, proc_deldocgia
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ma", ma);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Xoa thanh cong!";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable searchPersonToMa(string strSql, int ma)  //proc_searchdocgiabyma,
        {
            DataTable dt = new DataTable();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ma", ma);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable searchPersonToName(string strSql, string name)  //proc_searchdocgiabyname,
        {
            DataTable dt = new DataTable();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // chua update phan AddPerson

        public string AddThuThu(DTO_Person dtoPerson)  //proc_addThuThu
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
                SqlCommand command1 = new SqlCommand("proc_addThuThu", conn);
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
                return "Thu Thu đã được thêm thành công!";
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
