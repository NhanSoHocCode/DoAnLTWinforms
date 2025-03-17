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
using BLL_QuanLyThuVien;
using System.Net;
using System.Diagnostics.Tracing;
using System.IO;


namespace GUI_QuanLyThuVien
{
    public partial class BookItem : UserControl
    {
        public BookItem()
        {
            InitializeComponent();
        }
        public DTO_Sach book = new DTO_Sach();

        public void LoadBook()
        {
            lbname.Text = book.sTenSach;
            lbquantity.Text = book.sSoLuong.ToString();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string path = "D:\\K25_Project_LTWinform\\DoAn\\images\\" + book.sSourceImange;
            ptbImage.Image = Image.FromFile(path);
        }

        private void ptbImage_Click(object sender, EventArgs e)
        {
            GUI_XemChiTietSach xemChiTietSach = new GUI_XemChiTietSach();
            xemChiTietSach.MaSach = book.sTenSach;
            xemChiTietSach.Show();
        }
    }
}
