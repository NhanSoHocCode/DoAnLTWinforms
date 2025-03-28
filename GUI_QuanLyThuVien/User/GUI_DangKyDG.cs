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


namespace GUI_QuanLyThuVien
{
    public partial class GUI_DangKyDG : Form
    {
        BLL_DangKyDG bll_dangkydg = new BLL_DangKyDG();
        DTO_Person person = new DTO_Person();
        public string mail;
        public GUI_DangKyDG()
        {
            this.BackColor = Color.FromArgb(20, 52, 75);
            InitializeComponent();

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            person.sHoTen = txtName.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            person.sNgaySinh = ngaySinh;
            person.sGioiTinh = cbGioiTinh.Text == "Nam" ? true : false;
            person.sDiaChi = txtDiaChi.Text;
            person.sSDT = txtSdt.Text;
            person.sEmail = mail;
            person.sUsername = txtUser.Text;
            person.sPassword = txtpw.Text;
            string resutl = bll_dangkydg.ThemTKDocGia(person);
            if (resutl == "Tài khoản đã được thêm thành công!")
            {
                MessageBox.Show("Đăng ký thành công!");
            }
            else
            {
                MessageBox.Show(resutl);
                // cho cac text box ve null
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GUI_DangKyDG_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(20, 52, 75);
            lbInFo.Text = "Đang Thực Hiện Với Tư Cách " + mail;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtXacNhanpw_TextChanged(object sender, EventArgs e)
        {
            if (txtpw.Text != txtXacNhanpw.Text)
            {
                txtXacNhanpw.ForeColor = Color.Red;
            } else
            {
                txtXacNhanpw.ForeColor = Color.Black;
                lbInfoRePass.Text = "Mật Khẩu Trùng Khớp";
                lbInfoRePass.ForeColor = Color.Black;
            }
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.Gray; // Màu placeholder
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;
            }
        }

        private void txtpw_Enter(object sender, EventArgs e)
        {
            if (txtpw.Text == "Password")
            {
                txtpw.Text = "";
                txtpw.ForeColor = Color.Gray; // Đổi màu chữ thành trắng
            }

        }

        private void txtpw_Leave(object sender, EventArgs e)
        {
            if (txtpw.Text == "")
            {
                txtpw.Text = "Password";
                txtpw.ForeColor = Color.Gray; // Màu placeholder
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
             if (txtName.Text == "Họ Và Tên")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Gray;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Họ Và Tên";
                txtName.ForeColor = Color.Gray; // Màu placeholder
            }
        }

        private void txtSdt_Enter(object sender, EventArgs e)
        {
            if (txtSdt.Text == "Số Điện Thoại")
            {
                txtSdt.Text = "";
                txtSdt.ForeColor = Color.Gray;
            }
        }

        private void txtSdt_Leave(object sender, EventArgs e)
        {
            if (txtSdt.Text == "")
            {
                txtSdt.Text = "Số Điện Thoại";
                txtSdt.ForeColor = Color.Gray; // Màu placeholder
            }
        }

        private void txtDiaChi_Enter(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "Địa Chỉ")
            {
                txtDiaChi.Text = "";
                txtDiaChi.ForeColor = Color.Gray;
            }
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "")
            {
                txtDiaChi.Text = "Địa Chỉ";
                txtDiaChi.ForeColor = Color.Gray; // Màu placeholder
            }
        }

        private void txtpw_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtXacNhanpw_Enter(object sender, EventArgs e)
        {
            if (txtXacNhanpw.Text == "Password")
            {
                txtXacNhanpw.Text = "";
                txtXacNhanpw.ForeColor = Color.Gray; // Đổi màu chữ thành trắng
            }
            
        }

        private void txtXacNhanpw_Leave(object sender, EventArgs e)
        {
            if (txtXacNhanpw.Text == "")
            {
                txtXacNhanpw.Text = "Password";
                txtXacNhanpw.ForeColor = Color.Gray; // Màu placeholder
            }

        }

        
    }
}
