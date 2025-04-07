using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLyThuVien;
namespace GUI_QuanLyThuVien
{
    public partial class GUI_XemChiTietSach : Form
    {
        public GUI_XemChiTietSach()
        {
            InitializeComponent();
        }
        public string MaSach { get; set; }
        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            DTO_Sach sach = new DTO_Sach();
            sach.sMaSach = MaSach;
            BienToanCuc.BookList.Add(sach); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
