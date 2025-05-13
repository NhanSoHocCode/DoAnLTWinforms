using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyThuVien;
using DTO_QuanLyThuVien;
using Sunny.UI.Win32;

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
            if (person.sUsername == "" || person.sPassword == "" || person.sHoTen == "" || person.sSDT == "" 
                || person.sDiaChi == "")
            {
                return "Vui lòng nhập đầy đủ thông tin!"; 
            }
            return dal_quanlythuthu.EditPerson(person, "proc_editthuthu");
        }
        public string DelThuThu(string ma)
        {
            return dal_quanlythuthu.DelPerson(int.Parse(ma), "proc_delthuthu");
        }
        public string AddThuThu(DTO_Person person)
        {
            if (person.sUsername == "" || person.sPassword == "" || person.sHoTen == "" || person.sSDT == ""
                || person.sDiaChi == "")
            {
                return "Không được bỏ trống thông tin!";
            }
            DAL_TaiKhoanAccess tk = new DAL_TaiKhoanAccess();
            tk.ThemTaiKhoan(person);
            return dal_quanlythuthu.AddThuThu(person);
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
        public DataTable SearchThuThuToUsername(string username)
        {
            return dal_quanlythuthu.SearchThuThuToUsername(username);
        }


    }
}
