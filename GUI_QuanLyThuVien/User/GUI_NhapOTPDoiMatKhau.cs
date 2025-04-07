using BLL_QuanLyThuVien;
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
            panel2.MouseDown += PanelTitleBar_MouseDown;
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
                lbtimer.Text = $"Mã OTP Của Bạn Có Hiệu Lực Trong {countdown}s"; // Cập nhật Label
            }
            else
            {
                timer1.Stop();
                OTP = -1;   // xoa bo OTP cua mail da goi di neu het thoi gian
                MessageBox.Show("Thời gian đã hết!");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == OTP.ToString())
            {
                MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        
    }
}
