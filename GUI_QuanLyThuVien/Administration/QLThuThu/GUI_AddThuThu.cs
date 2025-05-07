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
            ps.sHoTen = txtName.Text;
            ps.sGioiTinh = cbGioiTinh.Text == "Nam" ? true : false;
            ps.sNgaySinh = dtpNgaySinh.Value;
            ps.sEmail = txtEmail.Text;
            ps.sSDT = txtSdt.Text;
            ps.sUsername = txtUser.Text;
            ps.sDiaChi = txtDiaChi.Text;
            ps.sPassword = txtpw.Text;
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

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameLong = openFileDialog1.FileName;
                fileNameShort = Path.GetFileName(openFileDialog1.FileName);
                lbanhthe.Text = fileNameShort;
                ps.sSourceImage = fileNameShort;
                ChangeImage = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file.");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchFile1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameLong = openFileDialog1.FileName;
                fileNameShort = Path.GetFileName(openFileDialog1.FileName);
                lbanhthe.Text = fileNameShort;
                ps.sSourceImage = fileNameShort;
                ChangeImage = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file.");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            ps.sHoTen = txtName.Text;
            ps.sGioiTinh = cbGioiTinh.Text == "Nam" ? true : false;
            ps.sNgaySinh = dtpNgaySinh.Value;
            ps.sEmail = txtEmail.Text;
            ps.sSDT = txtSdt.Text;
            ps.sUsername = txtUser.Text;
            ps.sDiaChi = txtDiaChi.Text;
            ps.sPassword = txtpw.Text;
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

        private void btnDangKy_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
