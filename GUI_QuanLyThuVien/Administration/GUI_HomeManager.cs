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
        public GUI_HomeManager()
        {
            InitializeComponent();
            guna2DragControl1.TargetControl = guna2Panel1;
        }
        public int role = 3;
        public string username = "adm";
        private Form currentFormChild;
        private Form currentFormChild1;
        private Form currentFormChild2;
        private Form currentFormChild3;
        private void GUI_HomeManager_Load_1(object sender, EventArgs e)
        {
            BLL_LayAnhThe bll = new BLL_LayAnhThe();
            lbname.Text = username;
            lbnameRole.Text = "Quản trị viên master";
            string a = bll.LayAnhThe(username);
            string path = a.Contains(":") ? a : Path.Combine(@"D:\K25_Project_LTWinform\DoAn\images\", a);
            //pictureBoxAdm.Image = Image.FromFile(path);
            guna2CirclePictureBoxAdm.Image = Image.FromFile(path);
            //guna2CirclePictureBoxAdm.SizeMode = PictureBoxSizeMode.StretchImage;
            //guna2CirclePictureBoxAdm.ShadowDecoration.Mode = ShadowMode.Circle;
            //guna2CirclePictureBoxAdm.BorderThickness = 2;
            //guna2CirclePictureBoxAdm.BorderColor = Color.DeepSkyBlue;
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
