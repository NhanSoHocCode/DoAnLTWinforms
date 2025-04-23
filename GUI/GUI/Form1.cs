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
namespace GUI
{
    public partial class Form1 : Form
    {
        Account Acc = new Account();

        public void login()
        {
            Login form = new Login();
            DialogResult result = form.ShowDialog();
        }
        public Form1()
        {   
            InitializeComponent();
            //login();
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
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void Form1_Load()
        {
            UserControl.UserMenu form = new UserControl.UserMenu(this, "Công Nghệ");
            OpenChildForm(form);
            getAccountData();
        }
        private void getAccountData()
        {
            Acc.Name = "Huy";
            Acc.Birth = "Huy";
            Acc.Gioitinh = "Huy";
            Acc.Pass = "Huy";
            Acc.User = "Huy";
            Acc.Address = "Huy";
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
            UserControl.UserMenu form = new UserControl.UserMenu(this, "Công Nghệ");
            OpenChildForm(form);
        }
        private void btnLife_Click(object sender, EventArgs e)
        {
            UserControl.UserMenu form = new UserControl.UserMenu(this, "Đời Sống");
            OpenChildForm(form);
        }
        private void btnAnimal_Click(object sender, EventArgs e)
        {
            UserControl.UserMenu form = new UserControl.UserMenu(this, "Động Vật");
            OpenChildForm(form);
        }
        private void btnLove_Click(object sender, EventArgs e)
        {
            UserControl.UserMenu form = new UserControl.UserMenu(this, "Tình Yêu");
            OpenChildForm(form);
        }
        private void btnother_Click(object sender, EventArgs e)
        {
            UserControl.UserMenu form = new UserControl.UserMenu(this, "All");
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
            UserControl.UserSetting form = new UserControl.UserSetting(this, Acc);
            OpenChildForm(form);
        }


    }
}
