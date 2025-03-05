using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyThuVien
{
    public class DAL_QuanLySach : DBConnect
    {
        public DataTable XemDanhSachToanBoSach()
        {
            string strSql = "proc_viewbooklist";
            DataTable dt = DBConnect.Select(CommandType.StoredProcedure, strSql);
            return dt;
        }
    }
}
