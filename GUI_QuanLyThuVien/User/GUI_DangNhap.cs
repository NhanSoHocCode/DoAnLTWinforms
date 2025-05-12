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
using GUI;

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
        BLL_TaiKhoan bll = new BLL_TaiKhoan();

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
            bll.SaveTimeLogin(taikhoan.sTenTK);  // luu lai thoi gian dang nhap tai Button DangNhap 
            if (taikhoan.sMaQuyen == 3)  // admin 
            {
                GUI_HomeManager homeManager = new GUI_HomeManager(3);
                homeManager.role = taikhoan.sMaQuyen;
                homeManager.username = taikhoan.sTenTK;
                // lam tu day de lay time 
                homeManager.Show();
            }
            else if (taikhoan.sMaQuyen == 1)  // doc gia 
            {
                DTO_Person person = new DTO_Person();
                BLL_QuanLyDocGia bllqldg = new BLL_QuanLyDocGia();
                DataTable dt = bllqldg.GetDgFromUsername(taikhoan.sTenTK);
                foreach (DataRow dr in dt.Rows)
                {
                    person.sMa = dr["maDocGia"].ToString();
                    person.sHoTen = dr["hoTen"].ToString();
                    person.sGioiTinh = Boolean.Parse(dr["gioiTinh"].ToString());
                    person.sSDT = dr["soDienThoai"].ToString();
                    person.sEmail = dr["email"].ToString();
                    person.sDiaChi = dr["diaChi"].ToString();
                    person.sSourceImage = dr["anhThe"].ToString();
                    person.sUsername = dr["username"].ToString();
                    person.sPassword = dr["password"].ToString();
                    person.sNgaySinh = DateTime.Parse(dr["ngaySinh"].ToString());
                }
                Form1 formCustomer = new Form1();
                formCustomer.person = person;
                formCustomer.Show();
            }
            else  // thu thu 
            {
                GUI_HomeManager homeManager = new GUI_HomeManager(2);
                homeManager.role = taikhoan.sMaQuyen;
                homeManager.username = taikhoan.sTenTK;
                homeManager.Show();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
