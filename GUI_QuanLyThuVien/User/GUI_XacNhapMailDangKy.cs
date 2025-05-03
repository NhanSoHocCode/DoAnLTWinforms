using BLL_QuanLyThuVien;
using BLL_QuanLyThuVien.APIs;
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
using System.Xml.Linq;

namespace GUI_QuanLyThuVien.User
{

    public partial class GUI_XacNhapMailDangKy : Form
    {
        public BLL_TaiKhoan bll_taikhoan = new BLL_TaiKhoan();
        public API_XacThucMail api = new API_XacThucMail();
        public GUI_XacNhapMailDangKy()
        {
            InitializeComponent();
        }
        
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
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mail");
            }
            else  // them truong hop nhap mail khong hop le neu kh co duoi @gmail.com
                  // va them chuc nang trong qua trinh nhap hien do neu mail kh hop le !!!!
            {
                int OTP = api.SendMailPassWord(txtEmail.Text, false);
                if (OTP == 0)
                {
                    MessageBox.Show("Email không tồn tại hoặc không hợp lệ!");
                }
                else
                {
                    GUI_XacNhanOTP xacNhanOTP = new GUI_XacNhanOTP();
                    xacNhanOTP.mail = txtEmail.Text;
                    xacNhanOTP.OTP = OTP;
                    xacNhanOTP.Show();
                }
            }
        }
    }
}
