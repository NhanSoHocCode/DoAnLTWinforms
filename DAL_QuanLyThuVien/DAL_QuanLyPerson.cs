using System;
using System.Collections.Generic;
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
        //// tim kiem theo ten gan dung // vi du nhap ten Nhan thi ket qua la Dang Ngoc Nhan
        //public DTO_Person TimKiemTheoTen(string strSql, string tenTT)   //proc_searchthuthutotenthuthu, proc_searchdocgiatotendocgia
        //{
        //    DTO_Person ps = new DTO_Person();
        //    SqlConnection conn = SqlConnectionData.Connect();
        //    conn.Open();
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand(strSql, conn);
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@tenthuthu", tenTT);
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            ps.sMa = dr["mathuthu"].ToString();
        //            ps.sHoTen = dr["tenthuthu"].ToString();
        //            ps.sNgaySinh = Convert.ToDateTime(dr["ngaysinh"]);
        //            ps.sGioiTinh = Convert.ToBoolean(dr["gioitinh"]);
        //            ps.sDiaChi = dr["diachi"].ToString();
        //            ps.sSDT = dr["sdt"].ToString();
        //            ps.sEmail = dr["email"].ToString();
        //            ps.sChucVu = dr["chucvu"].ToString();
        //            ps.sPassword = dr["matkhau"].ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return ps;
        //}


    }
}
