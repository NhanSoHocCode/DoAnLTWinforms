namespace GUI_QuanLyThuVien.Administration.QLDocGia
{
    partial class GUI_ReportDocGia
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
            this.uiBreadcrumb1 = new Sunny.UI.UIBreadcrumb();
            this.uiBreadcrumb2 = new Sunny.UI.UIBreadcrumb();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // uiBreadcrumb1
            // 
            this.uiBreadcrumb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiBreadcrumb1.ItemWidth = 179;
            this.uiBreadcrumb1.Location = new System.Drawing.Point(0, 0);
            this.uiBreadcrumb1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBreadcrumb1.Name = "uiBreadcrumb1";
            this.uiBreadcrumb1.Size = new System.Drawing.Size(100, 29);
            this.uiBreadcrumb1.TabIndex = 0;
            this.uiBreadcrumb1.Text = "uiBreadcrumb1";
            this.uiBreadcrumb1.UnSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            // 
            // uiBreadcrumb2
            // 
            this.uiBreadcrumb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiBreadcrumb2.ItemWidth = 179;
            this.uiBreadcrumb2.Location = new System.Drawing.Point(8, 8);
            this.uiBreadcrumb2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBreadcrumb2.Name = "uiBreadcrumb2";
            this.uiBreadcrumb2.Size = new System.Drawing.Size(100, 29);
            this.uiBreadcrumb2.TabIndex = 1;
            this.uiBreadcrumb2.Text = "uiBreadcrumb2";
            this.uiBreadcrumb2.UnSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1240, 971);
            this.reportViewer1.TabIndex = 2;
            // 
            // GUI_ReportDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 971);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.uiBreadcrumb2);
            this.Controls.Add(this.uiBreadcrumb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GUI_ReportDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_ReportDocGia";
            this.Load += new System.EventHandler(this.GUI_ReportDocGia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIBreadcrumb uiBreadcrumb1;
        private Sunny.UI.UIBreadcrumb uiBreadcrumb2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}