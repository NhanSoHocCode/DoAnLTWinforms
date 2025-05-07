namespace GUI_QuanLyThuVien.Administration
{
    partial class GUI_QuanLyThuThu
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
            this.btnaddtt = new Guna.UI2.WinForms.Guna2Button();
            this.btnListTT = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GUI_QuanLyThuVien.Properties.Resources.cc;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnaddtt);
            this.panel1.Controls.Add(this.btnListTT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 90);
            this.panel1.TabIndex = 3;
            // 
            // btnaddtt
            // 
            this.btnaddtt.Animated = true;
            this.btnaddtt.AutoRoundedCorners = true;
            this.btnaddtt.BackColor = System.Drawing.Color.Transparent;
            this.btnaddtt.BorderRadius = 21;
            this.btnaddtt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaddtt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaddtt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaddtt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaddtt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnaddtt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnaddtt.ForeColor = System.Drawing.Color.White;
            this.btnaddtt.Image = global::GUI_QuanLyThuVien.Properties.Resources.them;
            this.btnaddtt.ImageSize = new System.Drawing.Size(35, 20);
            this.btnaddtt.Location = new System.Drawing.Point(1004, 25);
            this.btnaddtt.Name = "btnaddtt";
            this.btnaddtt.Size = new System.Drawing.Size(179, 44);
            this.btnaddtt.TabIndex = 7;
            this.btnaddtt.Text = "Thêm thủ thư";
            this.btnaddtt.Click += new System.EventHandler(this.btnaddtt_Click_1);
            // 
            // btnListTT
            // 
            this.btnListTT.Animated = true;
            this.btnListTT.AutoRoundedCorners = true;
            this.btnListTT.BackColor = System.Drawing.Color.Transparent;
            this.btnListTT.BorderRadius = 21;
            this.btnListTT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListTT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListTT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListTT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListTT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnListTT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnListTT.ForeColor = System.Drawing.Color.White;
            this.btnListTT.Image = global::GUI_QuanLyThuVien.Properties.Resources.eeg;
            this.btnListTT.Location = new System.Drawing.Point(53, 20);
            this.btnListTT.Name = "btnListTT";
            this.btnListTT.Size = new System.Drawing.Size(163, 44);
            this.btnListTT.TabIndex = 6;
            this.btnListTT.Text = "Xem danh sách";
            this.btnListTT.Click += new System.EventHandler(this.btnListTT_Click_1);
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
            this.txtSearch.PlaceholderText = "Search theo mã và tên thủ thư ";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(299, 39);
            this.txtSearch.TabIndex = 15;
            // 
            // GUI_QuanLyThuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 791);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_QuanLyThuThu";
            this.Text = "QuanLyThuThu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnaddtt;
        private Guna.UI2.WinForms.Guna2Button btnListTT;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}