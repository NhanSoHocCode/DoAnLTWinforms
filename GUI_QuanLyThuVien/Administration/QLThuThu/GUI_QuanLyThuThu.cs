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
using GUI_QuanLyThuVien.Administration.QLDocGia;
using GUI_QuanLyThuVien.Administration.QLThuThu;
namespace GUI_QuanLyThuVien.Administration
{
    public partial class GUI_QuanLyThuThu : Form
    {
        public GUI_QuanLyThuThu()
        {
            InitializeComponent();
        }
        BLL_QuanLyThuThu bll_quanlythuthu = new BLL_QuanLyThuThu();
//sdsadasdasdasdasdasdsdasd
        public void LoadListTT(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PersonItem personItem = new PersonItem();
                personItem.DocGia = false;
                personItem.person = new DTO_Person
                {
                    sHoTen = dt.Rows[i]["tenThuTHu"].ToString(),
                    sGioiTinh = Convert.ToBoolean(dt.Rows[i]["gioiTinh"]),
                    sMa = dt.Rows[i]["maThuThu"].ToString(),
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

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bll_quanlythuthu.ListThuThu();
            LoadListTT(dt);
        }

        private void btnListTT_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bll_quanlythuthu.ListThuThu();
            flowLayoutPanel1.Controls.Clear();
            LoadListTT(dt);
        }

        private void btnaddtt_Click(object sender, EventArgs e)
        {
            GUI_AddThuThu addTT = new GUI_AddThuThu();
            addTT.Show();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bll_quanlythuthu.SearchThuThu(txtSearch.Text);
            flowLayoutPanel1.Controls.Clear();
            LoadListTT(dt);
        }

        private void btnListTT_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bll_quanlythuthu.ListThuThu();
            flowLayoutPanel1.Controls.Clear();
            LoadListTT(dt);
        }

        private void btnaddtt_Click_1(object sender, EventArgs e)
        {
            GUI_AddThuThu addTT = new GUI_AddThuThu();
            addTT.Show();
        }
    }
}
