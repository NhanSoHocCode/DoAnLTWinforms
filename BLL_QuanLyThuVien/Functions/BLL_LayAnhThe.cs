using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyThuVien;
namespace BLL_QuanLyThuVien.Functions
{
    public class BLL_LayAnhThe
    {
        DAL_XuLyHinhAnh dal_xulyhinhanh = new DAL_XuLyHinhAnh();
        public string LayAnhThe(string username)
        {
            string a = dal_xulyhinhanh.GetImage(username);
            return "D:\\K25_Project_LTWinform\\DoAn\\images\\" + a;
        }
    }
}
