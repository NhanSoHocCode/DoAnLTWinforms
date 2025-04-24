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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btndecrea = new Sunny.UI.UIButton();
            this.btnIncrea = new Sunny.UI.UIButton();
            this.sataTextBox1 = new SATATextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sataButton5 = new FrameworkTest.SATAButton();
            this.sataButton4 = new FrameworkTest.SATAButton();
            this.sataButton3 = new FrameworkTest.SATAButton();
            this.sataButton2 = new FrameworkTest.SATAButton();
            this.sataButton1 = new FrameworkTest.SATAButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiButton1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btndecrea);
            this.panel1.Controls.Add(this.btnIncrea);
            this.panel1.Controls.Add(this.sataTextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 110);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(900, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // sataTextBox1
            // 
            this.sataTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.sataTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.sataTextBox1.BorderFocusColor = System.Drawing.Color.Red;
            this.sataTextBox1.BorderRadius = 18;
            this.sataTextBox1.BorderSize = 1;
            this.sataTextBox1.Icon = ((System.Drawing.Image)(resources.GetObject("sataTextBox1.Icon")));
            this.sataTextBox1.IconSize = new System.Drawing.Size(20, 20);
            this.sataTextBox1.Location = new System.Drawing.Point(634, 36);
            this.sataTextBox1.Multiline = false;
            this.sataTextBox1.Name = "sataTextBox1";
            this.sataTextBox1.PasswordChar = false;
            this.sataTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.sataTextBox1.PlaceholderText = "Search...";
            this.sataTextBox1.Size = new System.Drawing.Size(250, 36);
            this.sataTextBox1.TabIndex = 3;
            this.sataTextBox1.Text = "IT";
            this.sataTextBox1.Texts = "";
            this.sataTextBox1.UnderlinedStyle = false;
            this.sataTextBox1.TextChanged += new System.EventHandler(this.sataTextBox1_TextChanged);
            this.sataTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sataTextBox1_KeyPress);
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
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.sataButton5);
            this.panel2.Controls.Add(this.sataButton4);
            this.panel2.Controls.Add(this.sataButton3);
            this.panel2.Controls.Add(this.sataButton2);
            this.panel2.Controls.Add(this.sataButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1065, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 787);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "16.000.000.000 VNDC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số dư:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hello Lâm Huy";
            // 
            // sataButton5
            // 
            this.sataButton5.ButtonText = "Chức năng khác";
            this.sataButton5.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.sataButton5.CheckedForeColor = System.Drawing.Color.White;
            this.sataButton5.CheckedImageTint = System.Drawing.Color.White;
            this.sataButton5.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.sataButton5.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.sataButton5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sataButton5.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.sataButton5.HoverForeColor = System.Drawing.Color.White;
            this.sataButton5.HoverImage = null;
            this.sataButton5.HoverImageTint = System.Drawing.Color.White;
            this.sataButton5.HoverOutline = System.Drawing.Color.Empty;
            this.sataButton5.Image = ((System.Drawing.Image)(resources.GetObject("sataButton5.Image")));
            this.sataButton5.ImageAutoCenter = false;
            this.sataButton5.ImageExpand = new System.Drawing.Point(0, 0);
            this.sataButton5.ImageOffset = new System.Drawing.Point(15, 0);
            this.sataButton5.ImageTint = System.Drawing.Color.White;
            this.sataButton5.IsToggleButton = false;
            this.sataButton5.IsToggled = false;
            this.sataButton5.Location = new System.Drawing.Point(12, 469);
            this.sataButton5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sataButton5.Name = "sataButton5";
            this.sataButton5.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.sataButton5.NormalForeColor = System.Drawing.Color.WhiteSmoke;
            this.sataButton5.NormalOutline = System.Drawing.Color.Empty;
            this.sataButton5.OutlineThickness = 2F;
            this.sataButton5.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.sataButton5.PressedForeColor = System.Drawing.Color.White;
            this.sataButton5.PressedImageTint = System.Drawing.Color.White;
            this.sataButton5.PressedOutline = System.Drawing.Color.Empty;
            this.sataButton5.Rounding = new System.Windows.Forms.Padding(5);
            this.sataButton5.Size = new System.Drawing.Size(253, 62);
            this.sataButton5.TabIndex = 11;
            this.sataButton5.TextAutoCenter = false;
            this.sataButton5.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // sataButton4
            // 
            this.sataButton4.ButtonText = "Chức năng khác";
            this.sataButton4.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.sataButton4.CheckedForeColor = System.Drawing.Color.White;
            this.sataButton4.CheckedImageTint = System.Drawing.Color.White;
            this.sataButton4.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.sataButton4.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.sataButton4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sataButton4.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.sataButton4.HoverForeColor = System.Drawing.Color.White;
            this.sataButton4.HoverImage = null;
            this.sataButton4.HoverImageTint = System.Drawing.Color.White;
            this.sataButton4.HoverOutline = System.Drawing.Color.Empty;
            this.sataButton4.Image = ((System.Drawing.Image)(resources.GetObject("sataButton4.Image")));
            this.sataButton4.ImageAutoCenter = false;
            this.sataButton4.ImageExpand = new System.Drawing.Point(0, 0);
            this.sataButton4.ImageOffset = new System.Drawing.Point(15, 0);
            this.sataButton4.ImageTint = System.Drawing.Color.White;
            this.sataButton4.IsToggleButton = false;
            this.sataButton4.IsToggled = false;
            this.sataButton4.Location = new System.Drawing.Point(12, 321);
            this.sataButton4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sataButton4.Name = "sataButton4";
            this.sataButton4.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.sataButton4.NormalForeColor = System.Drawing.Color.WhiteSmoke;
            this.sataButton4.NormalOutline = System.Drawing.Color.Empty;
            this.sataButton4.OutlineThickness = 2F;
            this.sataButton4.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.sataButton4.PressedForeColor = System.Drawing.Color.White;
            this.sataButton4.PressedImageTint = System.Drawing.Color.White;
            this.sataButton4.PressedOutline = System.Drawing.Color.Empty;
            this.sataButton4.Rounding = new System.Windows.Forms.Padding(5);
            this.sataButton4.Size = new System.Drawing.Size(253, 62);
            this.sataButton4.TabIndex = 10;
            this.sataButton4.TextAutoCenter = false;
            this.sataButton4.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // sataButton3
            // 
            this.sataButton3.ButtonText = "Chức năng khác";
            this.sataButton3.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.sataButton3.CheckedForeColor = System.Drawing.Color.White;
            this.sataButton3.CheckedImageTint = System.Drawing.Color.White;
            this.sataButton3.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.sataButton3.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.sataButton3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sataButton3.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.sataButton3.HoverForeColor = System.Drawing.Color.White;
            this.sataButton3.HoverImage = null;
            this.sataButton3.HoverImageTint = System.Drawing.Color.White;
            this.sataButton3.HoverOutline = System.Drawing.Color.Empty;
            this.sataButton3.Image = ((System.Drawing.Image)(resources.GetObject("sataButton3.Image")));
            this.sataButton3.ImageAutoCenter = false;
            this.sataButton3.ImageExpand = new System.Drawing.Point(0, 0);
            this.sataButton3.ImageOffset = new System.Drawing.Point(15, 0);
            this.sataButton3.ImageTint = System.Drawing.Color.White;
            this.sataButton3.IsToggleButton = false;
            this.sataButton3.IsToggled = false;
            this.sataButton3.Location = new System.Drawing.Point(12, 395);
            this.sataButton3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sataButton3.Name = "sataButton3";
            this.sataButton3.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.sataButton3.NormalForeColor = System.Drawing.Color.WhiteSmoke;
            this.sataButton3.NormalOutline = System.Drawing.Color.Empty;
            this.sataButton3.OutlineThickness = 2F;
            this.sataButton3.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.sataButton3.PressedForeColor = System.Drawing.Color.White;
            this.sataButton3.PressedImageTint = System.Drawing.Color.White;
            this.sataButton3.PressedOutline = System.Drawing.Color.Empty;
            this.sataButton3.Rounding = new System.Windows.Forms.Padding(5);
            this.sataButton3.Size = new System.Drawing.Size(253, 62);
            this.sataButton3.TabIndex = 9;
            this.sataButton3.TextAutoCenter = false;
            this.sataButton3.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // sataButton2
            // 
            this.sataButton2.ButtonText = "Chức năng khác";
            this.sataButton2.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.sataButton2.CheckedForeColor = System.Drawing.Color.White;
            this.sataButton2.CheckedImageTint = System.Drawing.Color.White;
            this.sataButton2.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.sataButton2.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.sataButton2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sataButton2.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.sataButton2.HoverForeColor = System.Drawing.Color.White;
            this.sataButton2.HoverImage = null;
            this.sataButton2.HoverImageTint = System.Drawing.Color.White;
            this.sataButton2.HoverOutline = System.Drawing.Color.Empty;
            this.sataButton2.Image = ((System.Drawing.Image)(resources.GetObject("sataButton2.Image")));
            this.sataButton2.ImageAutoCenter = false;
            this.sataButton2.ImageExpand = new System.Drawing.Point(0, 0);
            this.sataButton2.ImageOffset = new System.Drawing.Point(15, 0);
            this.sataButton2.ImageTint = System.Drawing.Color.White;
            this.sataButton2.IsToggleButton = false;
            this.sataButton2.IsToggled = false;
            this.sataButton2.Location = new System.Drawing.Point(12, 247);
            this.sataButton2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sataButton2.Name = "sataButton2";
            this.sataButton2.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.sataButton2.NormalForeColor = System.Drawing.Color.WhiteSmoke;
            this.sataButton2.NormalOutline = System.Drawing.Color.Empty;
            this.sataButton2.OutlineThickness = 2F;
            this.sataButton2.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.sataButton2.PressedForeColor = System.Drawing.Color.White;
            this.sataButton2.PressedImageTint = System.Drawing.Color.White;
            this.sataButton2.PressedOutline = System.Drawing.Color.Empty;
            this.sataButton2.Rounding = new System.Windows.Forms.Padding(5);
            this.sataButton2.Size = new System.Drawing.Size(253, 62);
            this.sataButton2.TabIndex = 8;
            this.sataButton2.TextAutoCenter = false;
            this.sataButton2.TextOffset = new System.Drawing.Point(15, 0);
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
            this.sataButton1.Location = new System.Drawing.Point(12, 173);
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
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.uiButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.uiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton1.Location = new System.Drawing.Point(620, 33);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 15;
            this.uiButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.uiButton1.Size = new System.Drawing.Size(122, 45);
            this.uiButton1.TabIndex = 8;
            this.uiButton1.Text = "Giá tăng dần";
            this.uiButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private SATATextBox sataTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FrameworkTest.SATAButton sataButton5;
        private FrameworkTest.SATAButton sataButton4;
        private FrameworkTest.SATAButton sataButton3;
        private FrameworkTest.SATAButton sataButton2;
        private FrameworkTest.SATAButton sataButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Sunny.UI.UIButton uiButton1;
    }
}