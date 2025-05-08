using BLL_QuanLyThuVien;
using DTO_QuanLyThuVien;
using GUI;
using GUI.UserControl;
using Guna.UI2.WinForms;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_QuanLyThuVien.Administration.QLPhieuMuon
{
    public partial class GUI_AddPhieuMuon : Form
    {
        public GUI_AddPhieuMuon()
        {
            InitializeComponent();
        }
        BLL_QuanLyDocGia bll_quanlydocgia = new BLL_QuanLyDocGia();
        private void GUI_AddPhieuMuon_Load(object sender, EventArgs e)
        {
            DataTable dt = bll_quanlydocgia.ListMaDocGia();
            if (dt != null && dt.Rows.Count > 0)
            {
                cbbMaDG.DataSource = dt;
                cbbMaDG.DisplayMember = "maDocGia";  
                cbbMaDG.ValueMember = "maDocGia";    
            }
            else
            {
                MessageBox.Show("Không có dữ liệu độc giả.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnChonSach_Click(object sender, EventArgs e)
        {
            // mo lit sach 
            GUI_ShowBook gUI_ShowBook = new GUI_ShowBook();
            if (cbbMaDG.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã độc giả!", "Cảnh cáo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gUI_ShowBook.MaDG = int.Parse(cbbMaDG.Text);
            gUI_ShowBook.ShowDialog();

        }
        BLL_QuanLyPhieuMuon bllpm = new BLL_QuanLyPhieuMuon();

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn lập phiếu!",
                "Xác nhận?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
             );
            if (result == DialogResult.Yes)
            {
                //// Xử lý khi người dùng chọn Yes
                //DTO_PhieuMuon pm = new DTO_PhieuMuon();
                //pm.sMaDocGia = int.Parse(cbbMaDG.Text);
                ////pm.sNgayTra = dtp2.Value;
                //int maPMnew = bllpm.CreatePMtoDocGia(pm);
                //bllpm.ThemSachVaoPhieuMuonV3(maPMnew, int.Parse(cbbMaDG.Text));
                //MessageBox.Show($"Phiếu có mã {maPMnew} lập thành công", "Thông báo");
                ////bllpm.DelBookToCartOnDocGia(int.Parse(cbbMaDG.Text));
                DTO_Person person = new DTO_Person();
                BLL_QuanLyDocGia bllqldg = new BLL_QuanLyDocGia();
                DataTable dt = bllqldg.SearchDocGia(cbbMaDG.Text);
                foreach (DataRow dr in dt.Rows)
                {
                    person.sMa = dr["maDocGia"].ToString();
                    person.sHoTen = dr["hoTen"].ToString();
                    person.sGioiTinh = Boolean.Parse(dr["gioiTinh"].ToString());
                    person.sSDT = dr["soDienThoai"].ToString();
                    person.sEmail = dr["email"].ToString();
                    person.sDiaChi = dr["diaChi"].ToString();
                    person.sSourceImage = dr["anhThe"].ToString();
                    person.sUsername = dr["username"].ToString();
                    person.sPassword = dr["password"].ToString();
                    person.sNgaySinh = DateTime.Parse(dr["ngaySinh"].ToString());
                }
                Form1 formCustomer = new Form1();
                formCustomer.person = person;
                formCustomer.Show();
            }
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
