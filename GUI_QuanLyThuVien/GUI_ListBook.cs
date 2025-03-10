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

namespace GUI_QuanLyThuVien
{
    public partial class GUI_ListBook : Form
    {
        public GUI_ListBook()
        {
            InitializeComponent();
            LoadBooks("Tình Yêu"); 
        }
        private BLL_QuanLySach bll = new BLL_QuanLySach();
        private void LoadBooks(string theloai)
        {
            DataTable dt = bll.XemDanhSachToanBoSach();

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["theloai"].ToString() == theloai)
                {
                    BookItem bookItem = new BookItem();
                    bookItem.book.sTenSach = dr["tensach"].ToString();
                    bookItem.book.sSoLuong = int.Parse(dr["soluong"].ToString());
                    bookItem.book.sSourceImange = dr["source_image"].ToString();
                    bookItem.LoadBook();
                    flpListBook.Controls.Add(bookItem);
                }
            }

        }

        private void btnTinhYeu_Click(object sender, EventArgs e)
        {
            flpListBook.Controls.Clear();
            LoadBooks("Tình Yêu");
        }

        private void btnDongVat_Click(object sender, EventArgs e)
        {
            flpListBook.Controls.Clear();
            LoadBooks("Động Vật");
        }

        private void btnCongNghe_Click(object sender, EventArgs e)
        {
            flpListBook.Controls.Clear();
            LoadBooks("Công Nghệ");
        }

        private void btnDoiSong_Click(object sender, EventArgs e)
        {
            flpListBook.Controls.Clear();
            LoadBooks("Đời Sống");
        }
    }
}
