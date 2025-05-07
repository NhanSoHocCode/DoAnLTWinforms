using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyThuVien;
using DTO_QuanLyThuVien;

namespace BLL_QuanLyThuVien
{ 
    public class BLL_QuanLyThuThu
    {
        DAL_QuanLyPerson dal_quanlythuthu = new DAL_QuanLyPerson();
        DAL_TaiKhoanAccess DAL_TaiKhoanAccess = new DAL_TaiKhoanAccess();

        public DataTable ListThuThu()
        {
            DataTable dataTable = new DataTable();
            dataTable = dal_quanlythuthu.ViewPerson("proc_viewthuthu");
            return dataTable;
        }
        public string EditThuThu(DTO_Person person)
        {
            return dal_quanlythuthu.EditPerson(person, "proc_editthuthu");
        }
        public string DelThuThu(string ma)
        {
            return dal_quanlythuthu.DelPerson(int.Parse(ma), "proc_editthuthu");
        }
        public string AddThuThu(DTO_Person ps)
        {
            DAL_TaiKhoanAccess dal_TaiKhoanAccess = new DAL_TaiKhoanAccess();
            if (string.IsNullOrEmpty(ps.sHoTen) || string.IsNullOrEmpty(ps.sDiaChi) || string.IsNullOrEmpty(ps.sSDT)
                || string.IsNullOrEmpty(ps.sUsername) || string.IsNullOrEmpty(ps.sPassword))
            {
                return "Vui lòng nhập đầy đủ thông tin!";
            }
            else
            {
                try
                {
                    dal_TaiKhoanAccess.ThemTaiKhoan(ps);
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            return dal_quanlythuthu.AddThuThu(ps);
        }
        public DataTable SearchThuThu(string search)
        {

            if ( int.TryParse(search, out int ma))
            {
                return dal_quanlythuthu.searchPersonToMa("proc_searchthuthubyma", ma);
            } else
            {
                return dal_quanlythuthu.searchPersonToName("proc_searchthuthubyname", search);
            }
        }
        public string UpdateThuThu(DTO_Person person, string usernameCu)
        {
            // kiem tra gia tri dau vao truoc khi them 
            if (string.IsNullOrEmpty(person.sHoTen) || string.IsNullOrEmpty(person.sDiaChi) || string.IsNullOrEmpty(person.sSDT)
                || string.IsNullOrEmpty(person.sUsername) || string.IsNullOrEmpty(person.sPassword))
            {
                return "Vui lòng nhập đầy đủ thông tin!";
            }
            else
            {
                return dal_quanlythuthu.UpdateThuThu(person, usernameCu);
            }
        }


    }
}
