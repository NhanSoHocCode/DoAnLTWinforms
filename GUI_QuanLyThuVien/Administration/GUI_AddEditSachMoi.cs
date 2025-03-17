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
using BLL_QuanLyThuVien;
using System.IO;

namespace GUI_QuanLyThuVien.Administration
{
    public partial class GUI_AddEditSachMoi : Form
    {
        private DTO_Sach sach1; // Original book data (passed in)
        private DTO_Sach sach;  // Updated book data
        private BLL_QuanLySach bll_quanlysach;
        private string fileNameShort;
        private string fileNameLong;

        // Constructor to pass existing book data
        public GUI_AddEditSachMoi(DTO_Sach existingBook = null)
        {
            InitializeComponent();
            bll_quanlysach = new BLL_QuanLySach();
            sach1 = existingBook ?? new DTO_Sach(); // Use existing book or create new
            sach = new DTO_Sach();
        }

        private void GUI_ThemSachMoi_Load(object sender, EventArgs e)
        {
            txtDonGia.Text = sach1.sDonGia ?? "";
            txtNhaXB.Text = sach1.sNhaXuatBan ?? "";
            nrudSL.Value = sach1.sSoLuong;
            txtTacGia.Text = sach1.sTacGia ?? "";
            txtTenSach.Text = sach1.sTenSach ?? "";
            txtTheLoai.Text = sach1.sTheLoai ?? "";
            txtSource.Text = sach1.sSourceImange ?? "";
            txtMaThuThu.Text = sach1.sMaThuThu ?? "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrEmpty(txtTenSach.Text) || string.IsNullOrEmpty(txtSource.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin (tên sách và đường dẫn ảnh).");
                return;
            }

            // Populate updated book data
            sach.sDonGia = txtDonGia.Text;
            sach.sNhaXuatBan = txtNhaXB.Text;
            sach.sSoLuong = (int)nrudSL.Value;
            sach.sTacGia = txtTacGia.Text;
            sach.sTenSach = txtTenSach.Text;
            sach.sTheLoai = txtTheLoai.Text;
            sach.sMaThuThu = txtMaThuThu.Text;
            sach.sMaSach = sach1.sMaSach; // Preserve original book ID
            sach.sSourceImange = fileNameShort;

            // Save image and update book
            taiAnhVeImages(fileNameLong);
            string result = bll_quanlysach.SuaSach(sach);
            MessageBox.Show(result);
        }

        private string taiAnhVeImages(string sourcePath)
        {
            string destinationFolder = Path.Combine(Application.StartupPath, "images"); // Dynamic path
            try
            {
                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                fileNameShort = Path.GetFileName(sourcePath);
                string destinationPath = Path.Combine(destinationFolder, fileNameShort);

                // Copy and save the image
                using (Bitmap img = new Bitmap(sourcePath))
                {
                    img.Save(destinationPath);
                }

                sach.sSourceImange = destinationPath; // Full path for storage
                txtSource.Text = fileNameShort;       // Short name for display
                return "Lưu ảnh thành công";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu ảnh: {ex.Message}");
                return "Lưu ảnh thất bại";
            }
        }

        private void btnFileAnh_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameLong = openFileDialog1.FileName;
                fileNameShort = Path.GetFileName(fileNameLong);
                txtSource.Text = fileNameShort; // Display short name
            }
        }
    }
}