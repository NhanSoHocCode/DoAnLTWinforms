using BLL_QuanLyThuVien;
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
    public partial class GUI_XacNhanOTP : Form
    {
        BLL_TaiKhoan bll_taikhoan = new BLL_TaiKhoan();
        public string mail;
        public int OTP;
        public int countdown;
        public GUI_XacNhanOTP()
        {
            InitializeComponent();
            guna2DragControl1.TargetControl = panel2;
        }
        
       

        

        private void GUI_XacNhanOTP_Load(object sender, EventArgs e)
        {
            countdown = 120; // Reset thời gian đếm ngược
            timer1.Interval = 1000; // Chạy mỗi giây
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countdown > 0)
            {
                countdown--;
                lbtimer.Text = $"Mã OTP Của Bạn Hết Hiệu Lực Trong {countdown}s"; // Cập nhật Label
            }
            else
            {
                timer1.Stop();
                OTP = -1;
                MessageBox.Show("Thời Gian Đã Hết Hạn!");
            }
        }

       

       

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == OTP.ToString())
            {
                GUI_DangKyDG dangKyDG = new GUI_DangKyDG();
                dangKyDG.mail = mail;
                dangKyDG.Show();
            }
            else if (txtOTP.Text == "Nhập Mã OTP")
            {
                MessageBox.Show("Vui Lòng Nhập OTP", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Vui Lòng Nhập Lại OTP");
            }
            else MessageBox.Show("OTP Không Đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
