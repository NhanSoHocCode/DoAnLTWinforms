using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLyThuVien;
namespace GUI_QuanLyThuVien.Administration.QLDocGia
{
    public partial class GUI_ControlChiTietDocGia : Form
    {
        public GUI_ControlChiTietDocGia()
        {
            InitializeComponent();
        }
        public DTO_Person person;

        private void GUI_ControlChiTietDocGia_Load(object sender, EventArgs e)
        {
            txtAddress.Text = person.sDiaChi;
            txtEmail.Text = person.sEmail;
            txtUsername.Text = person.sUsername;
            txtSdt.Text = person.sSDT;
            lbHocten.Text = person.sHoTen;
            lbMa.Text = person.sMa;
            lbNgaySinh.Text = person.sNgaySinh.ToString();
            lbSet.Text = person.sGioiTinh == true ? "Nam" : "Nữ";
        }
    }
}
