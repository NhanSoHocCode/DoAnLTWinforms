namespace GUI.UserControl
{
    partial class UserMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btndecrea = new Sunny.UI.UIButton();
            this.btnIncrea = new Sunny.UI.UIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.sataButton1 = new FrameworkTest.SATAButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btndecrea);
            this.panel1.Controls.Add(this.btnIncrea);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 110);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.txtUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.txtUser.BorderRadius = 20;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtUser.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Location = new System.Drawing.Point(375, 29);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceholderText = "Search";
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(378, 33);
            this.txtUser.TabIndex = 31;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1262, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btndecrea
            // 
            this.btndecrea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndecrea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btndecrea.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btndecrea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btndecrea.Location = new System.Drawing.Point(156, 52);
            this.btndecrea.MinimumSize = new System.Drawing.Size(1, 1);
            this.btndecrea.Name = "btndecrea";
            this.btndecrea.Radius = 15;
            this.btndecrea.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btndecrea.Size = new System.Drawing.Size(122, 45);
            this.btndecrea.TabIndex = 5;
            this.btndecrea.Text = "Giá giảm dần";
            this.btndecrea.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btndecrea.Click += new System.EventHandler(this.btndecrea_Click);
            // 
            // btnIncrea
            // 
            this.btnIncrea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncrea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnIncrea.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnIncrea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIncrea.Location = new System.Drawing.Point(17, 52);
            this.btnIncrea.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnIncrea.Name = "btnIncrea";
            this.btnIncrea.Radius = 15;
            this.btnIncrea.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnIncrea.Size = new System.Drawing.Size(122, 45);
            this.btnIncrea.TabIndex = 4;
            this.btnIncrea.Text = "Giá tăng dần";
            this.btnIncrea.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnIncrea.Click += new System.EventHandler(this.btnIncrea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello 1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.sataButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1065, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 787);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hello Lâm Huy";
            // 
            // sataButton1
            // 
            this.sataButton1.ButtonText = "Giỏ Hàng";
            this.sataButton1.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.sataButton1.CheckedForeColor = System.Drawing.Color.White;
            this.sataButton1.CheckedImageTint = System.Drawing.Color.White;
            this.sataButton1.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.sataButton1.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.sataButton1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sataButton1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.sataButton1.HoverForeColor = System.Drawing.Color.White;
            this.sataButton1.HoverImage = null;
            this.sataButton1.HoverImageTint = System.Drawing.Color.White;
            this.sataButton1.HoverOutline = System.Drawing.Color.Empty;
            this.sataButton1.Image = ((System.Drawing.Image)(resources.GetObject("sataButton1.Image")));
            this.sataButton1.ImageAutoCenter = false;
            this.sataButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.sataButton1.ImageOffset = new System.Drawing.Point(15, 0);
            this.sataButton1.ImageTint = System.Drawing.Color.White;
            this.sataButton1.IsToggleButton = false;
            this.sataButton1.IsToggled = false;
            this.sataButton1.Location = new System.Drawing.Point(30, 77);
            this.sataButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sataButton1.Name = "sataButton1";
            this.sataButton1.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.sataButton1.NormalForeColor = System.Drawing.Color.WhiteSmoke;
            this.sataButton1.NormalOutline = System.Drawing.Color.Empty;
            this.sataButton1.OutlineThickness = 2F;
            this.sataButton1.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.sataButton1.PressedForeColor = System.Drawing.Color.White;
            this.sataButton1.PressedImageTint = System.Drawing.Color.White;
            this.sataButton1.PressedOutline = System.Drawing.Color.Empty;
            this.sataButton1.Rounding = new System.Windows.Forms.Padding(5);
            this.sataButton1.Size = new System.Drawing.Size(253, 62);
            this.sataButton1.TabIndex = 7;
            this.sataButton1.TextAutoCenter = false;
            this.sataButton1.TextOffset = new System.Drawing.Point(15, 0);
            this.sataButton1.Click += new System.EventHandler(this.sataButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 787);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // uiContextMenuStrip1
            // 
            this.uiContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiContextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1363, 897);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.Load += new System.EventHandler(this.UserMenu_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel3;
        private Sunny.UI.UIButton btndecrea;
        private Sunny.UI.UIButton btnIncrea;
        private System.Windows.Forms.Label label2;
        private FrameworkTest.SATAButton sataButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
    }
}