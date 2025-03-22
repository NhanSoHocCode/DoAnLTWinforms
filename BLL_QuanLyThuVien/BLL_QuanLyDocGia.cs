using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyThuVien;
namespace BLL_QuanLyThuVien
{
    public class BLL_QuanLyDocGia
    {
        DAL_QuanLyPerson dal_QuanLyPerson = new DAL_QuanLyPerson();
        public DataTable ViewDocGia()
        {
            return dal_QuanLyPerson.ViewPerson("proc_viewdocgia");
        }
        
    }
}
