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
using System.Runtime.InteropServices;
using Guna.UI2.WinForms;
using System.Drawing.Drawing2D;

namespace GUI_QuanLyThuVien
{
    public partial class GUI_DangNhap : Form
    {
        DTO_TaiKhoan taikhoan = new DTO_TaiKhoan();
        BLL_TaiKhoan bll_taikhoan = new BLL_TaiKhoan();

        public GUI_DangNhap()
        {
            InitializeComponent();
            guna2DragControl1.TargetControl = panel3;
            BoTronForm();
        }
        private void BoTronForm()
        {
            int borderRadius = 10; // Độ cong của viền

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
        }
        private void linkForGetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_QuenMatKhau quenMK = new GUI_QuenMatKhau();
            quenMK.Show();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            taikhoan.sTenTK = txtName.Text;
            taikhoan.sMatKhau = txtPw.Text;
            string getUser = bll_taikhoan.CheckeLogin(taikhoan);
            switch (getUser)
            {
                case "nonename":
                    MessageBox.Show("Vui long nhap ten tai khoan!");
                    return;
                case "nonepass":
                    MessageBox.Show("Vui long nhap mat khau!");
                    return;
                case "Eroll":
                    MessageBox.Show("Tai khoan hoac mat khau khong dung!");
                    return;
            }
            taikhoan.sMaQuyen = int.Parse(bll_taikhoan.LayQuyenUser(txtName.Text));
            if (taikhoan.sMaQuyen == 3)
            {
                GUI_HomeManager homeManager = new GUI_HomeManager();
                homeManager.role = taikhoan.sMaQuyen;
                homeManager.username = taikhoan.sTenTK;
                // lam tu day de lay time 
                homeManager.Show();
            }
            else if (taikhoan.sMaQuyen == 1)
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
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            GUI_XacNhapMailDangKy xacNhapMailDangKy = new GUI_XacNhapMailDangKy();
            xacNhapMailDangKy.Show();
        }
        private bool isPasswordVisible = false;
        private void txtPw_IconRightClick(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                txtPw.UseSystemPasswordChar = true;
                isPasswordVisible = false;
            }
            else
            {
                txtPw.UseSystemPasswordChar = false;
                isPasswordVisible = true;
            }
        }
    }
}
