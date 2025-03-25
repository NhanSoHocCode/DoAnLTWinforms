namespace GUI_QuanLyThuVien.User
{
    partial class GUI_NhapOTPDoiMatKhau
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.lbtimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbNameMail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặt lại mật khẩu";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã xác minh đã được gửi đến địa chỉ email";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vui lòng xác minh.";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã OTP của bạn";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.Location = new System.Drawing.Point(148, 332);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtOTP
            // 
            this.txtOTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOTP.Location = new System.Drawing.Point(161, 243);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(146, 22);
            this.txtOTP.TabIndex = 5;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnclose.Location = new System.Drawing.Point(402, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(35, 23);
            this.btnclose.TabIndex = 6;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lbtimer
            // 
            this.lbtimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbtimer.AutoSize = true;
            this.lbtimer.ForeColor = System.Drawing.Color.Red;
            this.lbtimer.Location = new System.Drawing.Point(73, 289);
            this.lbtimer.Name = "lbtimer";
            this.lbtimer.Size = new System.Drawing.Size(241, 16);
            this.lbtimer.TabIndex = 7;
            this.lbtimer.Text = "mã OTP của bạn có hiệu lực trong 120 s";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbNameMail
            // 
            this.lbNameMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNameMail.AutoSize = true;
            this.lbNameMail.ForeColor = System.Drawing.Color.Red;
            this.lbNameMail.Location = new System.Drawing.Point(173, 161);
            this.lbNameMail.Name = "lbNameMail";
            this.lbNameMail.Size = new System.Drawing.Size(59, 16);
            this.lbNameMail.TabIndex = 8;
            this.lbNameMail.Text = "Ten mail";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbNameMail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbtimer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtOTP);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Location = new System.Drawing.Point(21, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 419);
            this.panel1.TabIndex = 9;
            // 
            // GUI_NhapOTPDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_NhapOTPDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_NhapOTPDoiMatKhau";
            this.Load += new System.EventHandler(this.GUI_NhapOTPDoiMatKhau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lbtimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbNameMail;
        private System.Windows.Forms.Panel panel1;
    }
}