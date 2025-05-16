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
using System.Xml.Linq;
using BLL_QuanLyThuVien;
using BLL_QuanLyThuVien.Functions;
using Guna.UI2.WinForms;
using Sunny.UI;

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
        BLL_QuanLyThuThu bll_quanlythuthu = new BLL_QuanLyThuThu();
        void addDislayInfor(string pathIMG, string id, string name, string dob, string gioiTinh, string diachi, string SDT, string email, string username)
        {
            Guna2CirclePictureBox circlePic = new Guna2CirclePictureBox();
            circlePic.Image = Image.FromFile(pathIMG);
            circlePic.Size = new Size(150, 150);
            circlePic.SizeMode = PictureBoxSizeMode.StretchImage;
            circlePic.Location = new Point(400, 10);
            panelInfor.Controls.Add(circlePic);

            Label lbID = new Label();
            if (role == 2)
                lbID.Text = "Mã Thủ thư: ";
            else
                lbID.Text = "Mã Quản trị viên: ";
            lbID.ForeColor = Color.Black;
            lbID.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            //lbID.BackColor = Color.Transparent;
            lbID.Location = new Point(300, 170); // đặt vị trí rõ ràng
            lbID.Size = new Size(200, 50);
            panelInfor.Controls.Add(lbID);

            Label lbidthat = new Label();
            lbidthat.Text = $"{id}";
            lbidthat.ForeColor = Color.Black;
            lbidthat.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lbidthat.Size = new Size(200, 50);
            //lbidthat.BackColor = Color.Transparent;
            lbidthat.Location = new Point(550, 170); // đặt vị trí rõ ràng
            panelInfor.Controls.Add(lbidthat);

            Label lbName = new Label();
            lbName.Text = "Họ Và Tên: ";
            lbName.ForeColor = Color.Black;
            lbName.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            //lbName.BackColor = Color.Transparent;
            lbName.Location = new Point(300, 220); // đặt vị trí rõ ràng
            lbName.Size = new Size(200, 50);
            panelInfor.Controls.Add(lbName);

            Label lbNameR = new Label();
            lbNameR.Text = $"{name}";
            lbNameR.ForeColor = Color.Black;
            lbNameR.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            //lbNameR.BackColor = Color.Transparent;
            lbNameR.Location = new Point(550, 220); // đặt vị trí rõ ràng
            lbNameR.Size = new Size(200, 50);
            panelInfor.Controls.Add(lbNameR);

            Label DOB = new Label();
            DOB.Text = "Ngày Sinh: ";
            DOB.ForeColor = Color.Black;
            DOB.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            //DOB.BackColor = Color.Transparent;
            DOB.Location = new Point(300, 270); // đặt vị trí rõ ràng
            DOB.Size = new Size(200, 50);
            panelInfor.Controls.Add(DOB);

            Label DOBR = new Label();
            DOBR.Text = $"{dob}";
            DOBR.ForeColor = Color.Black;
            DOBR.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            //DOBR.BackColor = Color.Transparent;
            DOBR.Location = new Point(550, 270); // đặt vị trí rõ ràng
            DOBR.Size = new Size(500, 50);
            panelInfor.Controls.Add(DOBR);


            Label lbgiotinh = new Label();
            lbgiotinh.Text = "Giới Tính: ";
            lbgiotinh.ForeColor = Color.Black;
            lbgiotinh.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            //lbgiotinh.BackColor = Color.Transparent;
            lbgiotinh.Location = new Point(300, 320); // đặt vị trí rõ ràng
            lbgiotinh.Size = new Size(200, 50);
            panelInfor.Controls.Add(lbgiotinh);

            Label lbgiotinhR = new Label();
            lbgiotinhR.Text = $"{gioiTinh}";
            lbgiotinhR.ForeColor = Color.Black;
            lbgiotinhR.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            //DOBR.BackColor = Color.Transparent;
            lbgiotinhR.Location = new Point(550, 320); // đặt vị trí rõ ràng
            lbgiotinhR.Size = new Size(500, 50);
            panelInfor.Controls.Add(lbgiotinhR);



            Label lbDiaChi = new Label();
            lbDiaChi.Text = "Địa Chỉ: ";
            lbDiaChi.ForeColor = Color.Black;
            lbDiaChi.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            //lbDiaChi.BackColor = Color.Transparent;
            lbDiaChi.Location = new Point(300, 370); // đặt vị trí rõ ràng
            lbDiaChi.Size = new Size(200, 50);
            panelInfor.Controls.Add(lbDiaChi);

            Label lbDiaChiR = new Label();
            lbDiaChiR.Text = $"{diachi}";
            lbDiaChiR.ForeColor = Color.Black;
            lbDiaChiR.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            //DOBR.BackColor = Color.Transparent;
            lbDiaChiR.Location = new Point(550, 370); // đặt vị trí rõ ràng
            lbDiaChiR.Size = new Size(500, 50);
            panelInfor.Controls.Add(lbDiaChiR);


            Label lbSDT = new Label();
            lbSDT.Text = "Số điện thoại: ";
            lbSDT.ForeColor = Color.Black;
            lbSDT.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            //lbSDT.BackColor = Color.Transparent;
            lbSDT.Location = new Point(300, 420); // đặt vị trí rõ ràng
            lbSDT.Size = new Size(200, 50);
            panelInfor.Controls.Add(lbSDT);

            Label lbSDTR = new Label();
            lbSDTR.Text = $"{SDT}";
            lbSDTR.ForeColor = Color.Black;
            lbSDTR.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            //DOBR.BackColor = Color.Transparent;
            lbSDTR.Location = new Point(550, 420); // đặt vị trí rõ ràng
            lbSDTR.Size = new Size(200, 50);
            panelInfor.Controls.Add(lbSDTR);


            //Label lbEmail = new Label();
            //lbEmail.Text = "Email: ";
            //lbEmail.ForeColor = Color.Black;
            //lbEmail.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            ////lbEmail.BackColor = Color.Transparent;
            //lbEmail.Location = new Point(300, 470); // đặt vị trí rõ ràng
            //lbEmail.Size = new Size(500, 50);
            //panelInfor.Controls.Add(lbEmail);

            //Label lbEmailR = new Label();
            //lbEmailR.Text = $"{email}";
            //lbEmailR.ForeColor = Color.Black;
            //lbEmailR.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            //lbEmailR.BackColor = Color.Transparent;
            //lbEmailR.Location = new Point(550, 470); // đặt vị trí rõ ràng
            //lbEmailR.Size = new Size(500, 50);
            //panelInfor.Controls.Add(lbEmailR);


            Label lbuserName = new Label();
            lbuserName.Text = "Username: ";
            lbuserName.ForeColor = Color.Black;
            lbuserName.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            //lbuserName.BackColor = Color.Transparent;
            lbuserName.Location = new Point(300, 520); // đặt vị trí rõ ràng
            lbuserName.Size = new Size(200, 50);
            panelInfor.Controls.Add(lbuserName);

            Label lbuserNameR = new Label();
            lbuserNameR.Text = $"{username}";
            lbuserNameR.ForeColor = Color.Black;
            lbuserNameR.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            //DOBR.BackColor = Color.Transparent;
            lbuserNameR.Location = new Point(550, 520); // đặt vị trí rõ ràng
            lbuserNameR.Size = new Size(500, 50);
            panelInfor.Controls.Add(lbuserNameR);
        }
        private void GUI_HomeManager_Load_1(object sender, EventArgs e)
        {
            lbName.Text = "Xin chào '" + username + "' đến với hệ thống";
            BLL_LayAnhThe bll = new BLL_LayAnhThe();
            guna2DGV1.DataSource = BLL_TaiKhoan.viewlistTimeLogin();

            GUI_QuanLySach formSach = new GUI_QuanLySach();
            OpenChildForm(formSach, panelSach, currentFormChild);
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
                HideTabPage1(tabPageDocGia);
            }
            DataTable dt = bll_quanlythuthu.SearchThuThuToUsername(username);
            foreach (DataRow dr in dt.Rows)
            {
                string anhthe = dr["anhThe"].ToString();
                string path = Path.Combine("D:\\K25_Project_LTWinform\\DoAn\\images\\ThuThu", anhthe);
                string id = dr["maThuThu"].ToString();
                string name = dr["username"].ToString();
                string dob = Convert.ToDateTime(dr["ngaySinh"]).ToString("dd/MM/yyyy");
                string gioiTinh;
                if (dr["gioiTinh"].ToString() == "True")
                {
                    gioiTinh = "Nam";
                }
                else
                {
                    gioiTinh = "Nữ";
                }
                //string gioiTinh = dr["gioiTinh"].ToString();
                string diachi = dr["diaChi"].ToString();
                string SDT = dr["soDienThoai"].ToString();
                string email = dr["email"].ToString();
                string username1 = dr["username"].ToString();
                addDislayInfor(path, id, name, dob, gioiTinh, diachi, SDT, email, username1);
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

        private void btnSort_Click(object sender, EventArgs e)
        {
            guna2DGV1.Sort(guna2DGV1.Columns["Thời gian login gần đây"], ListSortDirection.Descending);

        }

        private void panelSach_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DGV1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
