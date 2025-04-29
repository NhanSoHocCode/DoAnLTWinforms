using GUI.UserControl;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using System.Threading;
using DTO_QuanLyThuVien;
using System.Web.UI.WebControls;
namespace GUI
{
    public partial class Form1 : Form
    {
        public DTO_Person person = new DTO_Person();

        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PaneMain.Controls.Add(childForm);
            PaneMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void Form1_Load()
        {
            UserControl.UserMenu form = new UserControl.UserMenu(this, "Công Nghệ", person);
            OpenChildForm(form);
        }
        private void PaneMain_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            Form1_Load();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1_Load();
        }
        private void btnTech_Click(object sender, EventArgs e)
        {
            UserControl.UserMenu form = new UserControl.UserMenu(this, "Công Nghệ", person);
            OpenChildForm(form);
        }
        private void btnLife_Click(object sender, EventArgs e)
        {
            UserControl.UserMenu form = new UserControl.UserMenu(this, "Đời Sống", person);
            OpenChildForm(form);
        }
        private void btnAnimal_Click(object sender, EventArgs e)
        {
            UserControl.UserMenu form = new UserControl.UserMenu(this, "Động Vật", person);
            OpenChildForm(form);
        }
        private void btnLove_Click(object sender, EventArgs e)
        {
            UserControl.UserMenu form = new UserControl.UserMenu(this, "Tình Yêu", person);
            OpenChildForm(form);
        }
        private void btnother_Click(object sender, EventArgs e)
        {
            UserControl.UserMenu form = new UserControl.UserMenu(this, "All", person);
            OpenChildForm(form);
        }

        public void giohang(DTO_Person person)
        {
            UserControl.UserStore form = new UserControl.UserStore(this, "GioHang");
            form.person = person;
            OpenChildForm(form);
        }
        private void sataButton6_Click(object sender, EventArgs e)
        {
            UserControl.UserSetting form = new UserControl.UserSetting(this, person);
            OpenChildForm(form);
        }


    }
}
