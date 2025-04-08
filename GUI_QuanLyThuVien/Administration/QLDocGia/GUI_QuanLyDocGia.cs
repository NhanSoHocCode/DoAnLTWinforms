using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_QuanLyThuVien;
using DTO_QuanLyThuVien;
namespace GUI_QuanLyThuVien.Administration
{
    public partial class GUI_QuanLyDocGia : Form
    {
        public GUI_QuanLyDocGia()
        {
            InitializeComponent();
        }
        BLL_QuanLyDocGia bll_QuanLyDocGia = new BLL_QuanLyDocGia();
        public void LoadListDG(DataTable dt)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PersonItem personItem = new PersonItem();
                personItem.DocGia = true;
                personItem.person = new DTO_Person
                {
                    sHoTen = dt.Rows[i]["hoTen"].ToString(),
                    sGioiTinh = Convert.ToBoolean(dt.Rows[i]["gioiTinh"]),
                    sMa = dt.Rows[i]["maDocGia"].ToString(),
                    sSourceImage = dt.Rows[i]["anhthe"].ToString(),
                    sDiaChi = dt.Rows[i]["diaChi"].ToString(),
                    sSDT = dt.Rows[i]["soDienThoai"].ToString(),
                    sEmail = dt.Rows[i]["email"].ToString(),
                    sUsername = dt.Rows[i]["username"].ToString(),
                    sNgaySinh = Convert.ToDateTime(dt.Rows[i]["ngaySinh"])
                };
                flowLayoutPanel1.Controls.Add(personItem);
            }
        }
        public void LoadListDocGia()
        {
            DataTable dt = bll_QuanLyDocGia.ViewDocGia();
            LoadListDG(dt);
        } 

        private void GUI_QuanLyDocGia_Load(object sender, EventArgs e)
        {
            LoadListDocGia();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadListDocGia();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadListDocGia();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // them doc gia 
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bll_QuanLyDocGia.SearchDocGia(txtSearch.Text);
            LoadListDG(dt);
        }
    
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadListDocGia();
        }
    }
}
