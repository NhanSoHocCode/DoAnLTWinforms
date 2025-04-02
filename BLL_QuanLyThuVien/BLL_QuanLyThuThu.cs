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
            return dal_quanlythuthu.AddThuThu(ps);
        }

    }
}
