namespace GUI_QuanLyThuVien.Administration
{
    partial class GUI_QuanLyThuThu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaddtt = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnListTT = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnaddtt);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnListTT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 90);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
            // 
            // btnaddtt
            // 
            this.btnaddtt.Location = new System.Drawing.Point(189, 51);
            this.btnaddtt.Name = "btnaddtt";
            this.btnaddtt.Size = new System.Drawing.Size(148, 37);
            this.btnaddtt.TabIndex = 1;
            this.btnaddtt.Text = "Thêm thủ thư";
            this.btnaddtt.UseVisualStyleBackColor = true;
            this.btnaddtt.Click += new System.EventHandler(this.btnaddtt_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(433, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(273, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // btnListTT
            // 
            this.btnListTT.Location = new System.Drawing.Point(24, 51);
            this.btnListTT.Name = "btnListTT";
            this.btnListTT.Size = new System.Drawing.Size(148, 37);
            this.btnListTT.TabIndex = 0;
            this.btnListTT.Text = "Xem danh sách ";
            this.btnListTT.UseVisualStyleBackColor = true;
            this.btnListTT.Click += new System.EventHandler(this.btnListTT_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 90);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 360);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // GUI_QuanLyThuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "GUI_QuanLyThuThu";
            this.Text = "QuanLyThuThu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddtt;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnListTT;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}