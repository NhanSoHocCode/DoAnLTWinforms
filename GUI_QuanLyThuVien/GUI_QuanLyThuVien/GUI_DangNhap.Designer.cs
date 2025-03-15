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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_DangNhap));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnpw = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnQuenMK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.palLogin = new System.Windows.Forms.Panel();
            this.lbBig = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.palLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(180, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(180, 124);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.Size = new System.Drawing.Size(269, 22);
            this.txtPw.TabIndex = 1;
            this.txtPw.TextChanged += new System.EventHandler(this.txtPw_TextChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbName.Location = new System.Drawing.Point(53, 60);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(102, 16);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Tên Đăng Nhập";
            // 
            // btnpw
            // 
            this.btnpw.AutoSize = true;
            this.btnpw.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnpw.Location = new System.Drawing.Point(53, 124);
            this.btnpw.Name = "btnpw";
            this.btnpw.Size = new System.Drawing.Size(62, 16);
            this.btnpw.TabIndex = 3;
            this.btnpw.Text = "Mật Khẩu";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(56, 207);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(144, 29);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(273, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 29);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnQuenMK
            // 
            this.btnQuenMK.Location = new System.Drawing.Point(248, 270);
            this.btnQuenMK.Name = "btnQuenMK";
            this.btnQuenMK.Size = new System.Drawing.Size(75, 23);
            this.btnQuenMK.TabIndex = 6;
            this.btnQuenMK.Text = "Tại Đây";
            this.btnQuenMK.UseVisualStyleBackColor = true;
            this.btnQuenMK.Click += new System.EventHandler(this.btnQuenMK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(68, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quên Mật Khẩu Click ";
            // 
            // palLogin
            // 
            this.palLogin.Controls.Add(this.txtName);
            this.palLogin.Controls.Add(this.btnQuenMK);
            this.palLogin.Controls.Add(this.label1);
            this.palLogin.Controls.Add(this.lbName);
            this.palLogin.Controls.Add(this.txtPw);
            this.palLogin.Controls.Add(this.btnLogin);
            this.palLogin.Controls.Add(this.btnExit);
            this.palLogin.Controls.Add(this.btnpw);
            this.palLogin.Location = new System.Drawing.Point(552, 107);
            this.palLogin.Name = "palLogin";
            this.palLogin.Size = new System.Drawing.Size(486, 365);
            this.palLogin.TabIndex = 8;
            // 
            // lbBig
            // 
            this.lbBig.AutoSize = true;
            this.lbBig.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBig.Location = new System.Drawing.Point(369, 53);
            this.lbBig.Name = "lbBig";
            this.lbBig.Size = new System.Drawing.Size(395, 33);
            this.lbBig.TabIndex = 8;
            this.lbBig.Text = "Hệ Thống Quản Lý Thư Viện";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(68, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 365);
            this.panel1.TabIndex = 9;
            // 
            // GUI_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_QuanLyThuVien.Properties.Resources.A;
            this.ClientSize = new System.Drawing.Size(1108, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbBig);
            this.Controls.Add(this.palLogin);
            this.Name = "GUI_DangNhap";
            this.Text = "GUI_DangNhap";
            this.palLogin.ResumeLayout(false);
            this.palLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label btnpw;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnQuenMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel palLogin;
        private System.Windows.Forms.Label lbBig;
        private System.Windows.Forms.Panel panel1;
    }
}