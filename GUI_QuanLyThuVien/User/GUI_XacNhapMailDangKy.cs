using BLL_QuanLyThuVien;
using BLL_QuanLyThuVien.APIs;
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

namespace GUI_QuanLyThuVien.User
{

    public partial class GUI_XacNhapMailDangKy : Form
    {
        public GUI_XacNhapMailDangKy()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(20, 52, 75);
            txtEmail.BackColor = Color.FromArgb(20, 52, 75);
        }
        
        public BLL_TaiKhoan bll_taikhoan = new BLL_TaiKhoan();
        public API_XacThucMail api = new API_XacThucMail();
        
        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            if (bll_taikhoan.MailHopLe(txtEmail.Text))
            {
                MessageBox.Show("Email đã được sử dụng! \nVui lòng nhập lại mail mới");
                txtEmail.Text = "";
            } else if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mail");
            }
            else  // them truong hop nhap mail khong hop le neu kh co duoi @gmail.com
                  // va them chuc nang trong qua trinh nhap hien do neu mail kh hop le !!!!
            {
                int OTP = api.SendMailPassWord(txtEmail.Text);
                GUI_XacNhanOTP xacNhanOTP = new GUI_XacNhanOTP();
                xacNhanOTP.mail = txtEmail.Text;
                xacNhanOTP.OTP = OTP;
                xacNhanOTP.Show();
            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email Address";
                txtEmail.ForeColor = Color.Gray; // Màu placeholder
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email Address")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.White; // Đổi màu chữ thành trắng
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Gray, 2);
            g.DrawLine(pen, 80, 50, 335, 50);
        }
    }
}
