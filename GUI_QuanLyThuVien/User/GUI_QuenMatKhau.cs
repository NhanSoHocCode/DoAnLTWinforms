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
            
            //  làm lại cái messageBox sao cho đẹp hơn !!!!
        }

       

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeachTK_Click(object sender, EventArgs e)
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
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
