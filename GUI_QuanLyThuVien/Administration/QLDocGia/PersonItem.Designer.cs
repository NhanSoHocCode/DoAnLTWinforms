namespace GUI_QuanLyThuVien.Administration
{
    partial class PersonItem
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
            this.lbMa = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSet = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMa
            // 
            this.lbMa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbMa.Location = new System.Drawing.Point(44, 9);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(100, 23);
            this.lbMa.TabIndex = 1;
            this.lbMa.Text = "Code";
            this.lbMa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbName.Location = new System.Drawing.Point(3, 191);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(179, 23);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Full Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSet
            // 
            this.lbSet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSet.Location = new System.Drawing.Point(19, 234);
            this.lbSet.Name = "lbSet";
            this.lbSet.Size = new System.Drawing.Size(125, 16);
            this.lbSet.TabIndex = 3;
            this.lbSet.Text = "Set";
            this.lbSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PersonItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbSet);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PersonItem";
            this.Size = new System.Drawing.Size(182, 270);
            this.Load += new System.EventHandler(this.PersonItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSet;
    }
}
