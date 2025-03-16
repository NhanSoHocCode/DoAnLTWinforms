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
using BLL_QuanLyThuVien.Functions;

namespace GUI_QuanLyThuVien.Administration
{
    public partial class GUI_HomeManager : Form
    {
        public GUI_HomeManager()
        {
            InitializeComponent();
        }
        public int role;
        public string username;
        private void GUI_HomeManager_Load_1(object sender, EventArgs e)
        {
            BLL_LayAnhThe bll = new BLL_LayAnhThe();
            lbname.Text = username;
            lbnameRole.Text = "Quản trị viên master";
            string a = bll.LayAnhThe(username);
            string path = a.Contains(":") ? a : "D:\\K25_Project_LTWinform\\DoAn\\images\\" + a;
            pictureBoxAdm.Image = Image.FromFile(path);
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm, Panel pl)
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

        private void btnSach_Click(object sender, EventArgs e)
        {
            GUI_QuanLySach form = new GUI_QuanLySach();
            OpenChildForm(form, panel3);
            currentFormChild = form;
        }

        private void btnpheiumuon_Click(object sender, EventArgs e)
        {

        }

        private void btndocgia_Click(object sender, EventArgs e)
        {

        }

        private void btnthuthu_Click(object sender, EventArgs e)
        {

        }
    }
}
