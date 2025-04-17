using BLL_QuanLyThuVien;
using DTO_QuanLyThuVien;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
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

            InitializeComponent();

            guna2DragControl1.TargetControl = guna2Panel1;
            BoTronForm();
        }
        private void BoTronForm()
        {
            int borderRadius = 10; // Độ cong của viền

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
        }
        

       

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GUI_DangKyDG_Load(object sender, EventArgs e)
        {
            lbInFo.Text = "Đăng Kí Với Tư Cách " + mail;
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
            }
            else txtXacNhanpw.ForeColor = Color.Black;
        }

        

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();   
        }

        

        private void picShowConfirm_Click(object sender, EventArgs e)
        {
            txtXacNhanpw.UseSystemPasswordChar = !txtXacNhanpw.UseSystemPasswordChar;
        }

        private void txtpw_TextChanged_1(object sender, EventArgs e)
        {
            if (txtXacNhanpw.Text != "Confirm password")
            {
                if (txtpw.Text != txtXacNhanpw.Text)
                {
                    txtXacNhanpw.ForeColor = Color.Red;
                }
                else txtXacNhanpw.ForeColor = Color.Black;
            }
        }

        private void txtXacNhanpw_TextChanged_1(object sender, EventArgs e)
        {
            if (txtpw.Text != txtXacNhanpw.Text)
            {
                txtXacNhanpw.ForeColor = Color.Red;
            }
            else txtXacNhanpw.ForeColor = Color.Black;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
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
            if (txtXacNhanpw.Text == "Confirm password" || txtpw.Text == "Password")
            {
                MessageBox.Show("Chưa Nhập Mật Khẩu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtpw.Text != txtXacNhanpw.Text)
            {
                txtXacNhanpw.ForeColor = Color.Red;
                MessageBox.Show("Mật Khẩu Không Trùng Khớp", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
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

        private bool isPasswordVisible = false;
        private void txtpw_IconRightClick(object sender, EventArgs e)
        {

            if (isPasswordVisible)
            {
                txtpw.UseSystemPasswordChar = true;
                isPasswordVisible = false;
            }
            else
            {
                txtpw.UseSystemPasswordChar = false;
                isPasswordVisible = true;
            }
        }
        private bool isPasswordConfim = false;
        private void txtXacNhanpw_IconRightClick(object sender, EventArgs e)
        {
            if (isPasswordConfim)
            {
                txtXacNhanpw.UseSystemPasswordChar = true;
                isPasswordConfim = false;
            }
            else
            {
                txtXacNhanpw.UseSystemPasswordChar = false;
                isPasswordConfim = true;
            }
        }

        
    }
}
