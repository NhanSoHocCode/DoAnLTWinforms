using BLL_QuanLyThuVien;
using DTO_QuanLyThuVien;
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
    public partial class GUI_DoiMatKhau : Form
    {
        public GUI_DoiMatKhau()
        {
            InitializeComponent();
        }
        public string email;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtAcceptPassword.Text != txtpassword.Text)
            {
                MessageBox.Show("Mật khẩu không khớp vui lòng nhập lại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BLL_QuanLyDocGia bll_QuanLyDocGia = new BLL_QuanLyDocGia();
                DTO_Person person = new DTO_Person();
                person.sEmail = email;
                person.sPassword = txtpassword.Text;
                bll_QuanLyDocGia.DoiMatKhau(person);
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
