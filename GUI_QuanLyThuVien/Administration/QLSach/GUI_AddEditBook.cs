using BLL_QuanLyThuVien;
using DTO_QuanLyThuVien;
using Guna.UI2.WinForms;
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
using static System.Net.Mime.MediaTypeNames;

namespace GUI_QuanLyThuVien.Administration
{
    public partial class GUI_AddEditBook : Form
    {
        public GUI_AddEditBook()
        {
            InitializeComponent();
        }
        public DTO_Sach sach1 = new DTO_Sach();
        public BLL_QuanLySach bll_quanlysach = new BLL_QuanLySach();
        public string fileNameLong;
        public string fileNameShort;
        public Boolean Add; 

        private void GUI_AddEditBook_Load(object sender, EventArgs e)
        {
            txtTacGia.Text = sach1.sTacGia;
            txtNhaXB.Text = sach1.sNhaXuatBan;
            txtDonGia.Text = sach1.sDonGia.ToString();
            txtMaThuThu.Text = sach1.sMaThuThu.ToString();
            txtTenSach.Text = sach1.sTenSach;
            npdSoLuong.Value = sach1.sSoLuong;
            MessageBox.Show(sach1.sSoLuong.ToString());
            txtTheLoai.Text = sach1.sTheLoai;
            txtSource.Text = sach1.sSourceImange;
            DataTable dt = new DataTable();
            dt = bll_quanlysach.ListMaThuThu();
            foreach (DataRow dr in dt.Rows)
            {
                txtMaThuThu.Items.Add(dr["maThuThu"].ToString());
            }
        }
        Boolean ChacgeImage = false;
        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameLong = openFileDialog1.FileName;
                fileNameShort = Path.GetFileName(openFileDialog1.FileName);
                txtSource.Text = fileNameShort;
                sach1.sSourceImange = fileNameShort;
                ChacgeImage = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file.");
            }

        }
        public void SaveImageToFolder(string sourcePath)
        {
            try
            {
                string destinationFolder = "D:\\K25_Project_LTWinform\\DoAn\\images\\";
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

        private void txtSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTheLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchFile1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameLong = openFileDialog1.FileName;
                fileNameShort = Path.GetFileName(openFileDialog1.FileName);
                txtSource.Text = fileNameShort;
                sach1.sSourceImange = fileNameShort;
                ChacgeImage = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file.");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (Add)  // neu true thi ta them moi
            {
                SaveImageToFolder(fileNameLong);
                sach1.sTacGia = txtTacGia.Text;
                sach1.sNhaXuatBan = txtNhaXB.Text;
                sach1.sDonGia = decimal.Parse(txtDonGia.Text);
                sach1.sMaThuThu = int.Parse(txtMaThuThu.Text);
                sach1.sTenSach = txtTenSach.Text;
                sach1.sSoLuong = (int)npdSoLuong.Value;
                sach1.sTheLoai = txtTheLoai.Text;
                sach1.sSourceImange = txtSource.Text;
                MessageBox.Show(bll_quanlysach.ThemSachMoi(sach1));
            }
            else  // ngc lai ta edit thoi 
            {
                if (ChacgeImage)
                {
                    SaveImageToFolder(fileNameLong);
                }
                sach1.sTacGia = txtTacGia.Text;
                sach1.sNhaXuatBan = txtNhaXB.Text;
                sach1.sDonGia = decimal.Parse(txtDonGia.Text);
                sach1.sMaThuThu = 2;
                sach1.sTenSach = txtTenSach.Text;
                sach1.sSoLuong = (int)npdSoLuong.Value;
                sach1.sTheLoai = txtTheLoai.Text;
                sach1.sSourceImange = txtSource.Text;
                MessageBox.Show(bll_quanlysach.SuaSach(sach1));   //  xet xem du lieu da oke chua trong BLL
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nrudSL_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
