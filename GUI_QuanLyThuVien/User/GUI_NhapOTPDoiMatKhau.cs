using BLL_QuanLyThuVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }
        BLL_TaiKhoan bll_taikhoan = new BLL_TaiKhoan();
        public string mail;
        public int OTP;
        public int countdown;
        private void GUI_NhapOTPDoiMatKhau_Load(object sender, EventArgs e)
        {
            countdown = 120; // Reset thời gian đếm ngược
            timer1.Interval = 1000; // Chạy mỗi giây
            timer1.Start();
            lbNameMail.Text = mail;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countdown > 0)
            {
                countdown--;
                lbtimer.Text = $"mã OTP của bạn có hiệu lực trong {countdown} s"; // Cập nhật Label
            }
            else
            {
                timer1.Stop();
                OTP = -1;   // xoa bo OTP cua mail da goi di neu het thoi gian
                MessageBox.Show("Thời gian đã hết!");
            }
        }


        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == OTP.ToString())
            {
                MessageBox.Show("thanh cong");  // tao them form doi pass moi
            } else if (txtOTP.Text == "")
            {
                MessageBox.Show("Vui long nhap OTP");
            } else
            {
                MessageBox.Show("OTP khong dung");
            }
        }
    }
}
