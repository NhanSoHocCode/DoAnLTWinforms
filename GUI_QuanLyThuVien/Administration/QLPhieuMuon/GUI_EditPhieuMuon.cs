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
            lbMaDG.Text = pm.sTenDocGia.ToString();
            lbmaPM.Text = pm.sMaPhieuMuon.ToString();
            lbMaTT.Text = pm.sTenThuThu.ToString();
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
    }
}
