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

namespace GUI_QuanLyThuVien.Administration
{
    public partial class GUI_EditPhieuMuon : Form
    {
        public GUI_EditPhieuMuon()
        {
            InitializeComponent();
        }
        public DTO_PhieuMuon pm = new DTO_PhieuMuon();
        BLL_QuanLyPhieuMuon bll_QuanLyPhieuMuon = new BLL_QuanLyPhieuMuon();

        private void GUI_EditPhieuMuon_Load(object sender, EventArgs e)
        {
            lbMaDG.Text = pm.sTenDocGia;
            label1.Text = pm.sMaPhieuMuon.ToString();
            dtp1.Value = pm.sNgayMuon;
            dtp2.Value = pm.sNgayTra;
            cbbTT.Text = pm.sTrangThai;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            pm.sNgayMuon = dtp1.Value;
            pm.sNgayTra = dtp2.Value;
            pm.sTrangThai = cbbTT.Text;
            MessageBox.Show(bll_QuanLyPhieuMuon.ChinhSuaPhieuMuon(pm));
            Close();
        }

        private void lbmaPM_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnOK1_Click(object sender, EventArgs e)
        {
            pm.sNgayMuon = dtp1.Value;
            pm.sNgayTra = dtp2.Value;
            pm.sTrangThai = cbbTT.Text;
            MessageBox.Show(bll_QuanLyPhieuMuon.ChinhSuaPhieuMuon(pm));
            Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
