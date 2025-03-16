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
            this.btnQuenMK = new System.Windows.Forms.Button();
            this.btnCreateTKnew = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(73, 139);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(73, 208);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(183, 22);
            this.txtPw.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(70, 120);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // btnpw
            // 
            this.btnpw.AutoSize = true;
            this.btnpw.Location = new System.Drawing.Point(70, 189);
            this.btnpw.Name = "btnpw";
            this.btnpw.Size = new System.Drawing.Size(67, 16);
            this.btnpw.TabIndex = 3;
            this.btnpw.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(73, 268);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(183, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnQuenMK
            // 
            this.btnQuenMK.Location = new System.Drawing.Point(96, 348);
            this.btnQuenMK.Name = "btnQuenMK";
            this.btnQuenMK.Size = new System.Drawing.Size(141, 23);
            this.btnQuenMK.TabIndex = 6;
            this.btnQuenMK.Text = "Quên mật khẩu? ";
            this.btnQuenMK.UseVisualStyleBackColor = true;
            this.btnQuenMK.Click += new System.EventHandler(this.btnQuenMK_Click);
            // 
            // btnCreateTKnew
            // 
            this.btnCreateTKnew.Location = new System.Drawing.Point(73, 414);
            this.btnCreateTKnew.Name = "btnCreateTKnew";
            this.btnCreateTKnew.Size = new System.Drawing.Size(168, 35);
            this.btnCreateTKnew.TabIndex = 7;
            this.btnCreateTKnew.Text = "Tạo tài khoản mới";
            this.btnCreateTKnew.UseVisualStyleBackColor = true;
            this.btnCreateTKnew.Click += new System.EventHandler(this.btnCreateTKnew_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Lime;
            this.btnclose.Location = new System.Drawing.Point(280, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(29, 23);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // GUI_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 588);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnCreateTKnew);
            this.Controls.Add(this.btnQuenMK);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnpw);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label btnpw;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnQuenMK;
        private System.Windows.Forms.Button btnCreateTKnew;
        private System.Windows.Forms.Button btnclose;
    }
}