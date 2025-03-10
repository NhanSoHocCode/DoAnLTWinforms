namespace GUI_QuanLyThuVien
{
    partial class BookItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.lbname = new System.Windows.Forms.Label();
            this.lbquantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbImage
            // 
            this.ptbImage.Location = new System.Drawing.Point(58, 3);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(160, 249);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImage.TabIndex = 0;
            this.ptbImage.TabStop = false;
            this.ptbImage.Click += new System.EventHandler(this.ptbImage_Click);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(66, 289);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(44, 16);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "label1";
            // 
            // lbquantity
            // 
            this.lbquantity.AutoSize = true;
            this.lbquantity.Location = new System.Drawing.Point(101, 337);
            this.lbquantity.Name = "lbquantity";
            this.lbquantity.Size = new System.Drawing.Size(44, 16);
            this.lbquantity.TabIndex = 2;
            this.lbquantity.Text = "label2";
            // 
            // BookItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbquantity);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.ptbImage);
            this.Name = "BookItem";
            this.Size = new System.Drawing.Size(278, 371);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox ptbImage;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbquantity;
    }
}
