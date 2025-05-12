namespace GUI_QuanLyThuVien
{
    partial class GUI_QuanLySach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefesh = new Guna.UI2.WinForms.Guna2Button();
            this.cbbChooseTheLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddBook = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.btnRefesh);
            this.panel1.Controls.Add(this.cbbChooseTheLoai);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.btnAddBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1726, 116);
            this.panel1.TabIndex = 4;
            // 
            // btnRefesh
            // 
            this.btnRefesh.Animated = true;
            this.btnRefesh.AutoRoundedCorners = true;
            this.btnRefesh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnRefesh.BorderRadius = 26;
            this.btnRefesh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefesh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefesh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefesh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefesh.FillColor = System.Drawing.Color.Gray;
            this.btnRefesh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRefesh.ForeColor = System.Drawing.Color.White;
            this.btnRefesh.Image = global::GUI_QuanLyThuVien.Properties.Resources.eeg;
            this.btnRefesh.Location = new System.Drawing.Point(32, 25);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(211, 54);
            this.btnRefesh.TabIndex = 35;
            this.btnRefesh.Text = "Xem danh sách";
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click_1);
            // 
            // cbbChooseTheLoai
            // 
            this.cbbChooseTheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbbChooseTheLoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbbChooseTheLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbChooseTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChooseTheLoai.FillColor = System.Drawing.Color.Gray;
            this.cbbChooseTheLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbChooseTheLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbChooseTheLoai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbChooseTheLoai.ForeColor = System.Drawing.Color.Black;
            this.cbbChooseTheLoai.ItemHeight = 30;
            this.cbbChooseTheLoai.Location = new System.Drawing.Point(2052, 34);
            this.cbbChooseTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbChooseTheLoai.Name = "cbbChooseTheLoai";
            this.cbbChooseTheLoai.Size = new System.Drawing.Size(217, 36);
            this.cbbChooseTheLoai.TabIndex = 37;
            this.cbbChooseTheLoai.SelectedIndexChanged += new System.EventHandler(this.cbbChooseTheLoai_SelectedIndexChanged);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtUser.BorderRadius = 26;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Location = new System.Drawing.Point(289, 25);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceholderText = "Tìm kiếm theo tên và mã sách ";
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(603, 54);
            this.txtUser.TabIndex = 30;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Animated = true;
            this.btnAddBook.AutoRoundedCorners = true;
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAddBook.BorderRadius = 26;
            this.btnAddBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddBook.FillColor = System.Drawing.Color.Gray;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Image = global::GUI_QuanLyThuVien.Properties.Resources.them;
            this.btnAddBook.Location = new System.Drawing.Point(1441, 25);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(211, 54);
            this.btnAddBook.TabIndex = 36;
            this.btnAddBook.Text = "Thêm sách mới";
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.AutoScroll = true;
            this.flowLayoutPanelMain.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMain.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(0, 116);
            this.flowLayoutPanelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(1726, 893);
            this.flowLayoutPanelMain.TabIndex = 0;
            // 
            // GUI_QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GUI_QuanLyThuVien.Properties.Resources.cc;
            this.ClientSize = new System.Drawing.Size(1726, 1009);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUI_QuanLySach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_QuanLySach";
            this.Load += new System.EventHandler(this.GUI_QuanLySach_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Guna.UI2.WinForms.Guna2Button btnRefesh;
        private Guna.UI2.WinForms.Guna2Button btnAddBook;
        private Guna.UI2.WinForms.Guna2ComboBox cbbChooseTheLoai;
    }
}