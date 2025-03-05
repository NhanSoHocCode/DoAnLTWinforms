using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyThuVien;
using System.Data;

namespace BLL_QuanLyThuVien
{
    public class BLL_QuanLySach
    {
        DAL_QuanLySach dal_QuanLySach = new DAL_QuanLySach();
        public DataTable XemDanhSachToanBoSach()
        {
            return dal_QuanLySach.XemDanhSachToanBoSach();
        }
    }
}
