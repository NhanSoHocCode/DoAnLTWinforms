using BLL_QuanLyThuVien;
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

namespace GUI_QuanLyThuVien.Administration.QLPhieuMuon
{
    public partial class GUI_XemChiTietPM : Form
    {
        public GUI_XemChiTietPM()
        {
            InitializeComponent();
        }
        BLL_QuanLyPhieuMuon bll = new BLL_QuanLyPhieuMuon();
        public DTO_PhieuMuon pm = new DTO_PhieuMuon();

        private void GUI_XemChiTietPM_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = bll.XemChiTietPhieuMuon(pm.sMaPhieuMuon);
        }
    }
}
