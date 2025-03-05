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
    public partial class GUI_QuanLySach : Form
    {
        public GUI_QuanLySach()
        {
            InitializeComponent();
        }

        private void GUI_QuanLySach_Load(object sender, EventArgs e)
        {
            BLL_QuanLySach bll_QuanLySach = new BLL_QuanLySach();
            dgvListBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListBook.DataSource = bll_QuanLySach.XemDanhSachToanBoSach();
        }
    }
}
