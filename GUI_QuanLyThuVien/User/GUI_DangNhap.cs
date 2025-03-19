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
using GUI_QuanLyThuVien.Administration;
using System.Drawing;

namespace GUI_QuanLyThuVien
{
    public partial class GUI_DangNhap : Form
    {
        DTO_TaiKhoan taikhoan = new DTO_TaiKhoan();
        BLL_TaiKhoan bll_taikhoan = new BLL_TaiKhoan();

        public GUI_DangNhap()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(20, 52, 75);
            txtName.BackColor = Color.FromArgb(20, 52, 75);
            txtPw.BackColor = Color.FromArgb(20, 52, 75);
            

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Gray, 2);
            g.DrawLine(pen, 10, 230, 250, 230);
            g.DrawLine(pen, 10, 287, 250, 287);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            taikhoan.sTenTK = txtName.Text;
            taikhoan.sMatKhau = txtPw.Text;
            taikhoan.sMaQuyen = int.Parse(bll_taikhoan.LayQuyenUser(txtName.Text));
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
            if (taikhoan.sMaQuyen == 3)
            {
                GUI_HomeManager homeManager = new GUI_HomeManager();
                homeManager.role = taikhoan.sMaQuyen;
                homeManager.username = taikhoan.sTenTK;
                // lam tu day de lay time 
                homeManager.Show();
            } else if(taikhoan.sMaQuyen == 1)
            {
                GUI_Home home = new GUI_Home();
                home.Show();
            }
            else
            {
                GUI_Home home = new GUI_Home();
                home.Show();
            }



        }

        //private void btnQuenMK_Click(object sender, EventArgs e)
        //{
        //    GUI_QuenMatKhau quenMK = new GUI_QuenMatKhau();
        //    quenMK.Show();
        //}

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateTKnew_Click(object sender, EventArgs e)
        {
            GUI_XacNhapMailDangKy xacNhapMailDangKy = new GUI_XacNhapMailDangKy();
            xacNhapMailDangKy.Show();
        }

        private void GUI_DangNhap_Load(object sender, EventArgs e)
        {

            
        }



        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_Leave_1(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Username";
                txtName.ForeColor = Color.Gray; // Màu placeholder
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Username")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.White; // Đổi màu chữ thành trắng
            }
        }

        private void txtPw_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPw.Text))
            {
                txtPw.Text = "Password";
                txtPw.ForeColor = Color.Gray;
                txtPw.UseSystemPasswordChar = false; // Hiện placeholder
            }
        }

        private void txtPw_Enter(object sender, EventArgs e)
        {
            if (txtPw.Text == "Password")
            {
                txtPw.Text = "";
                txtPw.ForeColor = Color.Black; // Trả lại màu chữ bình thường
                txtPw.UseSystemPasswordChar = true; // Ẩn mật khẩu
            }
        }

        private void linkForGetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_QuenMatKhau quenMK = new GUI_QuenMatKhau();
            quenMK.Show();
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            txtPw.UseSystemPasswordChar = !txtPw.UseSystemPasswordChar;
        }
    }
}
