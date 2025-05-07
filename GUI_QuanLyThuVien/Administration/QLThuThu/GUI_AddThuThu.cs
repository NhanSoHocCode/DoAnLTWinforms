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
using BLL_QuanLyThuVien;
using DTO_QuanLyThuVien;
using Guna.UI2.WinForms;
namespace GUI_QuanLyThuVien.Administration.QLThuThu
{
    public partial class GUI_AddThuThu : Form
    {
        public GUI_AddThuThu()
        {
            InitializeComponent();
        }
        BLL_QuanLyThuThu bll_quanlythuthu = new BLL_QuanLyThuThu();
        DTO_Person ps = new DTO_Person();

        private void btnAddTT_Click(object sender, EventArgs e)
        {
            ps.sHoTen = txtHoten.Text;
            ps.sGioiTinh = cbGioiTinh.Text == "Nam" ? true : false;
            ps.sNgaySinh = dtNgaySinh.Value;
            ps.sEmail = txtEmail.Text;
            ps.sSDT = txtSdt.Text;
            ps.sUsername = txtUsername.Text;
            ps.sDiaChi = txtAddress.Text;
            ps.sPassword = txtPassword.Text;
            if (ChangeImage)
            {
                ps.sSourceImage = fileNameShort;
                MessageBox.Show(bll_quanlythuthu.AddThuThu(ps));
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin file ảnh");
                return;
            }


        }
        public string fileNameLong;
        public string fileNameShort;
        public Boolean ChangeImage = false;
        public void SaveImageToFolder(string sourcePath)
        {
            try
            {
                string destinationFolder = "D:\\K25_Project_LTWinform\\DoAn\\images\\ThuThu\\";
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
        private void btnSearchFile1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameLong = openFileDialog1.FileName;
                SaveImageToFolder(fileNameLong);
                fileNameShort = Path.GetFileName(openFileDialog1.FileName);
                lbanhthe.Text = fileNameShort;
                ps.sSourceImage = fileNameShort;
                guna2CirclePictureBox1.Image = Image.FromFile(fileNameLong);
                ChangeImage = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file.");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            ps.sHoTen = txtHoten.Text;
            ps.sGioiTinh = cbGioiTinh.Text == "Nam" ? true : false;
            ps.sNgaySinh = dtNgaySinh.Value;
            ps.sEmail = txtEmail.Text;
            ps.sSDT = txtSdt.Text;
            ps.sUsername = txtUsername.Text;
            ps.sDiaChi = txtAddress.Text;
            ps.sPassword = txtPassword.Text;
            ps.sChucVu = "2";
            if (ChangeImage)
            {
                ps.sSourceImage = fileNameShort;
                MessageBox.Show(bll_quanlythuthu.AddThuThu(ps));
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin file ảnh");
                return;
            }
        }
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
           this.Close();
        }


    }
}
