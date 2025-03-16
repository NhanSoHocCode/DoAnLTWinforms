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
using BLL_QuanLyThuVien;
using BLL_QuanLyThuVien.APIs;
using GUI_QuanLyThuVien.User;
namespace GUI_QuanLyThuVien
{
    public partial class GUI_QuenMatKhau : Form
    {
        public GUI_QuenMatKhau()
        {
            InitializeComponent();
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
