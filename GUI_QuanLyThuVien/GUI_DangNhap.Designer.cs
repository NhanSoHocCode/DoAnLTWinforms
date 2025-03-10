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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnQuenMK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(270, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(270, 142);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(100, 22);
            this.txtPw.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(167, 78);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // btnpw
            // 
            this.btnpw.AutoSize = true;
            this.btnpw.Location = new System.Drawing.Point(167, 148);
            this.btnpw.Name = "btnpw";
            this.btnpw.Size = new System.Drawing.Size(67, 16);
            this.btnpw.TabIndex = 3;
            this.btnpw.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(231, 240);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(365, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnQuenMK
            // 
            this.btnQuenMK.Location = new System.Drawing.Point(327, 328);
            this.btnQuenMK.Name = "btnQuenMK";
            this.btnQuenMK.Size = new System.Drawing.Size(75, 23);
            this.btnQuenMK.TabIndex = 6;
            this.btnQuenMK.Text = "tại đây";
            this.btnQuenMK.UseVisualStyleBackColor = true;
            this.btnQuenMK.Click += new System.EventHandler(this.btnQuenMK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "quên mật khẩu click ";
            // 
            // GUI_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuenMK);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnpw);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtName);
            this.Name = "GUI_DangNhap";
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
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnQuenMK;
        private System.Windows.Forms.Label label1;
    }
}