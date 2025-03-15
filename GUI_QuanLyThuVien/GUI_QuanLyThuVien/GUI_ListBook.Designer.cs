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
            this.SuspendLayout();
            // 
            // flpListBook
            // 
            this.flpListBook.AutoScroll = true;
            this.flpListBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpListBook.Location = new System.Drawing.Point(0, 62);
            this.flpListBook.Name = "flpListBook";
            this.flpListBook.Size = new System.Drawing.Size(800, 388);
            this.flpListBook.TabIndex = 0;
            // 
            // btnTinhYeu
            // 
            this.btnTinhYeu.Location = new System.Drawing.Point(105, 12);
            this.btnTinhYeu.Name = "btnTinhYeu";
            this.btnTinhYeu.Size = new System.Drawing.Size(93, 32);
            this.btnTinhYeu.TabIndex = 1;
            this.btnTinhYeu.Text = "Tình Yêu";
            this.btnTinhYeu.UseVisualStyleBackColor = true;
            this.btnTinhYeu.Click += new System.EventHandler(this.btnTinhYeu_Click);
            // 
            // btnDongVat
            // 
            this.btnDongVat.Location = new System.Drawing.Point(260, 12);
            this.btnDongVat.Name = "btnDongVat";
            this.btnDongVat.Size = new System.Drawing.Size(93, 32);
            this.btnDongVat.TabIndex = 2;
            this.btnDongVat.Text = "Động Vật";
            this.btnDongVat.UseVisualStyleBackColor = true;
            this.btnDongVat.Click += new System.EventHandler(this.btnDongVat_Click);
            // 
            // btnCongNghe
            // 
            this.btnCongNghe.Location = new System.Drawing.Point(432, 12);
            this.btnCongNghe.Name = "btnCongNghe";
            this.btnCongNghe.Size = new System.Drawing.Size(118, 32);
            this.btnCongNghe.TabIndex = 3;
            this.btnCongNghe.Text = "Công Nghệ";
            this.btnCongNghe.UseVisualStyleBackColor = true;
            this.btnCongNghe.Click += new System.EventHandler(this.btnCongNghe_Click);
            // 
            // btnDoiSong
            // 
            this.btnDoiSong.Location = new System.Drawing.Point(580, 12);
            this.btnDoiSong.Name = "btnDoiSong";
            this.btnDoiSong.Size = new System.Drawing.Size(93, 32);
            this.btnDoiSong.TabIndex = 4;
            this.btnDoiSong.Text = "Đời Sống";
            this.btnDoiSong.UseVisualStyleBackColor = true;
            this.btnDoiSong.Click += new System.EventHandler(this.btnDoiSong_Click);
            // 
            // GUI_ListBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoiSong);
            this.Controls.Add(this.btnCongNghe);
            this.Controls.Add(this.btnDongVat);
            this.Controls.Add(this.btnTinhYeu);
            this.Controls.Add(this.flpListBook);
            this.Name = "GUI_ListBook";
            this.Text = "GUI_ListBook";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpListBook;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnTinhYeu;
        private System.Windows.Forms.Button btnDongVat;
        private System.Windows.Forms.Button btnCongNghe;
        private System.Windows.Forms.Button btnDoiSong;
    }
}