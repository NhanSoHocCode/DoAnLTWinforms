using BLL_QuanLyThuVien;
using DTO_QuanLyThuVien;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControl
{
    public partial class GUI_XemChiTietPhieuMuon : Form
    {
        public GUI_XemChiTietPhieuMuon()
        {
            InitializeComponent();
        }
        BLL_QuanLyPhieuMuon bll = new BLL_QuanLyPhieuMuon();
        public DTO_PhieuMuon pm = new DTO_PhieuMuon();
        private void GUI_XemChiTietPhieuMuon_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = bll.XemChiTietPhieuMuon(pm.sMaPhieuMuon);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
