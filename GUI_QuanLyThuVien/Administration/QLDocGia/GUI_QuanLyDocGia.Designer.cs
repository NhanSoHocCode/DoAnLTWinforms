namespace GUI_QuanLyThuVien.Administration
{
    partial class GUI_QuanLyDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_QuanLyDocGia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddDocGia = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoadList = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.btnAddDocGia);
            this.panel1.Controls.Add(this.btnLoadList);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1726, 116);
            this.panel1.TabIndex = 1;
            // 
            // btnAddDocGia
            // 
            this.btnAddDocGia.Animated = true;
            this.btnAddDocGia.AutoRoundedCorners = true;
            this.btnAddDocGia.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDocGia.BorderRadius = 26;
            this.btnAddDocGia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDocGia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDocGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDocGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDocGia.FillColor = System.Drawing.Color.Gray;
            this.btnAddDocGia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddDocGia.ForeColor = System.Drawing.Color.White;
            this.btnAddDocGia.Image = global::GUI_QuanLyThuVien.Properties.Resources.them;
            this.btnAddDocGia.ImageSize = new System.Drawing.Size(35, 20);
            this.btnAddDocGia.Location = new System.Drawing.Point(1441, 25);
            this.btnAddDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDocGia.Name = "btnAddDocGia";
            this.btnAddDocGia.Size = new System.Drawing.Size(211, 54);
            this.btnAddDocGia.TabIndex = 16;
            this.btnAddDocGia.Text = "Thêm độc giả";
            this.btnAddDocGia.Click += new System.EventHandler(this.btnAddDocGia_Click_1);
            // 
            // btnLoadList
            // 
            this.btnLoadList.Animated = true;
            this.btnLoadList.AutoRoundedCorners = true;
            this.btnLoadList.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadList.BorderRadius = 26;
            this.btnLoadList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadList.FillColor = System.Drawing.Color.Gray;
            this.btnLoadList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLoadList.ForeColor = System.Drawing.Color.White;
            this.btnLoadList.Image = global::GUI_QuanLyThuVien.Properties.Resources.eeg;
            this.btnLoadList.Location = new System.Drawing.Point(24, 2);
            this.btnLoadList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadList.Name = "btnLoadList";
            this.btnLoadList.Size = new System.Drawing.Size(211, 54);
            this.btnLoadList.TabIndex = 15;
            this.btnLoadList.Text = "Xem danh sách";
            this.btnLoadList.Click += new System.EventHandler(this.btnLoadList_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderRadius = 26;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(289, 25);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm kiếm theo mã và tên độc giả ";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(603, 54);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1726, 893);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 26;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Gray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(24, 57);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(211, 54);
            this.guna2Button1.TabIndex = 17;
            this.guna2Button1.Text = "Báo cáo độc giả";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // GUI_QuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 1009);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUI_QuanLyDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GUI_QuanLyDocGia";
            this.Load += new System.EventHandler(this.GUI_QuanLyDocGia_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnLoadList;
        private Guna.UI2.WinForms.Guna2Button btnAddDocGia;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}