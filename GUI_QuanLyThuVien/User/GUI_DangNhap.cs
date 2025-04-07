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

namespace GUI_QuanLyThuVien
{
    public partial class GUI_DangNhap : Form
    {
        DTO_TaiKhoan taikhoan = new DTO_TaiKhoan();
        BLL_TaiKhoan bll_taikhoan = new BLL_TaiKhoan();

        public GUI_DangNhap()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(210, 218, 255);
            this.FormBorderStyle = FormBorderStyle.None;

            ////ssssss
            ///
            panel3.Dock = DockStyle.Top;
            panel3.BackColor = Color.FromArgb(238, 241, 255);

            this.Controls.Add(panel3);
            panel3.MouseDown += PanelTitleBar_MouseDown;

        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0xA1, 0x2, 0); // Gửi lệnh di chuyển cửa sổ
        }

        

        

        private void GUI_DangNhap_Load(object sender, EventArgs e)
        {

            
        }



        

        

        

        

        private void linkForGetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_QuenMatKhau quenMK = new GUI_QuenMatKhau();
            quenMK.Show();
        }

        
        

        //private void btnClose_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
