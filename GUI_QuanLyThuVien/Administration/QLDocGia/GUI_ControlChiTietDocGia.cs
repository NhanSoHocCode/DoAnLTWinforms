using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLyThuVien;
using BLL_QuanLyThuVien;
using System.Threading;
using System.Diagnostics;
using Sunny.UI;
namespace GUI_QuanLyThuVien.Administration.QLDocGia
{
    public partial class GUI_ControlChiTietDocGia : Form
    {
        public GUI_ControlChiTietDocGia()
        {
            InitializeComponent();
        }
        public Boolean DocGia;
        public DTO_Person person;
        public BLL_QuanLyThuThu bll_QuanLyThuThu = new BLL_QuanLyThuThu();
        public BLL_QuanLyDocGia bll_QuanLyDocGia = new BLL_QuanLyDocGia();
        string anhtheold = "";
        string usernameold = "";

        private void GUI_ControlChiTietDocGia_Load(object sender, EventArgs e)  // mượn tạm của đọc giả 
        {
            if (DocGia == false)
            {
                label1.Text = "Mã thủ thư";
            }
            txtPassword.Text = person.sPassword;
            txtAddress.Text = person.sDiaChi;
            txtEmail.Text = person.sEmail;
            txtUsername.Text = person.sUsername;
            usernameold = person.sUsername;
            txtSdt.Text = person.sSDT;
            lbHocten.Text = person.sHoTen;
            lbMa.Text = person.sMa;
            lbNgaySinh.Text = person.sNgaySinh.ToString();
            lbSet.Text = person.sGioiTinh == true ? "Nam" : "Nữ";
            anhtheold = person.sSourceImage;
            try
            {
                ptbAnhThe.Image = Image.FromFile(person.sSourceImage);
            }
            catch (Exception)
            {
                // Nếu không tìm thấy ảnh, có thể sử dụng ảnh mặc định hoặc xử lý theo cách khác
                ptbAnhThe.Image = Image.FromFile("D:\\K25_Project_LTWinform\\DoAn\\images\\clone.jpg");
            }
            
        }
        public string fileNameLong;
        public string fileNameShort;
        public Boolean Add;
        public Boolean ChangeImage = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameLong = openFileDialog1.FileName;
                fileNameShort = Path.GetFileName(openFileDialog1.FileName);
                anhtheold = fileNameShort;
              
                ChangeImage = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file.");
            }
        }


        // Lưu ảnh vào thư mục tương ứng (DocGia/ThuThu)
        public void SaveImageToFolder(string sourceImagePath)
        {
            if (string.IsNullOrWhiteSpace(sourceImagePath) || !File.Exists(sourceImagePath))
            {
                throw new ArgumentException("Đường dẫn ảnh nguồn không hợp lệ hoặc file không tồn tại");
            }

            try
            {
                // Xác định thư mục đích
                string destinationFolder = DocGia
                    ? @"D:\K25_Project_LTWinform\DoAn\images\DocGia"
                    : @"D:\K25_Project_LTWinform\DoAn\images\ThuThu";

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

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            if (DocGia != true)
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa độc giả {person.sHoTen}?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show(bll_QuanLyThuThu.DelThuThu(person.sMa));
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa thủ thư {person.sHoTen}?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show(bll_QuanLyDocGia.DelDocGia(person.sMa));
                }
            }

        }



        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (DocGia != true)
            {
                MessageBox.Show(bll_QuanLyThuThu.DelThuThu(person.sMa));
            }
            else
            {
                MessageBox.Show(bll_QuanLyDocGia.DelDocGia(person.sMa));
            }
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameLong = openFileDialog1.FileName;
                fileNameShort = Path.GetFileName(openFileDialog1.FileName);
                anhtheold = fileNameShort;
                ptbAnhThe.Image = Image.FromFile(fileNameLong);
                ChangeImage = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file.");
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            person.sDiaChi = txtAddress.Text;
            person.sEmail = txtEmail.Text;
            person.sUsername = txtUsername.Text;
            person.sSDT = txtSdt.Text;
            person.sNgaySinh = DateTime.Parse(lbNgaySinh.Text);
            person.sHoTen = lbHocten.Text;
            person.sGioiTinh = lbSet.Text == "Nam" ? true : false;
            person.sPassword = txtPassword.Text;
            if (ChangeImage == true)
            {
                SaveImageToFolder(fileNameLong);
                //string path = "D:\\K25_Project_LTWinform\\DoAn\\images\\DocGia\\" + anhtheold;
                //ptbAnhThe.Image?.Dispose();
                //ptbAnhThe.Image = null;
                //File.Delete(person.sSourceImage);
                person.sSourceImage = anhtheold;
            }
            if (DocGia == true)
            {
                MessageBox.Show(bll_QuanLyDocGia.UpdateDocGia(person, usernameold));
            }
            else
            {
                MessageBox.Show(bll_QuanLyThuThu.UpdateThuThu(person, usernameold));
            }
        }
    }
}
