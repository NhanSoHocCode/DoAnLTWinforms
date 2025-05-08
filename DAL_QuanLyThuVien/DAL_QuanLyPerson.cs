using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyThuVien;
using Sunny.UI.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
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
        public DataTable searchPersonToMa(string strSql, int ma)  //proc_searchdocgiabyma,proc_searchthuthubyma
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
        public DataTable searchPersonToName(string strSql, string name)  //proc_searchdocgiabyname, proc_searchthuthubyname
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

        public string AddThuThu(DTO_Person dtoPerson)  // them thu thu chua them tai khoan 
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("proc_addThuThu", conn);
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
                conn.Close();
                return "Thủ thư đã được thêm thành công!";
            }
            catch (Exception ex)
            {
                return "Lỗi kết nối: " + ex.Message;
            }
        }
        public DataTable GetDGFromUsername(string username)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_getDocGiaFrom", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string UpdateDocGia(DTO_Person person, string usernameCu)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_updateDocGia", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maDocGia", int.Parse(person.sMa));
                cmd.Parameters.AddWithValue("@hoTen", person.sHoTen);
                cmd.Parameters.AddWithValue("@ngaySinh", person.sNgaySinh);
                cmd.Parameters.AddWithValue("@soDienThoai", person.sSDT);
                cmd.Parameters.AddWithValue("@diaChi", person.sDiaChi);
                cmd.Parameters.AddWithValue("@usernameMoi", person.sUsername);
                cmd.Parameters.AddWithValue("@password", person.sPassword);
                cmd.Parameters.AddWithValue("@anhThe", person.sSourceImage);
                cmd.Parameters.AddWithValue("@gioiTinh", person.sGioiTinh);
                cmd.Parameters.AddWithValue("@usernameCu", usernameCu);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Update thanh cong!";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string UpdateThuThu(DTO_Person person, string usernameCu)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_updateThuThu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maThuThu", int.Parse(person.sMa));
                cmd.Parameters.AddWithValue("@hoTen", person.sHoTen);
                cmd.Parameters.AddWithValue("@ngaySinh", person.sNgaySinh);
                cmd.Parameters.AddWithValue("@soDienThoai", person.sSDT);
                cmd.Parameters.AddWithValue("@diaChi", person.sDiaChi);
                cmd.Parameters.AddWithValue("@usernameMoi", person.sUsername);
                cmd.Parameters.AddWithValue("@password", person.sPassword);
                cmd.Parameters.AddWithValue("@anhThe", person.sSourceImage);
                cmd.Parameters.AddWithValue("@gioiTinh", person.sGioiTinh);
                cmd.Parameters.AddWithValue("@usernameCu", usernameCu);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Update thanh cong!";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string doimatkhau(DTO_Person person)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_doimatkhauDG", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", person.sEmail);
                cmd.Parameters.AddWithValue("@password", person.sPassword);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Đổi mật khẩu thành công!";
            }
            catch (Exception ex)
            {
                return "Lỗi kết nối: " + ex.Message;
            }
        }
        public DataTable ListMaDocGia()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_listMaDG", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
