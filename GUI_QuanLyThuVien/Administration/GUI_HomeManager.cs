using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        public int role = 3;
        public string username = "adm";
        private void GUI_HomeManager_Load_1(object sender, EventArgs e)
        {
            BLL_LayAnhThe bll = new BLL_LayAnhThe();
            lbname.Text = username;
            lbnameRole.Text = "Quản trị viên master";
            string a = bll.LayAnhThe(username);
            string path = a.Contains(":") ? a : "D:\\K25_Project_LTWinform\\DoAn\\images\\" + a;
            pictureBoxAdm.Image = Image.FromFile(path);
            btnSach.Image = new Bitmap(Properties.Resources.book_icon, btnSach.ClientSize.Height - 10, btnSach.ClientSize.Height - 10);
            btnSach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSach.AutoSize = true;
            btnSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnSach.TextAlign = ContentAlignment.MiddleCenter;

            btnpheiumuon.Image = new Bitmap(Properties.Resources.phieuthu_icon, btnpheiumuon.ClientSize.Height - 10, btnpheiumuon.ClientSize.Height - 10);
            btnpheiumuon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnpheiumuon.AutoSize = true;
            btnpheiumuon.ImageAlign = ContentAlignment.MiddleLeft;
            btnpheiumuon.TextAlign = ContentAlignment.MiddleCenter;

            btndocgia.Image = new Bitmap(Properties.Resources.docgia, btndocgia.ClientSize.Height - 10, btndocgia.ClientSize.Height - 10);
            btndocgia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndocgia.AutoSize = true;
            btndocgia.ImageAlign = ContentAlignment.MiddleLeft;
            btndocgia.TextAlign = ContentAlignment.MiddleCenter;

            btnthuthu.Image = new Bitmap(Properties.Resources.book_icon, btnthuthu.ClientSize.Height - 10, btnthuthu.ClientSize.Height - 10);
            btnthuthu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnthuthu.AutoSize = true;
            btnthuthu.ImageAlign = ContentAlignment.MiddleLeft;
            btnthuthu.TextAlign = ContentAlignment.MiddleCenter;
            panel4.MouseDown += PanelTitleBar_MouseDown;
        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0xA1, 0x2, 0); // Gửi lệnh di chuyển cửa sổ
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
            GUI_QuanLyPhieuMuon form = new GUI_QuanLyPhieuMuon();
            OpenChildForm(form, panel3);
            currentFormChild = form;
        }

        private void btndocgia_Click(object sender, EventArgs e)
        {

        }

        private void btnthuthu_Click(object sender, EventArgs e)
        {

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
