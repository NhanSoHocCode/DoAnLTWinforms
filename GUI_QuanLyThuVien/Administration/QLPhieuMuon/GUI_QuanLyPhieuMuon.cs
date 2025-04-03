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
using DTO_QuanLyThuVien;

namespace GUI_QuanLyThuVien.Administration
{
    public partial class GUI_QuanLyPhieuMuon : Form
    {
        public GUI_QuanLyPhieuMuon()
        {
            InitializeComponent();
        }
        BLL_QuanLyPhieuMuon bll_quanlyphieumuon = new BLL_QuanLyPhieuMuon();
        string Function;
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            dtg1.ClearSelection();
            dtg1.DataSource = bll_quanlyphieumuon.viewListPM();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Function = "Edit";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            Function = "Delete";
        }

        private void txtSearchPhieu_KeyDown(object sender, KeyEventArgs e)
        {
            dtg1.ClearSelection();
            DTO_PhieuMuon pm = new DTO_PhieuMuon();
            pm.sMaPhieuMuon = int.TryParse(txtSearchPhieu.Text, out int maPhieu) ? maPhieu : 0;
            pm.sTenDocGia = txtSearchPhieu.Text;
            dtg1.DataSource = bll_quanlyphieumuon.TimKiemPhieuMuon(pm);
        }

        private void GUI_QuanLyPhieuMuon_Load_1(object sender, EventArgs e)
        {
            dtg1.ClearSelection();
            dtg1.DataSource = bll_quanlyphieumuon.viewListPM();
        }

        private void dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg1 == null || bll_quanlyphieumuon == null || Function == null)
            {
                MessageBox.Show("Vui lòng chọn chức năng!");
                return;
            }

            if (Function == "Delete")
            {
                if (e.RowIndex >= 0) 
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?",
                                                          "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = dtg1.Rows[e.RowIndex];
                        int maphieumuon = int.Parse(row.Cells[0].Value?.ToString());
                        dtg1.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show(bll_quanlyphieumuon.XoaPhieuMuon(maphieumuon));        // Xoa sach trong database   
                    }
                }
            }
            else if (Function == "Edit")
            {

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa dòng này?",
                                                      "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dtg1.Rows[e.RowIndex];
                    DTO_PhieuMuon pm = new DTO_PhieuMuon();
                    pm.sMaPhieuMuon = int.Parse(dtg1.Rows[e.RowIndex].Cells[0].Value?.ToString());
                    pm.sNgayMuon = DateTime.Parse(dtg1.Rows[e.RowIndex].Cells[1].Value?.ToString());
                    pm.sNgayTra = DateTime.Parse(dtg1.Rows[e.RowIndex].Cells[2].Value?.ToString());  
                    pm.sTrangThai = dtg1.Rows[e.RowIndex].Cells[3].Value?.ToString();
                    pm.sTenDocGia = dtg1.Rows[e.RowIndex].Cells[4].Value?.ToString();
                    pm.sTenThuThu = dtg1.Rows[e.RowIndex].Cells[5].Value?.ToString();
                    GUI_EditPhieuMuon form = new GUI_EditPhieuMuon();
                    form.pm = pm;
                    form.Show();
                }
            }
        }

        private void btnListCanhCaoQuaHan_Click(object sender, EventArgs e)
        {
            dtg1.ClearSelection();
            dtg1.DataSource = bll_quanlyphieumuon.ListCanhCaoQuaHan();
        }

        private void dtg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchPhieu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
