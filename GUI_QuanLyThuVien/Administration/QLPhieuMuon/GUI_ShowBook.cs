using BLL_QuanLyThuVien;
using DTO_QuanLyThuVien;
using Sunny.UI;
using Sunny.UI.Win32;
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

namespace GUI_QuanLyThuVien.Administration.QLPhieuMuon
{
    public partial class GUI_ShowBook : Form
    {
        public GUI_ShowBook()
        {
            InitializeComponent();
        }
        BLL_QuanLySach bll = new BLL_QuanLySach();
        public int MaDG;
        
        private void AddBookToPanel(string imagePath, string bookID, string title, string author, string publisher, string price, string category, string librarianID, int soLuong)
        {
            DTO_Sach sach = new DTO_Sach();
            sach.sSourceImange = Path.GetFileName(imagePath);
            sach.sMaSach = int.Parse(bookID);
            sach.sTenSach = title;
            sach.sTacGia = author;
            sach.sNhaXuatBan = publisher;
            sach.sDonGia = decimal.Parse(price);
            sach.sTheLoai = category;
            sach.sMaThuThu = int.Parse(librarianID);
            sach.sSoLuong = soLuong;
            // Tạo SATAPanel cho sách
            var sataPanel = new SATAUiFramework.SATAPanel();
            sataPanel.Size = new Size(225, 350);
            sataPanel.BackColor = Color.FromArgb(30, 32, 41);
            sataPanel.BackColor2 = Color.FromArgb(30, 32, 41);
            sataPanel.Margin = new Padding(10);
            sataPanel.BorderRadius = new SATAUiFramework.BorderRadius()
            {
                TopLeft = 15,
                TopRight = 15,
                BottomLeft = 15,
                BottomRight = 15
            };

            // Bìa sách
            PictureBox picBook = new PictureBox();
            picBook.Image = Image.FromFile(imagePath);
            picBook.SizeMode = PictureBoxSizeMode.StretchImage;
            picBook.Size = new Size(120, 150);
            picBook.Location = new Point(50, 10);
            sataPanel.Controls.Add(picBook);

            Size originalSize = picBook.Size;
            Point originalLocation = picBook.Location;
            picBook.MouseEnter += (sender, e) =>
            {
                picBook.Size = new Size(140, 170);
                picBook.Location = new Point(50, 0);
                picBook.BringToFront();
            };

            picBook.MouseLeave += (sender, e) =>
            {
                picBook.Size = originalSize;
                picBook.Location = originalLocation;
            };

            int left = 15;
            int top = 160;
            int labelWidth = 195;
            int labelHeight = 20;
            // Mã Sách 
            Label lbidbook = new Label();
            lbidbook.Text = "Mã Sách: " + bookID;
            lbidbook.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lbidbook.ForeColor = Color.Yellow;
            lbidbook.BackColor = Color.Transparent;
            lbidbook.Location = new Point(left, top);
            lbidbook.Size = new Size(labelWidth, labelHeight);
            sataPanel.Controls.Add(lbidbook);

            // Tiêu đề sách
            Label lblTitle = new Label();
            lblTitle.Text = "Tên Sách: " + title;
            lblTitle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Location = new Point(left, top += 20);
            lblTitle.Size = new Size(labelWidth, labelHeight);
            sataPanel.Controls.Add(lblTitle);

            // Tác giả
            Label lblAuthor = new Label();
            lblAuthor.Text = "Tác giả: " + author;
            lblAuthor.Font = new Font("Segoe UI", 9);
            lblAuthor.ForeColor = Color.Red;
            lblAuthor.BackColor = Color.Transparent;
            lblAuthor.Location = new Point(left, top += 20);
            lblAuthor.Size = new Size(labelWidth, labelHeight);
            sataPanel.Controls.Add(lblAuthor);

            // Nhà xuất bản
            Label lblPublisher = new Label();
            lblPublisher.Text = "NXB: " + publisher;
            lblPublisher.Font = new Font("Segoe UI", 9);
            lblPublisher.ForeColor = Color.White;
            lblPublisher.BackColor = Color.Transparent;
            lblPublisher.Location = new Point(left, top += 20);
            lblPublisher.Size = new Size(labelWidth, labelHeight);
            sataPanel.Controls.Add(lblPublisher);

            // Giá
            Label lblPrice = new Label();
            lblPrice.Text = "Giá: " + price;
            lblPrice.Font = new Font("Segoe UI", 9);

            lblPrice.ForeColor = Color.Green;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Location = new Point(left, top += 20);
            lblPrice.Size = new Size(labelWidth, labelHeight);
            sataPanel.Controls.Add(lblPrice);

            // Thể loại
            Label lblCategory = new Label();
            lblCategory.Text = "Thể loại: " + category;
            lblCategory.Font = new Font("Segoe UI", 9);
            lblCategory.ForeColor = Color.Black;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Location = new Point(left, top += 20);
            lblCategory.Size = new Size(labelWidth, labelHeight);
            sataPanel.Controls.Add(lblCategory);

            // Thủ thư
            Label lblLibrarian = new Label();
            lblLibrarian.Text = "Thủ thư: " + librarianID;
            lblLibrarian.Font = new Font("Segoe UI", 9);
            lblLibrarian.ForeColor = Color.BlueViolet;
            lblLibrarian.BackColor = Color.Transparent;
            lblLibrarian.Location = new Point(left, top += 20);
            lblLibrarian.Size = new Size(labelWidth, labelHeight);
            sataPanel.Controls.Add(lblLibrarian);

            // Nút them vao gio
            var btnEdit = new UIButton();
            btnEdit.Text = "Thêm vào giỏ";
            btnEdit.Size = new Size(180, 30);
            btnEdit.Location = new Point(20, 305);
            btnEdit.ForeColor = Color.White;
            btnEdit.Radius = 20;
            sataPanel.Controls.Add(btnEdit);


            // Gắn sự kiện (để trống cho bạn tự xử lý sau)
            btnEdit.Click += (s, e) =>
            {
                //them vao gio cho doc gia
                DTO_Sach book = new DTO_Sach();
                book.sMaSach = int.Parse(bookID);
                book.sTenSach = title;
                book.sSoLuong = 1;   // chi them mo lan la 1 item 
                //bll.InsertBookToCart(book, MaDG);
                MessageBox.Show($"Thêm vào giỏ: {title}", "Thông báo");
            };
     

            // Thêm vào giao diện
            flowLayoutPanelMain.Controls.Add(sataPanel);
        }
        private void cbbChooseTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanelMain.Controls.Clear();
            DataTable dt = new DataTable();
            dt = bll.XemDanhSachToanBoSach();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string theLoai = dt.Rows[i]["Thể Loại"].ToString();
                if (theLoai == cbbChooseTheLoai.Text)
                {
                    string maSach = dt.Rows[i]["Mã Sách"].ToString();
                    string tacGia = dt.Rows[i]["Tác Giả"].ToString();
                    string tenSach = dt.Rows[i]["Tên Sách"].ToString();
                    string NXB = dt.Rows[i]["Nhà Xuất Bản"].ToString();
                    string donGia = dt.Rows[i]["Đơn Giá"].ToString();
                    string soLuong = dt.Rows[i]["Số Lượng"].ToString();
                    string MTT = dt.Rows[i]["Mã Thủ Thư"].ToString();
                    string img = "D:\\K25_Project_LTWinform\\DoAn\\images\\" + dt.Rows[i]["Source Image"].ToString();
                    img.Split(' ');
                    AddBookToPanel(img, maSach, tenSach, tacGia, NXB, donGia, theLoai, MTT, int.Parse(soLuong));
                }
            }
        }

        private void flowLayoutPanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GUI_ShowBook_Load(object sender, EventArgs e)
        {
            DataTable dtTL = new DataTable();
            dtTL = bll.GetTheLoaiSach();
            foreach (DataRow dr in dtTL.Rows)
            {
                cbbChooseTheLoai.Items.Add(dr["theLoai"].ToString());
            }
            flowLayoutPanelMain.Controls.Clear();
            DataTable dt = new DataTable();
            dt = bll.XemDanhSachToanBoSach();

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                string maSach = dt.Rows[i]["Mã Sách"].ToString();
                string tacGia = dt.Rows[i]["Tác Giả"].ToString();
                string tenSach = dt.Rows[i]["Tên Sách"].ToString();
                string NXB = dt.Rows[i]["Nhà Xuất Bản"].ToString();
                string donGia = dt.Rows[i]["Đơn Giá"].ToString();
                string soLuong = dt.Rows[i]["Số Lượng"].ToString();
                string theLoai = dt.Rows[i]["Thể Loại"].ToString();
                string MTT = dt.Rows[i]["Mã Thủ Thư"].ToString();
                string img = "D:\\K25_Project_LTWinform\\DoAn\\images\\" + dt.Rows[i]["Source Image"].ToString();
                img.Split(' ');
                AddBookToPanel(img, maSach, tenSach, tacGia, NXB, donGia, theLoai, MTT, int.Parse(soLuong));
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            GUI_ShowBook_Load(sender, e);
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            flowLayoutPanelMain.Controls.Clear();
            DataTable dt = new DataTable();
            dt = bll.TimKiemSach(txtUser.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                string maSach = dt.Rows[i]["maSach"].ToString();
                string tacGia = dt.Rows[i]["tacGia"].ToString();
                string tenSach = dt.Rows[i]["tenSach"].ToString();
                string NXB = dt.Rows[i]["nhaXuatBan"].ToString();
                string donGia = dt.Rows[i]["donGia"].ToString();
                string soLuong = dt.Rows[i]["soLuong"].ToString();
                string theLoai = dt.Rows[i]["theLoai"].ToString();
                string MTT = dt.Rows[i]["maThuThu"].ToString();
                string img = "D:\\K25_Project_LTWinform\\DoAn\\images\\" + dt.Rows[i]["source_image"].ToString();
                img.Split(' ');
                AddBookToPanel(img, maSach, tenSach, tacGia, NXB, donGia, theLoai, MTT, int.Parse(soLuong));
            }
        }

        private void cbbChooseTheLoai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            flowLayoutPanelMain.Controls.Clear();
            DataTable dt = new DataTable();
            dt = bll.XemDanhSachToanBoSach();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string theLoai = dt.Rows[i]["Thể Loại"].ToString();
                if (theLoai == cbbChooseTheLoai.Text)
                {
                    string maSach = dt.Rows[i]["Mã Sách"].ToString();
                    string tacGia = dt.Rows[i]["Tác Giả"].ToString();
                    string tenSach = dt.Rows[i]["Tên Sách"].ToString();
                    string NXB = dt.Rows[i]["Nhà Xuất Bản"].ToString();
                    string donGia = dt.Rows[i]["Đơn Giá"].ToString();
                    string soLuong = dt.Rows[i]["Số Lượng"].ToString();
                    string MTT = dt.Rows[i]["Mã Thủ Thư"].ToString();
                    string img = "D:\\K25_Project_LTWinform\\DoAn\\images\\" + dt.Rows[i]["Source Image"].ToString();
                    img.Split(' ');
                    AddBookToPanel(img, maSach, tenSach, tacGia, NXB, donGia, theLoai, MTT, int.Parse(soLuong));
                }
            }
        }



    }
}
