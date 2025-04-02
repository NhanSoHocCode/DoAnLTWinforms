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
                person.sSourceImage = fileNameShort;
                ChangeImage = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file.");
            }
        }
        public void SaveImageToFolder(string sourcePath)  // nhan dang dang chinh sua cho doi tuong nao 
        {

            try
            {
                string destinationFolder = "D:\\K25_Project_LTWinform\\DoAn\\images\\ThuThu\\";
                if (DocGia == true)
                {
                    destinationFolder = "D:\\K25_Project_LTWinform\\DoAn\\images\\DocGia\\";
                }
                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                string fileName = Path.GetFileName(sourcePath);
                string destinationPath = Path.Combine(destinationFolder, fileName);
                File.Copy(sourcePath, destinationPath, true);
            }
            catch (Exception ex)
            {
                throw ex;
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
                person.sSourceImage = lbAnhThe.Text;
                SaveImageToFolder(fileNameLong);
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
    }
}
