using BLL_QuanLyThuVien;
using DTO_QuanLyThuVien;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControl
{
    public partial class UserSetting : Form
    {
        private Form1 parentForm;
        DTO_Person person = new DTO_Person();
        BLL_QuanLyDocGia bllquanlydocgia = new BLL_QuanLyDocGia();
        private string usernameCu;
        public UserSetting(Form1 parentForm, DTO_Person person)
        {
            InitializeComponent();
            this.person = person;
            this.parentForm = parentForm;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            parentForm.Close();
        }
        private void UserSetting_Load_1(object sender, EventArgs e)
        {
            Load_Data();
        }
        private void Load_Data()
        {
            usernameCu = person.sUsername;
            txtName.Text = person.sHoTen;
            datepBirth.Value = person.sNgaySinh;
            cbbSet.Text = person.sGioiTinh ? "Nam" : "Nữ";
            txtPass.Text = person.sPassword;
            txtUser.Text = person.sUsername;
            txtAddress.Text = person.sDiaChi;
            txtAnhThe.Text = person.sSourceImage;  
            string path = "D:\\K25_Project_LTWinform\\DoAn\\images\\DocGia\\" + person.sSourceImage;
            pictbSourceImage.Image = Image.FromFile(path);
            txtSdt.Text = person.sSDT;
            txtEmail.Text = person.sEmail;
            lbMaDocGia.Text = person.sMa;
        }
        private void uiButton1_Click_1(object sender, EventArgs e)
        {
            person.sHoTen = txtName.Text;
            person.sDiaChi = txtAddress.Text;
            person.sPassword = txtPass.Text;
            person.sUsername = txtUser.Text;
            person.sSDT = txtSdt.Text;
            person.sEmail = txtEmail.Text;
            person.sNgaySinh = datepBirth.Value;
            person.sGioiTinh = cbbSet.Text == "Nam" ? true : false;
            if (ChangeImage == true)
            {
                SaveImageToFolder(fileNameLong);
                string path = "D:\\K25_Project_LTWinform\\DoAn\\images\\DocGia\\" + txtAnhThe.Text;
                string path1 = "D:\\K25_Project_LTWinform\\DoAn\\images\\DocGia\\" + person.sSourceImage;
                pictbSourceImage.Image?.Dispose();
                pictbSourceImage.Image = null;
                File.Delete(path1);
                pictbSourceImage.Image = Image.FromFile(path);
                person.sSourceImage = txtAnhThe.Text;
            }

            MessageBox.Show(
                bllquanlydocgia.UpdateDocGia(person, usernameCu),
                "Thông báo!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        public string fileNameLong;
        public string fileNameShort;
        public Boolean ChangeImage = false;
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
        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameLong = saveFileDialog1.FileName;
                fileNameShort = Path.GetFileName(saveFileDialog1.FileName);
                txtAnhThe.Text = fileNameShort;
                ChangeImage = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file.");
            }
        }

        private void pictbSourceImage_Click(object sender, EventArgs e)
        {

        }

        private void sataButton1_Click(object sender, EventArgs e)  // xem gio hang cua minh 
        {

        }
    }
}
