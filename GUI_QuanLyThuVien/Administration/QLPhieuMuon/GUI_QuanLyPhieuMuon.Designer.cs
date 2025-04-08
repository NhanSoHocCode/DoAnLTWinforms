namespace GUI_QuanLyThuVien.Administration
{
    partial class GUI_QuanLyPhieuMuon
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtg1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListCanhCaoQuaHan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefesh = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchPhieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtg1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1257, 767);
            this.panel2.TabIndex = 7;
            // 
            // dtg1
            // 
            this.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg1.Location = new System.Drawing.Point(1, 1);
            this.dtg1.Name = "dtg1";
            this.dtg1.RowHeadersWidth = 51;
            this.dtg1.RowTemplate.Height = 24;
            this.dtg1.Size = new System.Drawing.Size(1702, 767);
            this.dtg1.TabIndex = 0;
            this.dtg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GUI_QuanLyThuVien.Properties.Resources.cc;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnListCanhCaoQuaHan);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnRefesh);
            this.panel1.Controls.Add(this.txtSearchPhieu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 166);
            this.panel1.TabIndex = 6;
            // 
            // btnListCanhCaoQuaHan
            // 
            this.btnListCanhCaoQuaHan.Animated = true;
            this.btnListCanhCaoQuaHan.AutoRoundedCorners = true;
            this.btnListCanhCaoQuaHan.BackColor = System.Drawing.Color.Transparent;
            this.btnListCanhCaoQuaHan.BorderRadius = 21;
            this.btnListCanhCaoQuaHan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListCanhCaoQuaHan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListCanhCaoQuaHan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListCanhCaoQuaHan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListCanhCaoQuaHan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnListCanhCaoQuaHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnListCanhCaoQuaHan.ForeColor = System.Drawing.Color.White;
            this.btnListCanhCaoQuaHan.Location = new System.Drawing.Point(1031, 50);
            this.btnListCanhCaoQuaHan.Name = "btnListCanhCaoQuaHan";
            this.btnListCanhCaoQuaHan.Size = new System.Drawing.Size(167, 45);
            this.btnListCanhCaoQuaHan.TabIndex = 16;
            this.btnListCanhCaoQuaHan.Text = "Danh sách cảnh báo";
            this.btnListCanhCaoQuaHan.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnDel
            // 
            this.btnDel.Animated = true;
            this.btnDel.AutoRoundedCorners = true;
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BorderRadius = 21;
            this.btnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(718, 50);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(169, 45);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "Xoá phiếu";
            this.btnDel.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.AutoRoundedCorners = true;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 21;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(369, 50);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(169, 45);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Sửa phiếu";
            this.btnEdit.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Animated = true;
            this.btnRefesh.AutoRoundedCorners = true;
            this.btnRefesh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefesh.BorderRadius = 21;
            this.btnRefesh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefesh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefesh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefesh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefesh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnRefesh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefesh.ForeColor = System.Drawing.Color.White;
            this.btnRefesh.Location = new System.Drawing.Point(12, 50);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(166, 45);
            this.btnRefesh.TabIndex = 1;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtSearchPhieu
            // 
            this.txtSearchPhieu.Animated = true;
            this.txtSearchPhieu.AutoRoundedCorners = true;
            this.txtSearchPhieu.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchPhieu.BorderRadius = 18;
            this.txtSearchPhieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchPhieu.DefaultText = "";
            this.txtSearchPhieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchPhieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchPhieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchPhieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchPhieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchPhieu.Location = new System.Drawing.Point(269, 110);
            this.txtSearchPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchPhieu.Name = "txtSearchPhieu";
            this.txtSearchPhieu.PasswordChar = '\0';
            this.txtSearchPhieu.PlaceholderText = "Search theo mã phiếu mượn hoặc tên độc giả";
            this.txtSearchPhieu.SelectedText = "";
            this.txtSearchPhieu.Size = new System.Drawing.Size(745, 39);
            this.txtSearchPhieu.TabIndex = 13;
            this.txtSearchPhieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchPhieu_KeyDown);
            // 
            // GUI_QuanLyPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 933);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_QuanLyPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyPhieuMuon";
            this.Load += new System.EventHandler(this.GUI_QuanLyPhieuMuon_Load_1);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtg1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchPhieu;
        private Guna.UI2.WinForms.Guna2Button btnListCanhCaoQuaHan;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnRefesh;
    }
}