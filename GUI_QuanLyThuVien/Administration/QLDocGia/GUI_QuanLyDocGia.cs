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
using GUI_QuanLyThuVien.Administration.QLDocGia;
using GUI_QuanLyThuVien.User;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
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

                string imagePath = "D:\\K25_Project_LTWinform\\DoAn\\images\\DocGia\\" + dt.Rows[i]["anhThe"].ToString();
        
                string IDDocGia = dt.Rows[i]["maDocGia"].ToString();
                string name = dt.Rows [i]["username"].ToString();
                string email = dt.Rows[i]["email"].ToString();
                string phone = dt.Rows[i]["soDienThoai"].ToString();
                string diaChi = dt.Rows[i]["diaChi"].ToString();
                string fullName = dt.Rows[i]["hoTen"].ToString();
                string DOB = Convert.ToDateTime(dt.Rows[i]["ngaySinh"]).ToString("dd/MM/yyyy");
                string gioiTinh = "Nữ";
                string password = dt.Rows[i]["password"].ToString();
                if (dt.Rows[i]["gioiTinh"].ToString() == "True")
                {
                    gioiTinh = "Nam";
                }
                AddDocGiaToPanel(imagePath, IDDocGia, name, email, phone, diaChi, fullName, DOB, gioiTinh, password);
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
        private void AddDocGiaToPanel(string imagePath, string IDDocGia, string name, string email, string phone, string diaChi, string fullName, string DOB, string gioiTinh, string password)
        {

            var sataPanel = new SATAUiFramework.SATAPanel();
            sataPanel.Size = new Size(350, 170);
            sataPanel.BackColor = Color.RosyBrown;
            sataPanel.BackColor2 = Color.RosyBrown;
            sataPanel.Margin = new Padding(10);
            sataPanel.BorderRadius = new SATAUiFramework.BorderRadius()
            {
                TopLeft = 15,
                TopRight = 15,
                BottomLeft = 15,
                BottomRight = 15
            };

            // Hình đại diện
            PictureBox avatar = new PictureBox();
            try
            {
                avatar.Image = Image.FromFile(imagePath);
            }
            catch (Exception)
            {
                // Nếu không tìm thấy ảnh, có thể sử dụng ảnh mặc định hoặc xử lý theo cách khác
                avatar.Image = Image.FromFile("D:\\K25_Project_LTWinform\\DoAn\\images\\clone.jpg");
            }
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            avatar.Size = new Size(100, 130);
            avatar.Location = new Point(10, 10);
            sataPanel.Controls.Add(avatar);

            int left = 120;

            // Label: Họ tên
            Label lblName = new Label();
            lblName.Text = "Họ tên: " + fullName;
            lblName.ForeColor = Color.White;
            lblName.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblName.BackColor = Color.Transparent;
            lblName.Location = new Point(left, 10);
            lblName.Size = new Size(220, 20);
            sataPanel.Controls.Add(lblName);

            // Email
            Label lblEmail = new Label();
            lblEmail.Text = "Email: " + email;
            lblEmail.ForeColor = Color.White;
            lblEmail.Font = new Font("Segoe UI", 9);
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Location = new Point(left, 35);
            lblEmail.Size = new Size(220, 20);
            sataPanel.Controls.Add(lblEmail);

            // SĐT
            Label lblPhone = new Label();
            lblPhone.Text = "SĐT: " + phone;
            lblPhone.ForeColor = Color.White;
            lblPhone.Font = new Font("Segoe UI", 9);
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Location = new Point(left, 55);
            lblPhone.Size = new Size(220, 20);
            sataPanel.Controls.Add(lblPhone);

            // Địa chỉ
            Label lblAddress = new Label();
            lblAddress.Text = "Địa chỉ: " + diaChi;
            lblAddress.ForeColor = Color.White;
            lblAddress.Font = new Font("Segoe UI", 9);
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Location = new Point(left, 75);
            lblAddress.Size = new Size(220, 20);
            sataPanel.Controls.Add(lblAddress);

            // Ngày sinh & Giới tính
            Label lblDOBGender = new Label();
            lblDOBGender.Text = $"Ngày sinh: {DOB}   |   Giới tính: {gioiTinh}";
            lblDOBGender.ForeColor = Color.WhiteSmoke;
            lblDOBGender.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            lblDOBGender.BackColor = Color.Transparent;
            lblDOBGender.Location = new Point(left, 95);
            lblDOBGender.Size = new Size(230, 20);
            sataPanel.Controls.Add(lblDOBGender);

            // Mã độc giả
            Label lblDocGia = new Label();
            lblDocGia.Text = "Mã độc giả: " + IDDocGia;
            lblDocGia.ForeColor = Color.White;
            lblDocGia.Font = new Font("Segoe UI", 9);
            lblDocGia.BackColor = Color.Transparent;
            lblDocGia.Location = new Point(left, 115);
            lblDocGia.Size = new Size(150, 20);
            sataPanel.Controls.Add(lblDocGia);

            // Nút Sửa
            Button btnDetail = new Button();
            btnDetail.Text = "Sửa";
            btnDetail.ForeColor = Color.White;
            btnDetail.BackColor = Color.Teal;
            btnDetail.FlatStyle = FlatStyle.Flat;
            btnDetail.FlatAppearance.BorderSize = 0;
            btnDetail.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnDetail.Cursor = Cursors.Hand;
            btnDetail.Size = new Size(60, 25);
            btnDetail.Location = new Point(190, 140);
            sataPanel.Controls.Add(btnDetail);

         
            // Nút Xóa
            Button btnXoa = new Button();
            btnXoa.Text = "Xóa";
            btnXoa.ForeColor = Color.White;
            btnXoa.BackColor = Color.Teal;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Size = new Size(60, 25);
            btnXoa.Location = new Point(260, 140); 
            sataPanel.Controls.Add(btnXoa);

            btnDetail.Click += (sender, e) =>
            {
                GUI_ControlChiTietDocGia controlChiTietDocGia = new GUI_ControlChiTietDocGia();
                controlChiTietDocGia.person = new DTO_Person()
                {
                    sMa = IDDocGia,
                    sHoTen = fullName,
                    sGioiTinh = gioiTinh == "Nam" ? true : false,
                    sSDT = phone,
                    sEmail = email,
                    sDiaChi = diaChi,
                    sUsername = name,
                    sSourceImage = imagePath,
                    sNgaySinh = DateTime.Parse(DOB),
                    sPassword = password
                };
                controlChiTietDocGia.DocGia = true;
                controlChiTietDocGia.Add = false;
                controlChiTietDocGia.ShowDialog();
            };
            btnXoa.Click += (sender, e) =>
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa độc giả '{fullName}'?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show(bll_QuanLyDocGia.DelDocGia(IDDocGia));
                    flowLayoutPanel1.Controls.Remove(sataPanel);
                }
            };


            // Thêm panel vào flow layout
            flowLayoutPanel1.Controls.Add(sataPanel);

        }

        private void btnLoadList_Click(object sender, EventArgs e)
        {
            LoadListDocGia();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable dt = bll_QuanLyDocGia.SearchDocGia(txtSearch.Text);
            LoadListDG(dt);
        }

        private void btnLoadList_Click_1(object sender, EventArgs e)
        {
            DataTable dt = bll_QuanLyDocGia.ViewDocGia();
            LoadListDG(dt);
        }

        private void btnAddDocGia_Click_1(object sender, EventArgs e)
        {
            GUI_DangKyDG addDocGia = new GUI_DangKyDG();
            addDocGia.ShowDialog();
        }
    }
}
