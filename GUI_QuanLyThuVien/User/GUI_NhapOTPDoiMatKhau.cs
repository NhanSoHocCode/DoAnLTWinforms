using BLL_QuanLyThuVien;
using DTO_QuanLyThuVien;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLyThuVien.User
{
    public partial class GUI_NhapOTPDoiMatKhau : Form
    {
        public GUI_NhapOTPDoiMatKhau()
        {
            InitializeComponent();
            guna2DragControl1.TargetControl = panel2;
        }
        

        BLL_TaiKhoan bll_taikhoan = new BLL_TaiKhoan();
        public DTO_Person person = new DTO_Person();
        public int OTP;
        public int countdown;
        private void GUI_NhapOTPDoiMatKhau_Load(object sender, EventArgs e)
        {
            countdown = 120; // Reset thời gian đếm ngược
            timer1.Interval = 1000; // Chạy mỗi giây
            timer1.Start();
            lbNameMail.Text = person.sEmail;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countdown > 0)
            {
                countdown--;
                lbtimer.Text = $"Mã OTP Của Bạn Có Hiệu Lực Trong {countdown}s"; // Cập nhật Label
            }
            else
            {
                timer1.Stop();
                OTP = -1;   // xoa bo OTP cua mail da goi di neu het thoi gian
                MessageBox.Show("Thời gian đã hết!");
                this.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == OTP.ToString())
            {
                //MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GUI_DoiMatKhau doiMatKhau = new GUI_DoiMatKhau();
                doiMatKhau.email = person.sEmail;
                doiMatKhau.ShowDialog();
                this.Close();
            }
            else if (txtOTP.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập OTP", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("OTP Không Đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbtimer_Click(object sender, EventArgs e)
        {

        }

        private void lbNameMail_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtOTP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
