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
using System.Xml.Linq;
using BLL_QuanLyThuVien.APIs;
using GUI_QuanLyThuVien.User;
using System.Runtime.InteropServices;
namespace GUI_QuanLyThuVien
{
    public partial class GUI_QuenMatKhau : Form
    {
        public GUI_QuenMatKhau()
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
        API_XacThucMail api= new API_XacThucMail();

        private void btnSearchTK_Click(object sender, EventArgs e)
        {
            int OTP = 0;
            if (bll_taikhoan.MailHopLe(txtEmail.Text))
            {
                OTP = api.SendMailPassWord(txtEmail.Text);
                GUI_NhapOTPDoiMatKhau nhapOTP = new GUI_NhapOTPDoiMatKhau();
                nhapOTP.mail = txtEmail.Text;
                nhapOTP.OTP = OTP;
                nhapOTP.Show();
            }
            else MessageBox.Show("Email không hợp lệ, vui lòng nhập lại email chính xác.");
            //  làm lại cái messageBox sao cho đẹp hơn !!!!
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email Address")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black; // Đổi màu chữ thành trắng
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email Address";
                txtEmail.ForeColor = Color.Black; // Màu placeholder
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Gray, 2);
            g.DrawLine(pen, 6, 146, 220, 146);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
