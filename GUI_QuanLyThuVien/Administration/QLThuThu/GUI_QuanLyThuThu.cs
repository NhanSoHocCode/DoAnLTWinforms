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
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                string imagePath = "D:\\K25_Project_LTWinform\\DoAn\\images\\ThuThu\\" + dt.Rows[i]["anhthe"].ToString();
                string IDDocGia = dt.Rows[i]["maThuThu"].ToString();
                string name = dt.Rows[i]["username"].ToString();
                string email = dt.Rows[i]["email"].ToString();
                string phone = dt.Rows[i]["soDienThoai"].ToString();
                string diaChi = dt.Rows[i]["diaChi"].ToString();
                string fullName = dt.Rows[i]["tenThuTHu"].ToString();
                string DOB = Convert.ToDateTime(dt.Rows[i]["ngaySinh"]).ToString("dd/MM/yyyy");

                string gioiTinh = dt.Rows[i]["gioiTinh"].ToString();

                AddBookToPanel(imagePath, IDDocGia, name, email, phone, diaChi, fullName, DOB, gioiTinh);

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
        private void AddBookToPanel(string imagePath, string IDDocGia, string name, string email, string phone, string diaChi, string fullName, string DOB, string gioiTinh)
        {

            Panel bookPanel = new Panel();
            bookPanel.Size = new Size(225, 350);

            // Thêm ảnh sách
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(imagePath);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(120, 150);
            pictureBox.Location = new Point(30, 20);




            Label lbid = new Label { Text = "Mã Thủ Thư: " + IDDocGia, Location = new Point(10, 2), AutoSize = true };

            Label lbuserName = new Label { Text = "Tên Thủ Thư: " + name, Location = new Point(10, 185), AutoSize = true };
            Label lbFullName = new Label { Text = "Họ Và Tên: " + fullName, Location = new Point(10, 205), AutoSize = true };
            Label lblEmail = new Label { Text = "Email: " + email, Location = new Point(10, 225), AutoSize = true };
            Label lblSDT = new Label { Text = "SĐT: " + phone, Location = new Point(10, 245), AutoSize = true };
            Label lbLocation = new Label { Text = "Địa Chỉ: " + diaChi, Location = new Point(10, 265), AutoSize = true };
            Label lbDOB = new Label { Text = "Ngày Sinh: " + DOB, Location = new Point(10, 285), AutoSize = true };

            // Thêm các control vào panel sách
            bookPanel.Controls.Add(pictureBox);
            bookPanel.Controls.Add(lbid);
            bookPanel.Controls.Add(lbuserName);
            bookPanel.Controls.Add(lbFullName);
            bookPanel.Controls.Add(lblEmail);
            bookPanel.Controls.Add(lblSDT);
            bookPanel.Controls.Add(lbLocation);
            bookPanel.Controls.Add(lbDOB);

            // Thêm vào FlowLayoutPanel chính
            flowLayoutPanel1.Controls.Add(bookPanel);
        }
    }
}
