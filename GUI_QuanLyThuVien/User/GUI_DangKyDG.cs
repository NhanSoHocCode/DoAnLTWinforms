using BLL_QuanLyThuVien;
using DTO_QuanLyThuVien;
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
            //panel3.Dock = DockStyle.Top;
            //this.BackColor = Color.FromArgb(210, 218, 255);

            InitializeComponent();
            panel3.Dock = DockStyle.Top;
            panel3.BackColor = Color.Transparent; // Làm trong suốt

            this.Controls.Add(panel3);
            panel3.BackColor = Color.FromArgb(238, 241, 255);
            panel3.MouseDown += PanelTitleBar_MouseDown;
            txtDiaChi.BackColor = Color.FromArgb(210, 218, 255);
            txtSdt.BackColor = Color.FromArgb(210, 218, 255);
            txtName.BackColor = Color.FromArgb(210, 218, 255);
            txtpw.BackColor = Color.FromArgb(210, 218, 255);
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
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0xA1, 0x2, 0); // Gửi lệnh di chuyển cửa sổ
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
        private void txtpw_TextChanged(object sender, EventArgs e)
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



        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Gray, 2);
            g.DrawLine(pen, 20, 45, 250, 45);
            g.DrawLine(pen, 20, 115, 250, 115);
            g.DrawLine(pen, 20, 150, 250, 150);
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
