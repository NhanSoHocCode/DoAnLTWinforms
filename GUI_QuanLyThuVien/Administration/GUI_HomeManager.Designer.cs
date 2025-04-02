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
            this.btnthuthu = new System.Windows.Forms.Button();
            this.lbnameRole = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.btndocgia = new System.Windows.Forms.Button();
            this.btnpheiumuon = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxAdm = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthuthu
            // 
            this.btnthuthu.Location = new System.Drawing.Point(450, 3);
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
            this.lbnameRole.Location = new System.Drawing.Point(90, 37);
            this.lbnameRole.Name = "lbnameRole";
            this.lbnameRole.Size = new System.Drawing.Size(156, 16);
            this.lbnameRole.TabIndex = 3;
            this.lbnameRole.Text = "Quyền quản trị viên clone";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(90, 3);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(44, 16);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "admin";
            // 
            // btndocgia
            // 
            this.btndocgia.Location = new System.Drawing.Point(301, 3);
            this.btndocgia.Name = "btndocgia";
            this.btndocgia.Size = new System.Drawing.Size(143, 44);
            this.btndocgia.TabIndex = 1;
            this.btndocgia.Text = "Độc giả ";
            this.btndocgia.UseVisualStyleBackColor = true;
            this.btndocgia.Click += new System.EventHandler(this.btndocgia_Click);
            // 
            // btnpheiumuon
            // 
            this.btnpheiumuon.Location = new System.Drawing.Point(152, 3);
            this.btnpheiumuon.Name = "btnpheiumuon";
            this.btnpheiumuon.Size = new System.Drawing.Size(143, 44);
            this.btnpheiumuon.TabIndex = 2;
            this.btnpheiumuon.Text = "Phiếu mượn";
            this.btnpheiumuon.UseVisualStyleBackColor = true;
            this.btnpheiumuon.Click += new System.EventHandler(this.btnpheiumuon_Click);
            // 
            // btnSach
            // 
            this.btnSach.Location = new System.Drawing.Point(3, 3);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(143, 44);
            this.btnSach.TabIndex = 0;
            this.btnSach.Text = "Sách";
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.pictureBoxAdm);
            this.panel2.Controls.Add(this.lbnameRole);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.lbname);
            this.panel2.Location = new System.Drawing.Point(3, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1720, 139);
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
            this.panel3.Location = new System.Drawing.Point(6, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1720, 980);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonClose);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1086, 40);
            this.panel4.TabIndex = 3;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(791, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 40);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSach);
            this.flowLayoutPanel1.Controls.Add(this.btnpheiumuon);
            this.flowLayoutPanel1.Controls.Add(this.btndocgia);
            this.flowLayoutPanel1.Controls.Add(this.btnthuthu);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(356, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(666, 53);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // pictureBoxAdm
            // 
            this.pictureBoxAdm.BackgroundImage = global::GUI_QuanLyThuVien.Properties.Resources.phieuthu_icon;
            this.pictureBoxAdm.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxAdm.Name = "pictureBoxAdm";
            this.pictureBoxAdm.Size = new System.Drawing.Size(81, 119);
            this.pictureBoxAdm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdm.TabIndex = 4;
            this.pictureBoxAdm.TabStop = false;
            // 
            // GUI_HomeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_HomeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_HomeManager";
            this.Load += new System.EventHandler(this.GUI_HomeManager_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbnameRole;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnthuthu;
        private System.Windows.Forms.Button btnpheiumuon;
        private System.Windows.Forms.Button btndocgia;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.PictureBox pictureBoxAdm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}