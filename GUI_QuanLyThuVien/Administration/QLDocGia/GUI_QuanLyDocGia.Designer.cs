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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLoadList = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddDocGia = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1321, 695);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GUI_QuanLyThuVien.Properties.Resources.cc;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnAddDocGia);
            this.panel1.Controls.Add(this.btnLoadList);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 90);
            this.panel1.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderRadius = 18;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(270, 25);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search theo mã và tên độc giả ";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(299, 39);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnLoadList
            // 
            this.btnLoadList.Animated = true;
            this.btnLoadList.AutoRoundedCorners = true;
            this.btnLoadList.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadList.BorderRadius = 21;
            this.btnLoadList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnLoadList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadList.ForeColor = System.Drawing.Color.White;
            this.btnLoadList.Image = global::GUI_QuanLyThuVien.Properties.Resources.eeg;
            this.btnLoadList.Location = new System.Drawing.Point(53, 20);
            this.btnLoadList.Name = "btnLoadList";
            this.btnLoadList.Size = new System.Drawing.Size(163, 44);
            this.btnLoadList.TabIndex = 15;
            this.btnLoadList.Text = "Xem danh sách";
            this.btnLoadList.Click += new System.EventHandler(this.btnLoadList_Click_1);
            // 
            // btnAddDocGia
            // 
            this.btnAddDocGia.Animated = true;
            this.btnAddDocGia.AutoRoundedCorners = true;
            this.btnAddDocGia.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDocGia.BorderRadius = 21;
            this.btnAddDocGia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDocGia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDocGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDocGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDocGia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnAddDocGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddDocGia.ForeColor = System.Drawing.Color.White;
            this.btnAddDocGia.Image = global::GUI_QuanLyThuVien.Properties.Resources.them;
            this.btnAddDocGia.ImageSize = new System.Drawing.Size(35, 20);
            this.btnAddDocGia.Location = new System.Drawing.Point(1004, 25);
            this.btnAddDocGia.Name = "btnAddDocGia";
            this.btnAddDocGia.Size = new System.Drawing.Size(182, 44);
            this.btnAddDocGia.TabIndex = 16;
            this.btnAddDocGia.Text = "Thêm độc giả";
            this.btnAddDocGia.Click += new System.EventHandler(this.btnAddDocGia_Click_1);
            // 
            // GUI_QuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 791);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_QuanLyDocGia";
            this.Text = "GUI_QuanLyDocGia";
            this.Load += new System.EventHandler(this.GUI_QuanLyDocGia_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnLoadList;
        private Guna.UI2.WinForms.Guna2Button btnAddDocGia;
    }
}