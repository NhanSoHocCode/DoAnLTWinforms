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
            this.btnListCanhCaoQuaHan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchPhieu = new System.Windows.Forms.TextBox();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
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
            this.panel2.Size = new System.Drawing.Size(1702, 767);
            this.panel2.TabIndex = 7;
            // 
            // dtg1
            // 
            this.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg1.Location = new System.Drawing.Point(0, 0);
            this.dtg1.Name = "dtg1";
            this.dtg1.RowHeadersWidth = 51;
            this.dtg1.RowTemplate.Height = 24;
            this.dtg1.Size = new System.Drawing.Size(1702, 767);
            this.dtg1.TabIndex = 0;
            this.dtg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg1_CellClick);
            this.dtg1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GUI_QuanLyThuVien.Properties.Resources._25;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnListCanhCaoQuaHan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearchPhieu);
            this.panel1.Controls.Add(this.btnRefesh);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1702, 166);
            this.panel1.TabIndex = 6;
            // 
            // btnListCanhCaoQuaHan
            // 
            this.btnListCanhCaoQuaHan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListCanhCaoQuaHan.Location = new System.Drawing.Point(1410, 46);
            this.btnListCanhCaoQuaHan.Name = "btnListCanhCaoQuaHan";
            this.btnListCanhCaoQuaHan.Size = new System.Drawing.Size(169, 47);
            this.btnListCanhCaoQuaHan.TabIndex = 11;
            this.btnListCanhCaoQuaHan.Text = "Danh sách cảnh cáo ";
            this.btnListCanhCaoQuaHan.UseVisualStyleBackColor = true;
            this.btnListCanhCaoQuaHan.Click += new System.EventHandler(this.btnListCanhCaoQuaHan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(502, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "lưu ý: search theo mã PM và tên độc giả ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSearchPhieu
            // 
            this.txtSearchPhieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchPhieu.Location = new System.Drawing.Point(500, 123);
            this.txtSearchPhieu.Multiline = true;
            this.txtSearchPhieu.Name = "txtSearchPhieu";
            this.txtSearchPhieu.Size = new System.Drawing.Size(725, 31);
            this.txtSearchPhieu.TabIndex = 8;
            this.txtSearchPhieu.TextChanged += new System.EventHandler(this.txtSearchPhieu_TextChanged);
            this.txtSearchPhieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchPhieu_KeyDown);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefesh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefesh.BackgroundImage = global::GUI_QuanLyThuVien.Properties.Resources.cc;
            this.btnRefesh.Location = new System.Drawing.Point(120, 48);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(166, 47);
            this.btnRefesh.TabIndex = 4;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDel.Location = new System.Drawing.Point(993, 47);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(169, 47);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa phiếu ";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Location = new System.Drawing.Point(545, 50);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(169, 47);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa phiếu";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // GUI_QuanLyPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1702, 933);
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
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchPhieu;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtg1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListCanhCaoQuaHan;
    }
}