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
    public class BLL_QuanLyDocGia
    {
        DAL_QuanLyPerson dal_QuanLyPerson = new DAL_QuanLyPerson();
        public DataTable ViewDocGia()
        {
            return dal_QuanLyPerson.ViewPerson("proc_viewdocgia");
        }
        public DataTable SearchDocGia(string strSearch)
        {
            int number;

            if (int.TryParse(strSearch, out number))
            {
                return dal_QuanLyPerson.searchPersonToMa("proc_searchdocgiabyma", number);
            }
            else
            {
                return dal_QuanLyPerson.searchPersonToName("proc_searchdocgiabyname", strSearch);
            }
        }
        public string EditDocGia(DTO_Person ps)
        {
            return dal_QuanLyPerson.EditPerson(ps, "proc_editdocgia");
        } 

        public string DelDocGia(string ma)
        {
            int code = int.Parse(ma);
            return dal_QuanLyPerson.DelPerson(code, "proc_deldocgia");
        }
        public DataTable GetDgFromUsername(string username)
        {
            return dal_QuanLyPerson.GetDGFromUsername(username);
        }
        public string UpdateDocGia(DTO_Person person, string usernameCu)
        {
            // kiem tra gia tri dau vao truoc khi them 
            if (string.IsNullOrEmpty(person.sHoTen) || string.IsNullOrEmpty(person.sDiaChi) || string.IsNullOrEmpty(person.sSDT)
                || string.IsNullOrEmpty(person.sUsername) || string.IsNullOrEmpty(person.sPassword))
            {
                return "Vui lòng nhập đầy đủ thông tin!";
            }
            else
            {
                return dal_QuanLyPerson.UpdateDocGia(person, usernameCu);
            }
        }
        public string DoiMatKhau(DTO_Person person)
        {
            // kiem tra gia tri dau vao truoc khi them 
            if (string.IsNullOrEmpty(person.sPassword))
            {
                return "Vui lòng nhập đầy đủ thông tin!";
            }
            else
            {
                return dal_QuanLyPerson.doimatkhau(person);
            }
        }
    }
}
