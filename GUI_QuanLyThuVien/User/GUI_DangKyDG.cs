using BLL_QuanLyThuVien;
using DTO_QuanLyThuVien;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
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



        public void SaveImageToFolder(string sourceImagePath)
        {
            if (string.IsNullOrWhiteSpace(sourceImagePath) || !File.Exists(sourceImagePath))
            {
                throw new ArgumentException("Đường dẫn ảnh nguồn không hợp lệ hoặc file không tồn tại");
            }

            try
            {
                // Xác định thư mục đích
                string destinationFolder = @"D:\K25_Project_LTWinform\DoAn\images\DocGia";

                // Tạo thư mục nếu chưa tồn tại
                Directory.CreateDirectory(destinationFolder);

                // Sao chép file (ghi đè nếu đã tồn tại)
                string fileName = Path.GetFileName(sourceImagePath);
                string destinationPath = Path.Combine(destinationFolder, fileName);
                File.Copy(sourceImagePath, destinationPath, overwrite: true);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lưu ảnh: {ex.Message}", ex);
            }
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
            person.sSourceImage = fileNameShort;
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
            } else if (ChangeImage == false)
            {
                MessageBox.Show("Chưa Chọn Ảnh Thẻ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveImageToFolder(fileNameLong);
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
        string fileNameLong;
        string fileNameShort;
        string anhtheold;
        bool ChangeImage = false;
        private void guna2Button1_Click(object sender, EventArgs e) // chọn ảnh thẻ 
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameLong = openFileDialog1.FileName;
                fileNameShort = Path.GetFileName(openFileDialog1.FileName);
                anhtheold = fileNameShort;
                ptbAnhThe.Image = Image.FromFile(fileNameLong);
                ChangeImage = true;                
                ptbAnhThe.Image = Image.FromFile(fileNameLong);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file.");
            }
        }
    }
}
