using BLL_QuanLyThuVien;
using DTO_QuanLyThuVien;
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
            panel3.Dock = DockStyle.Top;
            panel3.BackColor = Color.Transparent; // Làm trong suốt

            this.Controls.Add(panel3);
            panel3.MouseDown += PanelTitleBar_MouseDown;
            txtDiaChi.BackColor = Color.FromArgb(20, 52, 75);
            txtSdt.BackColor = Color.FromArgb(20, 52, 75);
            txtName.BackColor = Color.FromArgb(20, 52, 75);
            txtXacNhanpw.BackColor = Color.FromArgb(20, 52, 75);
            txtpw.BackColor = Color.FromArgb(20, 52, 75);
            txtUser.BackColor = Color.FromArgb(20, 52, 75);
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
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Gray, 2);
            g.DrawLine(pen, 20, 158, 250, 158);
            g.DrawLine(pen, 20, 190, 250, 190);
            g.DrawLine(pen, 20, 220, 250, 220);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Gray, 2);
            g.DrawLine(pen, 20, 45, 250, 45);
            g.DrawLine(pen, 20, 115, 250, 115);
            g.DrawLine(pen, 20, 150, 250, 150);
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
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtpw_Enter(object sender, EventArgs e)
        {
            if (txtpw.Text == "Password")
            {
                txtpw.Text = "";
                txtpw.ForeColor = Color.Black; // Trả lại màu chữ bình thường
                txtpw.UseSystemPasswordChar = true; // Ẩn mật khẩu
            }

        }

        private void txtpw_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpw.Text))
            {
                txtpw.Text = "Password";
                txtpw.ForeColor = Color.Gray;
                txtpw.UseSystemPasswordChar = false; // Hiện placeholder
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

        

        private void txtXacNhanpw_Enter(object sender, EventArgs e)
        {
            if (txtXacNhanpw.Text == "Confirm password")
            {
                txtXacNhanpw.Text = "";
                txtXacNhanpw.ForeColor = Color.Black; // Trả lại màu chữ bình thường
                txtXacNhanpw.UseSystemPasswordChar = true; // Ẩn mật khẩu
            }

        }

        private void txtXacNhanpw_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtXacNhanpw.Text))
            {
                txtXacNhanpw.Text = "Confirm password";
                txtXacNhanpw.ForeColor = Color.Gray;
                txtXacNhanpw.UseSystemPasswordChar = false; // Hiện placeholder
            }

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            txtpw.UseSystemPasswordChar = !txtpw.UseSystemPasswordChar;
        }

        private void picShowConfirm_Click(object sender, EventArgs e)
        {
            txtXacNhanpw.UseSystemPasswordChar = !txtXacNhanpw.UseSystemPasswordChar;
        }
    }
}
