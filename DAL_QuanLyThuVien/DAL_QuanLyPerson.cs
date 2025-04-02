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
        public DataTable ViewPerson(string Sqlstr)    // proc_viewthuthu, proc_viewdocgia
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(Sqlstr, conn);
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
                        cmd.Parameters.AddWithValue("@ma", int.Parse(ps.sMa));
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

        public string AddThuThu(DTO_Person dtoPerson)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlTransaction transaction = conn.BeginTransaction(); // Bắt đầu transaction

            try
            {
                // Thêm tài khoản
                SqlCommand command = new SqlCommand("proc_addTKnew", conn, transaction);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@email", dtoPerson.sEmail);
                command.Parameters.AddWithValue("@username", dtoPerson.sUsername);
                command.Parameters.AddWithValue("@password", dtoPerson.sPassword);
                command.ExecuteNonQuery();

                // Thêm thủ thư
                SqlCommand command1 = new SqlCommand("proc_addThuThu", conn, transaction);
                command1.CommandType = CommandType.StoredProcedure;
                command1.Parameters.AddWithValue("@hoten", dtoPerson.sHoTen);
                command1.Parameters.AddWithValue("@ngaysinh", dtoPerson.sNgaySinh);
                command1.Parameters.AddWithValue("@email", dtoPerson.sEmail);
                command1.Parameters.AddWithValue("@diachi", dtoPerson.sDiaChi);
                command1.Parameters.AddWithValue("@set", dtoPerson.sGioiTinh);
                command1.Parameters.AddWithValue("@sdt", dtoPerson.sSDT);
                command1.Parameters.AddWithValue("@username", dtoPerson.sUsername);
                command1.Parameters.AddWithValue("@anhthe", dtoPerson.sSourceImage);
                command1.ExecuteNonQuery();

                transaction.Commit(); // Xác nhận lưu dữ liệu
                conn.Close();
                return "Thủ thư đã được thêm thành công!";
            }
            catch (Exception ex)
            {
                transaction.Rollback(); // Hoàn tác nếu có lỗi
                return "Lỗi kết nối: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
