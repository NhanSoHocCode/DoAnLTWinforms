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
using BLL_QuanLyThuVien;
using System.Collections;
using GUI_QuanLyThuVien.User;

namespace GUI_QuanLyThuVien
{
    public partial class GUI_DangNhap : Form
    {
        DTO_TaiKhoan taikhoan = new DTO_TaiKhoan();
        BLL_TaiKhoan bll_taikhoan = new BLL_TaiKhoan();

        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            taikhoan.sTenTK = txtName.Text;
            taikhoan.sMatKhau = txtPw.Text;
            string getUser = bll_taikhoan.CheckeLogin(taikhoan);
            switch (getUser)
            {
                case "Vui long nhap ten tai khoan!":
                    MessageBox.Show("Vui long nhap ten tai khoan!");
                    return;
                case "Vui long nhap mat khau!":
                    MessageBox.Show("Vui long nhap mat khau!");
                    return;
                case "Tai khoan hoac mat khau khong dung!":
                    MessageBox.Show("Tai khoan hoac mat khau khong dung!");
                    return;
            }
            MessageBox.Show("Dang nhap thanh cong!");
            
        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            GUI_QuenMatKhau quenMK = new GUI_QuenMatKhau();
            quenMK.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateTKnew_Click(object sender, EventArgs e)
        {
            GUI_XacNhapMailDangKy xacNhapMailDangKy = new GUI_XacNhapMailDangKy();
            xacNhapMailDangKy.Show();
        }
    }
}
