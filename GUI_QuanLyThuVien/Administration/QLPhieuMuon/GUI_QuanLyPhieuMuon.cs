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
using GUI;
using GUI_QuanLyThuVien.Administration.QLPhieuMuon;

namespace GUI_QuanLyThuVien.Administration
{
    public partial class GUI_QuanLyPhieuMuon : Form
    {
        public GUI_QuanLyPhieuMuon()
        {
            InitializeComponent();
        }
        Boolean isListCanhCao = false;
        BLL_QuanLyPhieuMuon bll_quanlyphieumuon = new BLL_QuanLyPhieuMuon();
        string Function;
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            guna2DGV1.ClearSelection();
            guna2DGV1.DataSource = bll_quanlyphieumuon.viewListPM();
        }
        private void GUI_QuanLyPhieuMuon_Load_1(object sender, EventArgs e)
        {
            guna2DGV1.ClearSelection();
            guna2DGV1.DataSource = bll_quanlyphieumuon.viewListPM();
        }     
        private void txtSearchPhieu_KeyDown(object sender, KeyEventArgs e)
        {
            guna2DGV1.ClearSelection();
            DTO_PhieuMuon pm = new DTO_PhieuMuon();
            pm.sMaPhieuMuon = int.TryParse(txtSearchPhieu.Text, out int maPhieu) ? maPhieu : 0;
            pm.sTenDocGia = txtSearchPhieu.Text;
            guna2DGV1.ClearSelection();
            guna2DGV1.DataSource = bll_quanlyphieumuon.TimKiemPhieuMuon(pm);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            isListCanhCao = false;
            guna2DGV1.ClearSelection();
            guna2DGV1.DataSource = bll_quanlyphieumuon.viewListPM();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Function = "Edit";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Function = "Delete";
        }
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Function = "Details";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            isListCanhCao = true;
            guna2DGV1.ClearSelection();
            guna2DGV1.DataSource = bll_quanlyphieumuon.ListCanhCaoQuaHan();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!isListCanhCao)
            {

                if (guna2DGV1 == null || bll_quanlyphieumuon == null || Function == null)
                {
                    MessageBox.Show(
                        "Vui lòng chọn chức năng!", 
                        "Cảnh Báo",                                 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning                      
                    );
                    return;
                }

                if (Function == "Delete")
                {
                    if (e.RowIndex >= 0)
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?",
                                                              "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            DataGridViewRow row = guna2DGV1.Rows[e.RowIndex];
                            int maphieumuon = int.Parse(row.Cells[0].Value?.ToString());
                            guna2DGV1.Rows.RemoveAt(e.RowIndex);
                            //da them phan + so luong sach vao .
                            MessageBox.Show(bll_quanlyphieumuon.XoaPhieuMuon(maphieumuon));        // Xoa sach trong database   
                        }
                    }
                }
                else if (Function == "Edit")
                {

                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa dòng này?",
                                                          "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = guna2DGV1.Rows[e.RowIndex];
                        DTO_PhieuMuon pm = new DTO_PhieuMuon();
                        pm.sMaPhieuMuon = int.Parse(guna2DGV1.Rows[e.RowIndex].Cells[0].Value?.ToString());
                        pm.sNgayMuon = DateTime.Parse(guna2DGV1.Rows[e.RowIndex].Cells[1].Value?.ToString());
                        pm.sNgayTra = DateTime.Parse(guna2DGV1.Rows[e.RowIndex].Cells[2].Value?.ToString());
                        pm.sTrangThai = guna2DGV1.Rows[e.RowIndex].Cells[3].Value?.ToString();
                        pm.sTenDocGia = guna2DGV1.Rows[e.RowIndex].Cells[4].Value?.ToString();
                        GUI_EditPhieuMuon form = new GUI_EditPhieuMuon();
                        form.pm = pm;
                        form.ShowDialog();
                    }
                }
                else if (Function == "Details")
                {
                    DataGridViewRow row = guna2DGV1.Rows[e.RowIndex];
                    DTO_PhieuMuon pm = new DTO_PhieuMuon();
                    pm.sMaPhieuMuon = int.Parse(guna2DGV1.Rows[e.RowIndex].Cells[0].Value?.ToString());
                    pm.sNgayMuon = DateTime.Parse(guna2DGV1.Rows[e.RowIndex].Cells[1].Value?.ToString());
                    pm.sNgayTra = DateTime.Parse(guna2DGV1.Rows[e.RowIndex].Cells[2].Value?.ToString());
                    pm.sTrangThai = guna2DGV1.Rows[e.RowIndex].Cells[3].Value?.ToString();
                    pm.sTenDocGia = guna2DGV1.Rows[e.RowIndex].Cells[4].Value?.ToString();
                    GUI_XemChiTietPM form = new GUI_XemChiTietPM();
                    form.pm = pm;
                    form.ShowDialog();
                }
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            GUI_AddPhieuMuon gUI_AddPhieuMuon = new GUI_AddPhieuMuon();
            gUI_AddPhieuMuon.ShowDialog();

        }
    }
}
