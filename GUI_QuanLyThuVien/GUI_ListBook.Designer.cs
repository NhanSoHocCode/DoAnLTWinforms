namespace GUI_QuanLyThuVien
{
    partial class GUI_ListBook
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
            this.flpListBook = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnTinhYeu = new System.Windows.Forms.Button();
            this.btnDongVat = new System.Windows.Forms.Button();
            this.btnCongNghe = new System.Windows.Forms.Button();
            this.btnDoiSong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearchBook = new System.Windows.Forms.TextBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpListBook
            // 
            this.flpListBook.AutoScroll = true;
            this.flpListBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpListBook.Location = new System.Drawing.Point(0, 116);
            this.flpListBook.Name = "flpListBook";
            this.flpListBook.Size = new System.Drawing.Size(800, 334);
            this.flpListBook.TabIndex = 0;
            // 
            // btnTinhYeu
            // 
            this.btnTinhYeu.Location = new System.Drawing.Point(95, 68);
            this.btnTinhYeu.Name = "btnTinhYeu";
            this.btnTinhYeu.Size = new System.Drawing.Size(93, 32);
            this.btnTinhYeu.TabIndex = 1;
            this.btnTinhYeu.Text = "Tình Yêu";
            this.btnTinhYeu.UseVisualStyleBackColor = true;
            this.btnTinhYeu.Click += new System.EventHandler(this.btnTinhYeu_Click);
            // 
            // btnDongVat
            // 
            this.btnDongVat.Location = new System.Drawing.Point(258, 68);
            this.btnDongVat.Name = "btnDongVat";
            this.btnDongVat.Size = new System.Drawing.Size(93, 32);
            this.btnDongVat.TabIndex = 2;
            this.btnDongVat.Text = "Động Vật";
            this.btnDongVat.UseVisualStyleBackColor = true;
            this.btnDongVat.Click += new System.EventHandler(this.btnDongVat_Click);
            // 
            // btnCongNghe
            // 
            this.btnCongNghe.Location = new System.Drawing.Point(426, 68);
            this.btnCongNghe.Name = "btnCongNghe";
            this.btnCongNghe.Size = new System.Drawing.Size(118, 32);
            this.btnCongNghe.TabIndex = 3;
            this.btnCongNghe.Text = "Công Nghệ";
            this.btnCongNghe.UseVisualStyleBackColor = true;
            this.btnCongNghe.Click += new System.EventHandler(this.btnCongNghe_Click);
            // 
            // btnDoiSong
            // 
            this.btnDoiSong.Location = new System.Drawing.Point(585, 68);
            this.btnDoiSong.Name = "btnDoiSong";
            this.btnDoiSong.Size = new System.Drawing.Size(93, 32);
            this.btnDoiSong.TabIndex = 4;
            this.btnDoiSong.Text = "Đời Sống";
            this.btnDoiSong.UseVisualStyleBackColor = true;
            this.btnDoiSong.Click += new System.EventHandler(this.btnDoiSong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "thanh tim kiem";
            // 
            // tbxSearchBook
            // 
            this.tbxSearchBook.Location = new System.Drawing.Point(280, 18);
            this.tbxSearchBook.Name = "tbxSearchBook";
            this.tbxSearchBook.Size = new System.Drawing.Size(208, 22);
            this.tbxSearchBook.TabIndex = 6;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(515, 16);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(68, 35);
            this.btnSearchBook.TabIndex = 7;
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(713, 12);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(75, 65);
            this.btnCart.TabIndex = 8;
            this.btnCart.Text = "Giỏ Hàng";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // GUI_ListBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.tbxSearchBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoiSong);
            this.Controls.Add(this.btnCongNghe);
            this.Controls.Add(this.btnDongVat);
            this.Controls.Add(this.btnTinhYeu);
            this.Controls.Add(this.flpListBook);
            this.Name = "GUI_ListBook";
            this.Text = "GUI_ListBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpListBook;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnTinhYeu;
        private System.Windows.Forms.Button btnDongVat;
        private System.Windows.Forms.Button btnCongNghe;
        private System.Windows.Forms.Button btnDoiSong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearchBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnCart;
    }
}