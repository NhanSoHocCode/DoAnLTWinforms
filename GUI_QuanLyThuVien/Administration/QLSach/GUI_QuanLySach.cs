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
using GUI_QuanLyThuVien.Administration;

namespace GUI_QuanLyThuVien
{
    public partial class GUI_QuanLySach : Form
    {
        public GUI_QuanLySach()
        {
            InitializeComponent();
            btnRefesh.Image = new Bitmap(Properties.Resources.lammoi, btnRefesh.ClientSize.Height - 10, btnRefesh.ClientSize.Height - 10);
            btnRefesh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefesh.AutoSize = true;
            btnRefesh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefesh.TextAlign = ContentAlignment.MiddleCenter;

            btnAddBook.Image = new Bitmap(Properties.Resources.Plus_icon, btnAddBook.ClientSize.Height - 10, btnAddBook.ClientSize.Height - 10);
            btnAddBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddBook.AutoSize = true;
            btnAddBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddBook.TextAlign = ContentAlignment.MiddleCenter;

            btnEdit.Image = new Bitmap(Properties.Resources.thaydoiquydinh, btnEdit.ClientSize.Height - 10, btnEdit.ClientSize.Height - 10);
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.AutoSize = true;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.TextAlign = ContentAlignment.MiddleCenter;


            btnDel.Image = new Bitmap(Properties.Resources.close_icon, btnDel.ClientSize.Height - 10, btnDel.ClientSize.Height - 10);
            btnDel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDel.AutoSize = true;
            btnDel.ImageAlign = ContentAlignment.MiddleLeft;
            btnDel.TextAlign = ContentAlignment.MiddleCenter;
        }
        BLL_QuanLySach bll = new BLL_QuanLySach();
        public String Function = "";

        //private void GUI_QuanLySach_Load(object sender, EventArgs e)
        //{
        //    bll.XemDanhSachToanBoSach();
        //    dtg1.DataSource = bll.XemDanhSachToanBoSach();
        //}
        private void AddBookToPanel(string imagePath, string bookID, string title, string author, string publisher, string price, string category, string librarianID)
        {
            // Tạo Panel chứa sách
            Panel bookPanel = new Panel();
            bookPanel.Size = new Size(250, 350);
            bookPanel.BorderStyle = BorderStyle.FixedSingle;

            // Thêm ảnh sách
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(imagePath);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(120, 150);
            pictureBox.Location = new Point(65, 10);

            // Lưu kích thước gốc của ảnh
            Size originalSize = pictureBox.Size;
            Point originalLocation = pictureBox.Location;

            // Hiệu ứng phóng to ảnh khi di chuột vào
            pictureBox.MouseEnter += (sender, e) =>
            {
                pictureBox.Size = new Size(140, 170);
                pictureBox.Location = new Point(55, 0);
                pictureBox.BringToFront();
            };

            pictureBox.MouseLeave += (sender, e) =>
            {
                pictureBox.Size = originalSize;
                pictureBox.Location = originalLocation;
            };

            // Tạo Label thông tin sách
            Label lblBookID = new Label { Text = "Mã sách: " + bookID, Location = new Point(10, 165), AutoSize = true };
            Label lblTitle = new Label { Text = "Tên sách: " + title, Font = new Font("Arial", 10, FontStyle.Bold), Location = new Point(10, 185), AutoSize = true };
            Label lblAuthor = new Label { Text = "Tác giả: " + author, Location = new Point(10, 205), AutoSize = true };
            Label lblPublisher = new Label { Text = "NXB: " + publisher, Location = new Point(10, 225), AutoSize = true };
            Label lblPrice = new Label { Text = "Giá: " + price, ForeColor = Color.Red, Font = new Font("Arial", 9, FontStyle.Bold), Location = new Point(10, 245), AutoSize = true };
            Label lblCategory = new Label { Text = "Thể loại: " + category, Location = new Point(10, 265), AutoSize = true };
            Label lblLibrarianID = new Label { Text = "Mã thủ thư: " + librarianID, Location = new Point(10, 285), AutoSize = true };

            // Thêm nút "Thêm vào giỏ hàng"
            Button btnAddToCart = new Button();
            btnAddToCart.Text = "Thêm vào giỏ hàng";
            btnAddToCart.Size = new Size(120, 30);
            btnAddToCart.Location = new Point(65, 310);

            // Sự kiện khi nhấn nút (hiện nội dung nút lên MessageBox)
            btnAddToCart.Click += (sender, e) => MessageBox.Show("Đã thêm " + title + " vào giỏ hàng!", "Thông báo");

            // Thêm các control vào panel sách
            bookPanel.Controls.Add(pictureBox);
            bookPanel.Controls.Add(lblBookID);
            bookPanel.Controls.Add(lblTitle);
            bookPanel.Controls.Add(lblAuthor);
            bookPanel.Controls.Add(lblPublisher);
            bookPanel.Controls.Add(lblPrice);
            bookPanel.Controls.Add(lblCategory);
            bookPanel.Controls.Add(lblLibrarianID);
            bookPanel.Controls.Add(btnAddToCart);

            // Thêm vào FlowLayoutPanel chính
            flowLayoutPanelMain.Controls.Add(bookPanel);
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            GUI_AddEditBook form = new GUI_AddEditBook();
            form.Add = true;
            form.Show();
        }
        private void btnEdit_Click(object sender, EventArgs e)  // chinh sua lai thu tu dung chuc nang khi edit 
        {
            Function = "Edit";
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            Function = "Delete";  // lam sao de doi thu thu khi chon or click 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GUI_QuanLySach_Load(object sender, EventArgs e)
        {
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
                AddBookToPanel(img, maSach, tenSach, tacGia, NXB, donGia, theLoai, MTT);
            }
        }


        //private void btnRefesh_Click(object sender, EventArgs e)
        //{
        //    dtg1.ClearSelection();
        //    dtg1.DataSource = bll.XemDanhSachToanBoSach();
        //}

        //private void txtSearchBook_KeyDown(object sender, KeyEventArgs e)
        //{
        //    DTO_Sach dTO_Sach = new DTO_Sach();
        //    dTO_Sach.sTenSach = txtSearchBook.Text;
        //    dtg1.ClearSelection();
        //    dtg1.DataSource = bll.TimKiemSach(dTO_Sach);
        //}

        //private void dtg1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dtg1 == null || bll == null || Function == null)
        //    {
        //        MessageBox.Show("Required components are not initialized.");
        //        return;
        //    }

        //    if (Function == "Delete")
        //    {
        //        if (e.RowIndex >= 0) // Ensure not clicking on column header
        //        {
        //            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?",
        //                                                  "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //            if (result == DialogResult.Yes)
        //            {
        //                DataGridViewRow row = dtg1.Rows[e.RowIndex];
        //                string maSach = row.Cells[0].Value?.ToString();
        //                if (maSach != null)
        //                {
        //                    DTO_Sach sach = new DTO_Sach();
        //                    sach.sMaSach = maSach;
        //                    dtg1.Rows.RemoveAt(e.RowIndex);
        //                    MessageBox.Show(bll.XoaSach(sach));        // Xoa sach trong database   
        //                }
        //            }
        //        }
        //    }
        //    else if (Function == "Edit")
        //    {

        //        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn edit dòng này?",
        //                                              "Xác nhận edit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //        if (result == DialogResult.Yes)
        //        {
        //            DataGridViewRow row = dtg1.Rows[e.RowIndex];
        //            DTO_Sach sach = new DTO_Sach();
        //            sach.sMaSach = dtg1.Rows[e.RowIndex].Cells[0].Value?.ToString();
        //            sach.sTacGia = dtg1.Rows[e.RowIndex].Cells[1].Value?.ToString();
        //            sach.sTenSach = dtg1.Rows[e.RowIndex].Cells[2].Value?.ToString();
        //            sach.sNhaXuatBan = dtg1.Rows[e.RowIndex].Cells[3].Value?.ToString();
        //            sach.sDonGia = dtg1.Rows[e.RowIndex].Cells[4].Value?.ToString();
        //            sach.sSoLuong = int.Parse(dtg1.Rows[e.RowIndex].Cells[5].Value?.ToString());
        //            sach.sTheLoai = dtg1.Rows[e.RowIndex].Cells[6].Value?.ToString();
        //            sach.sMaThuThu = dtg1.Rows[e.RowIndex].Cells[7].Value?.ToString();
        //            sach.sSourceImange = dtg1.Rows[e.RowIndex].Cells[8].Value?.ToString();
        //            GUI_AddEditBook form = new GUI_AddEditBook();
        //            form.sach1 = sach;
        //            form.Add = false;
        //            form.Show();
        //        }
        //    }
        //}
    }
}
