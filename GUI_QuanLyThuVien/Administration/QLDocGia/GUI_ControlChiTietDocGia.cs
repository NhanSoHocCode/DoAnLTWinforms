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

        private void GUI_ControlChiTietDocGia_Load(object sender, EventArgs e)  // mượn tạm của đọc giả 
        {
            txtAddress.Text = person.sDiaChi;
            txtEmail.Text = person.sEmail;
            txtUsername.Text = person.sUsername;
            txtSdt.Text = person.sSDT;
            lbHocten.Text = person.sHoTen;
            lbMa.Text = person.sMa;
            lbNgaySinh.Text = person.sNgaySinh.ToString();
            lbSet.Text = person.sGioiTinh == true ? "Nam" : "Nữ";
            lbAnhThe.Text = person.sSourceImage;
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
                lbAnhThe.Text = fileNameShort;
              
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

        // Xóa ảnh từ thư mục
        public void DelImageFromFolder(string imageFileName)
        {
            if (string.IsNullOrWhiteSpace(imageFileName))
            {
                throw new ArgumentException("Tên file không hợp lệ");
            }

            try
            {
                // Xác định thư mục
                string targetFolder = DocGia
                    ? @"D:\K25_Project_LTWinform\DoAn\images\DocGia"
                    : @"D:\K25_Project_LTWinform\DoAn\images\ThuThu";

                string filePath = Path.Combine(targetFolder, imageFileName);

                // Thực hiện xóa
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                else
                {
                    throw new FileNotFoundException($"File ảnh không tồn tại: {filePath}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa ảnh: {ex.Message}", ex);
            }
        }
        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            person.sDiaChi = txtAddress.Text;
            person.sEmail = txtEmail.Text;
            person.sUsername = txtUsername.Text;
            person.sSDT = txtSdt.Text;
            person.sNgaySinh = DateTime.Parse(lbNgaySinh.Text);
            if (ChangeImage == true)
            {
                
                SaveImageToFolder(fileNameLong);
                DelImageFromFolder(person.sSourceImage);
                person.sSourceImage = lbAnhThe.Text;
            }
            if (DocGia == true)
            {
                MessageBox.Show(bll_QuanLyDocGia.EditDocGia(person));  
            } else
            {
                MessageBox.Show(bll_QuanLyThuThu.EditThuThu(person));
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DocGia != true)
            {
                MessageBox.Show(bll_QuanLyThuThu.DelThuThu(person.sMa));
            } else
            {
                MessageBox.Show(bll_QuanLyDocGia.DelDocGia(person.sMa));
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
