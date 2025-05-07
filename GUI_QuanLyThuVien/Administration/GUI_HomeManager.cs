using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_QuanLyThuVien;
using BLL_QuanLyThuVien.Functions;
using Guna.UI2.WinForms;

namespace GUI_QuanLyThuVien.Administration
{
    public partial class GUI_HomeManager : Form
    {
        public int role;
        public GUI_HomeManager(int quyen)
        {
            role = quyen;
            InitializeComponent();
            guna2DragControl1.TargetControl = guna2Panel1;
            guna2DGV1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DGV1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DGV1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // hoặc Fill


        }
        public string username = "adm";
        private Form currentFormChild;
        private Form currentFormChild1;
        private Form currentFormChild2;
        private Form currentFormChild3;
        private void GUI_HomeManager_Load_1(object sender, EventArgs e)
        {
            BLL_LayAnhThe bll = new BLL_LayAnhThe();
            lbname.Text = username;
            guna2DGV1.DataSource = BLL_TaiKhoan.viewlistTimeLogin();
            lbnameRole.Text = "Quản trị viên master";
            string a = bll.LayAnhThe(username);
            string path = a.Contains(":") ? a : Path.Combine(@"D:\K25_Project_LTWinform\DoAn\images\", a);
            
            guna2CirclePictureBoxAdm.Image = Image.FromFile(path);
            GUI_QuanLySach formSach = new GUI_QuanLySach();
            OpenChildForm(formSach, panelSach,currentFormChild);
            currentFormChild = formSach;

            GUI_QuanLyPhieuMuon formPhieuMuon = new GUI_QuanLyPhieuMuon();
            OpenChildForm(formPhieuMuon, panelPhieuMuon, currentFormChild1);
            currentFormChild = formPhieuMuon;

            GUI_QuanLyDocGia formDocGia = new GUI_QuanLyDocGia();
            OpenChildForm(formDocGia, panelDocGia, currentFormChild2);
            currentFormChild = formDocGia;

            GUI_QuanLyThuThu formThuThu = new GUI_QuanLyThuThu();
            OpenChildForm(formThuThu, panelThuThu, currentFormChild3);
            currentFormChild = formThuThu;
            if (role == 2)
            {
                HideTabPage1(tabPage1);
                //HideTabPage1(tabAdmin);
                HideTabPage1(tabPageThuThu);
            }
        }
        private void HideTabPage1(TabPage tabPage)
        {
            TabPage tabPage1Backup;

            if (guna2TabControlMain.TabPages.Contains(tabPage))
            {
                tabPage1Backup = tabPage;

                guna2TabControlMain.TabPages.Remove(tabPage);
            }
        }


        private void OpenChildForm(Form childForm, Panel pl, Form currentFormChild)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            pl.Controls.Add(childForm);
            pl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }
        BLL_TaiKhoan BLL_TaiKhoan = new BLL_TaiKhoan();
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            guna2DGV1.DataSource = BLL_TaiKhoan.viewlistTimeLogin();
        }

        private void txtSearchPhieu_KeyDown(object sender, KeyEventArgs e)
        {
            guna2DGV1.DataSource = null;
            guna2DGV1.DataSource = BLL_TaiKhoan.searchTimeLogin(txtSearchPhieu.Text);
            if (guna2DGV1.Rows.Count == 0)
            {
                guna2DGV1.DataSource = BLL_TaiKhoan.viewlistTimeLogin();
            }
        }
        //private void btnClose_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}



        //private void buttonClose_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}


    }
}
