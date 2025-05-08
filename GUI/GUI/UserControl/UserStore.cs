using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Sunny.UI;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SATAUiFramework;
using System.Windows.Forms.VisualStyles;
using System.Globalization;
using DTO_QuanLyThuVien;
using BLL_QuanLyThuVien;
using System.Reflection.Emit;

namespace GUI.UserControl
{
    
    public partial class UserStore : Form
    {
        private Form1 parentForm;
        string Key = "";
        string QueueRy = "";
        public DTO_Person person;
        private BLL_QuanLySach bll_quanlysach = new BLL_QuanLySach();
        
        public UserStore(Form1 form1, string Infor)
        {
            Key = Infor;
            InitializeComponent();
            panlllll.AutoScroll = true;
            this.parentForm = form1;
        }
        public class ProductInfo
        {
            public string Name { get; set; }
            public int MaSach { get; set; }
            public decimal Price { get; set; }
            public Image ProductImage { get; set; } 
            public int SoLuong { get; set; }
            
        }
        // Phần dữ liệu của Database
        private List<ProductInfo> GetSampleProductData()
        {
            var products = new List<ProductInfo>();
            DataTable dt = bll_quanlysach.ListBookToCart(int.Parse(person.sMa));
            //ProductImage có thể thay bằng source_image
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string path = "D:\\K25_Project_LTWinform\\DoAn\\images\\" + dr["source_image"].ToString();
                    products.Add(new ProductInfo
                    {
                        Name = dr["tenSach"].ToString(),
                        Price = decimal.Parse(dr["donGia"].ToString()),
                        ProductImage = Image.FromFile(path),
                        SoLuong = int.Parse(dr["soLuong"].ToString()),
                        MaSach = int.Parse(dr["MaSach"].ToString())
                    });
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Giỏ hàng trống\nVui lòng thêm sản phẩm mới vào giỏ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );  
               // MessageBox.Show($"Lỗi load ảnh mẫu: {ex.Message}");
                Image defaultImage = new Bitmap(100, 100); // Ảnh trống đơn giản
                using (Graphics g = Graphics.FromImage(defaultImage)) { g.Clear(Color.Gray); }
                products.Clear(); // Xóa các item có thể đã thêm trước đó nếu lỗi
            }


            return products;
        }
        private void UserMenu_Load_1(object sender, EventArgs e)
        {
            label1.Text = Key;
            label2.Text = person.sHoTen;
            Load_all();
        }
        private void Load_all()
        {
            // 1.Lấy dữ liệu(từ DB hoặc mẫu)
            List<ProductInfo> productList = GetSampleProductData(); // Hoặc hàm lấy từ DB
            // 2. Hiển thị lên panel3
            decimal Sprice = 0;
            if (productList.Count > 0)
            {
                foreach (var product in productList)
                    Sprice += product.Price;
                CultureInfo cultureInfo = new CultureInfo("vi-VN");
                //labelGiaTien.Text = (Sprice * 26000).ToString("N0", cultureInfo) + " VNDC";
                PopulateProductPanel(panlllll, productList);
            }
        }
        private void PopulateProductPanel(Panel targetPanel, List<ProductInfo> products)
        {
            targetPanel.Controls.Clear(); // Xóa các control cũ trước khi thêm mới

            // --- Thông số cố định cho mỗi thẻ sản phẩm ---
            int cardWidth = 249;
            int cardHeight = 323;
            int horizontalMargin = 15; // Khoảng cách ngang giữa các thẻ
            int verticalMargin = 15;   // Khoảng cách dọc giữa các thẻ
            int startX = 10;           // Vị trí X bắt đầu trong panel
            int startY = 10;           // Vị trí Y bắt đầu trong panel

            int currentX = startX;
            int currentY = startY;

            // Tính toán chiều rộng có thể sử dụng của panel (trừ đi lề và thanh cuộn nếu có)
            int availableWidth = targetPanel.ClientSize.Width - startX; // ClientSize không bao gồm viền, thanh cuộn

            foreach (var product in products)
            {
                // --- Tạo SataPanel (Container chính) ---
                var sataPanel = new SATAUiFramework.SATAPanel();
                sataPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
                sataPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
                sataPanel.BorderColor = System.Drawing.Color.Black;
                // Tạo BorderRadius (Giả sử SataUIFramework.BorderRadius là tên đúng)
                SATAUiFramework.BorderRadius borderRadius = new SATAUiFramework.BorderRadius();
                borderRadius.BottomLeft = 20;
                borderRadius.BottomRight = 20;
                borderRadius.TopLeft = 20;
                borderRadius.TopRight = 20;
                sataPanel.BorderRadius = borderRadius;
                sataPanel.BorderThickness = 0;
                sataPanel.Size = new System.Drawing.Size(cardWidth, cardHeight);
                sataPanel.Name = $"sataPanel_{product.Name.Replace(" ", "_")}"; // Tên duy nhất (tùy chọn)
                sataPanel.Tag = product; // Lưu trữ dữ liệu sản phẩm vào Tag để truy cập sau này nếu cần

                // --- Tạo PictureBox ---
                var pictureBox = new PictureBox();
                pictureBox.Dock = System.Windows.Forms.DockStyle.Top; // Dock lên trên cùng của sataPanel
                pictureBox.Image = product.ProductImage; // Lấy ảnh từ dữ liệu
                pictureBox.Location = new System.Drawing.Point(0, 0); // Dock lo vị trí, nhưng set để rõ ràng
                pictureBox.Name = $"pictureBox_{product.Name.Replace(" ", "_")}";
                pictureBox.Size = new System.Drawing.Size(cardWidth, 170); // Kích thước cố định như trong code mẫu
                pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom; // Hoặc StretchImage, tùy bạn muốn
                pictureBox.TabIndex = 0;
                pictureBox.TabStop = false;

                // --- Tạo Label Tên sản phẩm ---
                //var labelName = new Label();
                //labelName.AutoSize = true; // Tự động điều chỉnh kích thước label theo text
                //labelName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //labelName.ForeColor = System.Drawing.Color.White; // Cần màu cho label tên (không có trong ảnh, chọn màu trắng)
                //labelName.Location = new System.Drawing.Point(5, 186); // Vị trí tương đối trong sataPanel
                //labelName.Name = $"labelName_{product.Name.Replace(" ", "_")}";
                //labelName.Size = new System.Drawing.Size(104, 19); // Size sẽ tự điều chỉnh do AutoSize, nhưng có thể set tạm
                //labelName.TabIndex = 1;
                //labelName.Text = product.Name; // Lấy tên từ dữ liệu

                //// --- Tạo Label Giá tiền ---
                //var labelPrice = new Label();
                //labelPrice.AutoSize = true;
                //labelPrice.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
                //labelPrice.Location = new System.Drawing.Point(3, 223); // Vị trí tương đối trong sataPanel
                //labelPrice.Name = $"labelPrice_{product.Name.Replace(" ", "_")}";
                //labelPrice.Size = new System.Drawing.Size(79, 34); // Size sẽ tự điều chỉnh
                //labelPrice.TabIndex = 2;
                //labelPrice.Text = $"${product.Price:N2}"; // Lấy giá từ dữ liệu và định dạng

                // --- Tạo UIButton "Buy" ---
                var uiButtonBuy = new UIButton(); // Giả sử lớp là Sunny.UI.UIButton
                uiButtonBuy.Cursor = System.Windows.Forms.Cursors.Hand;
                uiButtonBuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(111)))));
                uiButtonBuy.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(111)))));
                // Lấy các màu khác từ ảnh uiButton1
                uiButtonBuy.FillDisableColor = System.Drawing.Color.FromArgb(244, 244, 244);
                uiButtonBuy.FillHoverColor = System.Drawing.Color.FromArgb(115, 179, 255); // Lấy từ ảnh uiButton1
                uiButtonBuy.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(197)))), ((int)(((byte)(145)))));
                uiButtonBuy.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(97)))));
                uiButtonBuy.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
                uiButtonBuy.ForeColor = System.Drawing.Color.White; // Lấy từ ảnh uiButton1
                uiButtonBuy.ForeDisableColor = System.Drawing.Color.FromArgb(109, 109, 109); // Lấy từ ảnh uiButton1
                uiButtonBuy.ForeHoverColor = System.Drawing.Color.White; // Lấy từ ảnh uiButton1
                uiButtonBuy.ForePressColor = System.Drawing.Color.White; // Lấy từ ảnh uiButton1
                uiButtonBuy.ForeSelectedColor = System.Drawing.Color.White; // Lấy từ ảnh uiButton1
                uiButtonBuy.Location = new System.Drawing.Point(9, 271); // Vị trí tương đối trong sataPanel
                uiButtonBuy.MinimumSize = new System.Drawing.Size(1, 1);
                uiButtonBuy.Name = $"uiButtonBuy_{product.Name.Replace(" ", "_")}";
                uiButtonBuy.Radius = 37;
                uiButtonBuy.RadiusSides = Sunny.UI.UICornerRadiusSides.All; // Giả sử enum tên là vậy
                uiButtonBuy.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(97)))));
                uiButtonBuy.RectDisableColor = System.Drawing.Color.FromArgb(173, 178, 181); // Lấy từ ảnh uiButton1
                uiButtonBuy.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(111)))));
                uiButtonBuy.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(98)))));
                uiButtonBuy.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(111)))));
                uiButtonBuy.Size = new System.Drawing.Size(120, 39);
                uiButtonBuy.TabIndex = 4;
                uiButtonBuy.Text = "Xóa";
                // uiButtonBuy.TipsColor = System.Drawing.Color.ForestGreen; // Không có trong ảnh uiButton1? Có thể bỏ qua
                // uiButtonBuy.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F); // Không có trong ảnh uiButton1?
                // Thêm sự kiện click nếu cần
                uiButtonBuy.Click += (sender, e) => {
                    // Xử lý khi nút Buy được nhấn
                    // Có thể lấy lại thông tin sản phẩm từ Tag của button hoặc panel cha
                    var clickedButton = sender as UIButton;
                    var parentPanel = clickedButton?.Parent as SATAUiFramework.SATAPanel;
                    var productData = parentPanel?.Tag as ProductInfo;
                    if (productData != null)
                    {
                        bll_quanlysach.DelBookToCart(productData.MaSach, int.Parse(person.sMa));
                        MessageBox.Show($"Xóa khỏi giỏ: {productData.Name}");
                        parentForm.giohang(person);
                    }
                };
                // --- Tạo UIButton "Detail" ---
                var uiButtonDetail = new Sunny.UI.UIButton(); // Giả sử lớp là Sunny.UI.UIButton
                uiButtonDetail.Cursor = System.Windows.Forms.Cursors.Hand;
                // Lấy các màu từ ảnh uiButton2
                uiButtonDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
                uiButtonDetail.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
                uiButtonDetail.FillDisableColor = System.Drawing.Color.FromArgb(244, 244, 244);
                uiButtonDetail.FillHoverColor = System.Drawing.Color.FromArgb(115, 179, 255);
                uiButtonDetail.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(197)))), ((int)(((byte)(145)))));
                uiButtonDetail.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(97)))));
                uiButtonDetail.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
                uiButtonDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(111))))); // Lấy từ ảnh uiButton2
                uiButtonDetail.ForeDisableColor = System.Drawing.Color.FromArgb(109, 109, 109);
                uiButtonDetail.ForeHoverColor = System.Drawing.Color.White;
                uiButtonDetail.ForePressColor = System.Drawing.Color.White;
                uiButtonDetail.ForeSelectedColor = System.Drawing.Color.White;
                uiButtonDetail.Location = new System.Drawing.Point(135, 271); // Vị trí tương đối trong sataPanel
                uiButtonDetail.MinimumSize = new System.Drawing.Size(1, 1);
                uiButtonDetail.Name = $"uiButtonDetail_{product.Name.Replace(" ", "_")}";
                uiButtonDetail.Radius = 37;
                uiButtonDetail.RadiusSides = Sunny.UI.UICornerRadiusSides.All; // Giả sử enum tên là vậy
                uiButtonDetail.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(97)))));
                uiButtonDetail.RectDisableColor = System.Drawing.Color.FromArgb(173, 178, 181);
                uiButtonDetail.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(111)))));
                uiButtonDetail.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(98)))));
                uiButtonDetail.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(111)))));
                uiButtonDetail.Size = new System.Drawing.Size(100, 39);
                uiButtonDetail.TabIndex = 5;
                uiButtonDetail.Text = "Detail";
                // uiButtonDetail.TipsColor = System.Drawing.Color.ForestGreen; // Không có trong ảnh uiButton2?
                // uiButtonDetail.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F); // Không có trong ảnh uiButton2?
                // uiButtonDetail.TipsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(111))))); // Không có trong ảnh uiButton2?
                // Thêm sự kiện click nếu cần
                uiButtonDetail.Click += (sender, e) => {
                    // Xử lý khi nút Detail được nhấn
                    var clickedButton = sender as UIButton;
                    var parentPanel = clickedButton?.Parent as SATAPanel;
                    var productData = parentPanel?.Tag as ProductInfo;
                    if (productData != null)
                    {
                        MessageBox.Show($"Bạn đã nhấn Detail cho: {productData.Name}\nGiá: ${productData.Price:N2}\nSố Lượng: {product.SoLuong}");
                        // Mở form chi tiết hoặc hiển thị thêm thông tin ở đây
                    }
                };

                // --- Thêm các control con vào SataPanel ---
                // Thứ tự thêm có thể ảnh hưởng đến chỉ số TabIndex và cách hiển thị nếu có overlap
                sataPanel.Controls.Add(uiButtonDetail); // Thêm nút sau để có thể nằm trên nếu cần
                sataPanel.Controls.Add(uiButtonBuy);
                //sataPanel.Controls.Add(labelPrice);
                //sataPanel.Controls.Add(labelName);
                sataPanel.Controls.Add(pictureBox); // PictureBox dock top nên thêm trước hoặc sau không quá quan trọng về vị trí Y

                // --- Tính toán vị trí cho SataPanel hiện tại trong targetPanel ---
                // Kiểm tra xem có đủ chỗ trên hàng hiện tại không
                if (currentX + cardWidth > availableWidth && currentX != startX) // Nếu không đủ chỗ VÀ không phải là item đầu tiên trên hàng
                {
                    // Xuống hàng mới
                    currentX = startX;
                    currentY += cardHeight + verticalMargin;
                }

                // Đặt vị trí cho sataPanel
                sataPanel.Location = new Point(currentX, currentY);

                // --- Thêm SataPanel đã hoàn thiện vào Panel mục tiêu ---
                targetPanel.Controls.Add(sataPanel);

                // --- Cập nhật vị trí X cho thẻ tiếp theo ---
                currentX += cardWidth + horizontalMargin;
            }
            // targetPanel.PerformLayout(); // Có thể cần thiết trong một số trường hợp



        }
        BLL_QuanLyPhieuMuon bllpm = new BLL_QuanLyPhieuMuon();
        private void uiButton1_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn mượn!",
                "Xác nhận mượn?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
             );
            if (result == DialogResult.Yes)
            {
                // Xử lý khi người dùng chọn Yes
                DTO_PhieuMuon pm = new DTO_PhieuMuon();
                pm.sMaDocGia = int.Parse(person.sMa);
                GUI_XacNhanNgayMuon form = new GUI_XacNhanNgayMuon();
                form.ShowDialog();
                pm.sNgayTra = form.ngayTra;
                if (pm.sNgayTra == null)
                {
                    return;
                }
                int maPMnew = bllpm.CreatePMtoDocGia(pm);  // tiep tuc luu sach tu ma pm nay 
                
                List<ProductInfo> productList = GetSampleProductData(); // Hoặc hàm lấy từ DB                                                        // 2. Hiển thị lên panel3
                if (productList.Count > 0)
                {
                    foreach (var product in productList)
                    {
                        DTO_Sach book = new DTO_Sach();
                        book.sMaSach = product.MaSach;
                        book.sSoLuong = product.SoLuong;
                        bllpm.ThemSachVaoPhieuMuon(book, maPMnew);
                    }
                    MessageBox.Show("Mượn thành công");
                    bllpm.DelBookToCartOnDocGia(int.Parse(person.sMa));
                    parentForm.giohang(person);
                }

            }

            
            // button thanh toan
            // lay cac item trong gio hang day vao trong phieu muon :))) 
        }
        private void sataTextBox1__TextChanged(object sender, EventArgs e)
        {
            QueueRy = "";
            Load_all();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            parentForm.Close();
        }

        private void btnIncrea_Click(object sender, EventArgs e)
        {
            QueueRy = "";
            Load_all();
        }

        private void btndecrea_Click(object sender, EventArgs e)
        {
            QueueRy = "";
            Load_all();
        }

        private void sataButton1_Click(object sender, EventArgs e)
        {
            //parentForm.giohang();
        }
        private void UserMenu_Load(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
