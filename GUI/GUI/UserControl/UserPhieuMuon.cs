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

namespace GUI.UserControl
{
    public partial class UserPhieuMuon : Form
    {
        public UserPhieuMuon()
        {
            InitializeComponent();
        }
        BLL_QuanLyPhieuMuon bll_quanlyphieumuon = new BLL_QuanLyPhieuMuon();
        public DTO_PhieuMuon pm;
        private void UserPhieuMuon_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.ClearSelection();
            guna2DataGridView1.DataSource = bll_quanlyphieumuon.TimKiemPhieuMuon(pm);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
            DTO_PhieuMuon pm = new DTO_PhieuMuon();
            pm.sMaPhieuMuon = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString());
            pm.sNgayMuon = DateTime.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString());
            pm.sNgayTra = DateTime.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString());
            pm.sTrangThai = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString();
            pm.sTenDocGia = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString();
            GUI_XemChiTietPhieuMuon form = new GUI_XemChiTietPhieuMuon();
            form.pm = pm;
            form.ShowDialog();
        }
    }
}
