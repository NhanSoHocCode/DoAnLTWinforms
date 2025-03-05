using BLL_QuanLyThuVien;
using DTO_QuanLyThuVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI_QuanLyThuVien
{
    public partial class GUI_DangKyDG : Form
    {
        BLL_DangKyDG bll_dangkydg = new BLL_DangKyDG();
        DTO_Person person = new DTO_Person();
        public GUI_DangKyDG()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            person.sHoTen = txtName.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            person.sNgaySinh = ngaySinh;
            person.sGioiTinh = cbGioiTinh.Text == "Nam" ? true : false;
            person.sDiaChi = txtDiaChi.Text;
            person.sEmail = txtEmail.Text;
            person.sSDT = txtSdt.Text;
            person.sUsername = txtUser.Text;
            person.sPassword = txtpw.Text;
            string resutl = bll_dangkydg.ThemTKDocGia(person);
            if (resutl == "Tài khoản đã được thêm thành công!")
            {
                MessageBox.Show("Đăng ký thành công!");
            }
            else
            {
                MessageBox.Show(resutl);
                // cho cac text box ve null
            }
        }
    }
}
