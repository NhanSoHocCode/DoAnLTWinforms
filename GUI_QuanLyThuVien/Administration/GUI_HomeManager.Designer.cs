namespace GUI_QuanLyThuVien.Administration
{
    partial class GUI_HomeManager
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
            this.pictureBoxAdm = new System.Windows.Forms.PictureBox();
            this.btnthuthu = new System.Windows.Forms.Button();
            this.lbnameRole = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.btndocgia = new System.Windows.Forms.Button();
            this.btnpheiumuon = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdm)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxAdm);
            this.panel1.Controls.Add(this.btnthuthu);
            this.panel1.Controls.Add(this.lbnameRole);
            this.panel1.Controls.Add(this.lbname);
            this.panel1.Controls.Add(this.btndocgia);
            this.panel1.Controls.Add(this.btnpheiumuon);
            this.panel1.Controls.Add(this.btnSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1080);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxAdm
            // 
            this.pictureBoxAdm.Location = new System.Drawing.Point(31, 31);
            this.pictureBoxAdm.Name = "pictureBoxAdm";
            this.pictureBoxAdm.Size = new System.Drawing.Size(81, 119);
            this.pictureBoxAdm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdm.TabIndex = 4;
            this.pictureBoxAdm.TabStop = false;
            // 
            // btnthuthu
            // 
            this.btnthuthu.Location = new System.Drawing.Point(31, 575);
            this.btnthuthu.Name = "btnthuthu";
            this.btnthuthu.Size = new System.Drawing.Size(143, 44);
            this.btnthuthu.TabIndex = 3;
            this.btnthuthu.Text = "Thủ thư";
            this.btnthuthu.UseVisualStyleBackColor = true;
            this.btnthuthu.Click += new System.EventHandler(this.btnthuthu_Click);
            // 
            // lbnameRole
            // 
            this.lbnameRole.AutoSize = true;
            this.lbnameRole.Location = new System.Drawing.Point(28, 173);
            this.lbnameRole.Name = "lbnameRole";
            this.lbnameRole.Size = new System.Drawing.Size(156, 16);
            this.lbnameRole.TabIndex = 3;
            this.lbnameRole.Text = "Quyền quản trị viên clone";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(130, 134);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(44, 16);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "admin";
            // 
            // btndocgia
            // 
            this.btndocgia.Location = new System.Drawing.Point(31, 467);
            this.btndocgia.Name = "btndocgia";
            this.btndocgia.Size = new System.Drawing.Size(143, 44);
            this.btndocgia.TabIndex = 1;
            this.btndocgia.Text = "Độc giả ";
            this.btndocgia.UseVisualStyleBackColor = true;
            this.btndocgia.Click += new System.EventHandler(this.btndocgia_Click);
            // 
            // btnpheiumuon
            // 
            this.btnpheiumuon.Location = new System.Drawing.Point(31, 362);
            this.btnpheiumuon.Name = "btnpheiumuon";
            this.btnpheiumuon.Size = new System.Drawing.Size(143, 44);
            this.btnpheiumuon.TabIndex = 2;
            this.btnpheiumuon.Text = "Phiếu mượn";
            this.btnpheiumuon.UseVisualStyleBackColor = true;
            this.btnpheiumuon.Click += new System.EventHandler(this.btnpheiumuon_Click);
            // 
            // btnSach
            // 
            this.btnSach.Location = new System.Drawing.Point(31, 263);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(143, 44);
            this.btnSach.TabIndex = 0;
            this.btnSach.Text = "Sách";
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(926, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1720, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1654, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1720, 980);
            this.panel3.TabIndex = 2;
            // 
            // GUI_HomeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_HomeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_HomeManager";
            this.Load += new System.EventHandler(this.GUI_HomeManager_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdm)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbnameRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnthuthu;
        private System.Windows.Forms.Button btnpheiumuon;
        private System.Windows.Forms.Button btndocgia;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.PictureBox pictureBoxAdm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
    }
}