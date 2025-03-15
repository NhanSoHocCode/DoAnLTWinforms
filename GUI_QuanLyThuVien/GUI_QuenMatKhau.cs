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
namespace GUI_QuanLyThuVien
{
    public partial class GUI_QuenMatKhau : Form
    {
        public GUI_QuenMatKhau()
        {
            InitializeComponent();
        }
        BLL_QuanLyThuVien.BLL_TaiKhoan bll_taikhoan = new BLL_TaiKhoan();
        private void btnSearchTK_Click(object sender, EventArgs e)
        {
            int OTP = bll_taikhoan.SendMailPassWord(txtEmail.Text);
            if (OTP == 0)
            {
                MessageBox.Show("Email khong ton tai!, vui long nhap lai email chinh xac.");
            }
            else  //  làm lại cái messageBox sao cho đẹp hơn !!!!
            {
                bll_taikhoan.ChangePassByOTP(txtEmail.Text, OTP);  // return ve gia tri string thong bao result 
                MessageBox.Show("Mã OTP của bạn đã được sent, vui lòng nhập lại mật khẩu bằng mã OTP vừa gởi để đăng nhập");
                Close();  // dong form quen mat khau
            }


        }
    }
}
