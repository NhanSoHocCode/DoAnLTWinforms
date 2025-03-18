namespace GUI_QuanLyThuVien
{
    partial class GUI_DangNhap
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnpw = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCreateTKnew = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.linkForGetPass = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(46, 262);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(267, 15);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Username";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave_1);
            // 
            // txtPw
            // 
            this.txtPw.BackColor = System.Drawing.Color.White;
            this.txtPw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPw.Location = new System.Drawing.Point(46, 331);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(267, 15);
            this.txtPw.TabIndex = 2;
            this.txtPw.UseSystemPasswordChar = true;
            this.txtPw.Enter += new System.EventHandler(this.txtPw_Enter);
            this.txtPw.Leave += new System.EventHandler(this.txtPw_Leave);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(38, 243);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(102, 16);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Tên Đăng Nhập";
            // 
            // btnpw
            // 
            this.btnpw.AutoSize = true;
            this.btnpw.Location = new System.Drawing.Point(38, 312);
            this.btnpw.Name = "btnpw";
            this.btnpw.Size = new System.Drawing.Size(62, 16);
            this.btnpw.TabIndex = 3;
            this.btnpw.Text = "Mật Khẩu";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(15, 405);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(310, 31);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCreateTKnew
            // 
            this.btnCreateTKnew.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateTKnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTKnew.ForeColor = System.Drawing.Color.White;
            this.btnCreateTKnew.Location = new System.Drawing.Point(15, 456);
            this.btnCreateTKnew.Name = "btnCreateTKnew";
            this.btnCreateTKnew.Size = new System.Drawing.Size(310, 34);
            this.btnCreateTKnew.TabIndex = 4;
            this.btnCreateTKnew.Text = "Đăng Kí Tài Khoản Mới";
            this.btnCreateTKnew.UseVisualStyleBackColor = false;
            this.btnCreateTKnew.Click += new System.EventHandler(this.btnCreateTKnew_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Lime;
            this.btnclose.Location = new System.Drawing.Point(318, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(29, 23);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GUI_QuanLyThuVien.Properties.Resources.user;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(104, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(96, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Đăng Nhập ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI_QuanLyThuVien.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(15, 252);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::GUI_QuanLyThuVien.Properties.Resources.user;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(15, 321);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // linkForGetPass
            // 
            this.linkForGetPass.AutoSize = true;
            this.linkForGetPass.ForeColor = System.Drawing.Color.White;
            this.linkForGetPass.Location = new System.Drawing.Point(228, 367);
            this.linkForGetPass.Name = "linkForGetPass";
            this.linkForGetPass.Size = new System.Drawing.Size(97, 16);
            this.linkForGetPass.TabIndex = 5;
            this.linkForGetPass.TabStop = true;
            this.linkForGetPass.Text = "Quên Mật Khẩu";
            this.linkForGetPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForGetPass_LinkClicked);
            // 
            // GUI_DangNhap
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 588);
            this.Controls.Add(this.linkForGetPass);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnCreateTKnew);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnpw);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_DangNhap";
            this.Load += new System.EventHandler(this.GUI_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label btnpw;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCreateTKnew;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkForGetPass;
    }
}