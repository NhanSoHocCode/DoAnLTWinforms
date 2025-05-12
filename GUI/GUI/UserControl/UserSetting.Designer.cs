namespace GUI.UserControl
{
    partial class UserSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSetting));
            SATAUiFramework.BorderRadius borderRadius3 = new SATAUiFramework.BorderRadius();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMaDocGia = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictbSourceImage = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pane = new System.Windows.Forms.Panel();
            this.cbbSet = new Sunny.UI.UIComboBox();
            this.btnSearchFile = new FrameworkTest.SATAButton();
            this.datepBirth = new Sunny.UI.UIDatePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSdt = new Sunny.UI.UITextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmail = new Sunny.UI.UITextBox();
            this.txtAnhThe = new Sunny.UI.UITextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new Sunny.UI.UITextBox();
            this.txtPass = new Sunny.UI.UITextBox();
            this.txtUser = new Sunny.UI.UITextBox();
            this.txtName = new Sunny.UI.UITextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbSourceImage)).BeginInit();
            this.pane.SuspendLayout();
            this.sataPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMaDocGia);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 96);
            this.panel1.TabIndex = 0;
            // 
            // lbMaDocGia
            // 
            this.lbMaDocGia.AutoSize = true;
            this.lbMaDocGia.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lbMaDocGia.ForeColor = System.Drawing.Color.White;
            this.lbMaDocGia.Location = new System.Drawing.Point(348, 38);
            this.lbMaDocGia.Name = "lbMaDocGia";
            this.lbMaDocGia.Size = new System.Drawing.Size(144, 26);
            this.lbMaDocGia.TabIndex = 18;
            this.lbMaDocGia.Text = "Mã Độc Giả ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1282, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Setting";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(161, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(181, 26);
            this.label15.TabIndex = 17;
            this.label15.Text = "Code Customer";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictbSourceImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1123, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 801);
            this.panel2.TabIndex = 1;
            // 
            // pictbSourceImage
            // 
            this.pictbSourceImage.Image = ((System.Drawing.Image)(resources.GetObject("pictbSourceImage.Image")));
            this.pictbSourceImage.Location = new System.Drawing.Point(68, 22);
            this.pictbSourceImage.Name = "pictbSourceImage";
            this.pictbSourceImage.Size = new System.Drawing.Size(120, 118);
            this.pictbSourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbSourceImage.TabIndex = 14;
            this.pictbSourceImage.TabStop = false;
            this.pictbSourceImage.Click += new System.EventHandler(this.pictbSourceImage_Click);
            // 
            // pane
            // 
            this.pane.Controls.Add(this.cbbSet);
            this.pane.Controls.Add(this.btnSearchFile);
            this.pane.Controls.Add(this.datepBirth);
            this.pane.Controls.Add(this.label16);
            this.pane.Controls.Add(this.txtSdt);
            this.pane.Controls.Add(this.label14);
            this.pane.Controls.Add(this.txtEmail);
            this.pane.Controls.Add(this.txtAnhThe);
            this.pane.Controls.Add(this.label5);
            this.pane.Controls.Add(this.label13);
            this.pane.Controls.Add(this.sataPanel1);
            this.pane.Controls.Add(this.label9);
            this.pane.Controls.Add(this.label10);
            this.pane.Controls.Add(this.label7);
            this.pane.Controls.Add(this.label8);
            this.pane.Controls.Add(this.label6);
            this.pane.Controls.Add(this.txtAddress);
            this.pane.Controls.Add(this.txtPass);
            this.pane.Controls.Add(this.txtUser);
            this.pane.Controls.Add(this.txtName);
            this.pane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pane.Location = new System.Drawing.Point(0, 96);
            this.pane.Name = "pane";
            this.pane.Size = new System.Drawing.Size(1123, 801);
            this.pane.TabIndex = 3;
            // 
            // cbbSet
            // 
            this.cbbSet.DataSource = null;
            this.cbbSet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.cbbSet.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.cbbSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbSet.ForeColor = System.Drawing.Color.White;
            this.cbbSet.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbbSet.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbSet.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbbSet.Location = new System.Drawing.Point(183, 241);
            this.cbbSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbSet.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbSet.Name = "cbbSet";
            this.cbbSet.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbSet.Size = new System.Drawing.Size(150, 29);
            this.cbbSet.SymbolSize = 24;
            this.cbbSet.TabIndex = 20;
            this.cbbSet.Text = "null";
            this.cbbSet.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbSet.Watermark = "";
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.ButtonText = "Chọn ảnh";
            this.btnSearchFile.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.btnSearchFile.CheckedForeColor = System.Drawing.Color.White;
            this.btnSearchFile.CheckedImageTint = System.Drawing.Color.White;
            this.btnSearchFile.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.btnSearchFile.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearchFile.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFile.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnSearchFile.HoverForeColor = System.Drawing.Color.White;
            this.btnSearchFile.HoverImage = null;
            this.btnSearchFile.HoverImageTint = System.Drawing.Color.White;
            this.btnSearchFile.HoverOutline = System.Drawing.Color.Empty;
            this.btnSearchFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchFile.Image")));
            this.btnSearchFile.ImageAutoCenter = false;
            this.btnSearchFile.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSearchFile.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnSearchFile.ImageTint = System.Drawing.Color.White;
            this.btnSearchFile.IsToggleButton = false;
            this.btnSearchFile.IsToggled = false;
            this.btnSearchFile.Location = new System.Drawing.Point(629, 206);
            this.btnSearchFile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.btnSearchFile.NormalForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchFile.NormalOutline = System.Drawing.Color.Empty;
            this.btnSearchFile.OutlineThickness = 2F;
            this.btnSearchFile.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnSearchFile.PressedForeColor = System.Drawing.Color.White;
            this.btnSearchFile.PressedImageTint = System.Drawing.Color.White;
            this.btnSearchFile.PressedOutline = System.Drawing.Color.Empty;
            this.btnSearchFile.Rounding = new System.Windows.Forms.Padding(5);
            this.btnSearchFile.Size = new System.Drawing.Size(233, 39);
            this.btnSearchFile.TabIndex = 17;
            this.btnSearchFile.TextAutoCenter = false;
            this.btnSearchFile.TextOffset = new System.Drawing.Point(15, 0);
            this.btnSearchFile.Click += new System.EventHandler(this.btnSearchFile_Click);
            // 
            // datepBirth
            // 
            this.datepBirth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.datepBirth.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.datepBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datepBirth.ForeColor = System.Drawing.Color.White;
            this.datepBirth.Location = new System.Drawing.Point(183, 99);
            this.datepBirth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datepBirth.MaxLength = 10;
            this.datepBirth.MinimumSize = new System.Drawing.Size(63, 0);
            this.datepBirth.Name = "datepBirth";
            this.datepBirth.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.datepBirth.Size = new System.Drawing.Size(150, 29);
            this.datepBirth.SymbolDropDown = 61555;
            this.datepBirth.SymbolNormal = 61555;
            this.datepBirth.SymbolSize = 24;
            this.datepBirth.TabIndex = 19;
            this.datepBirth.Text = "2025-04-28";
            this.datepBirth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.datepBirth.Value = new System.DateTime(2025, 4, 28, 20, 13, 43, 919);
            this.datepBirth.Watermark = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(462, 274);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 26);
            this.label16.TabIndex = 18;
            this.label16.Text = "Email";
            // 
            // txtSdt
            // 
            this.txtSdt.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtSdt.ButtonStyleInherited = false;
            this.txtSdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSdt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtSdt.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtSdt.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtSdt.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSdt.ForeColor = System.Drawing.Color.White;
            this.txtSdt.Location = new System.Drawing.Point(183, 152);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSdt.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Padding = new System.Windows.Forms.Padding(5);
            this.txtSdt.Radius = 20;
            this.txtSdt.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtSdt.ShowText = false;
            this.txtSdt.Size = new System.Drawing.Size(278, 55);
            this.txtSdt.TabIndex = 5;
            this.txtSdt.Text = "txtSdt";
            this.txtSdt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSdt.Watermark = "";
            this.txtSdt.WatermarkActiveColor = System.Drawing.Color.Silver;
            this.txtSdt.WatermarkColor = System.Drawing.Color.Silver;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(22, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 26);
            this.label14.TabIndex = 17;
            this.label14.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtEmail.ButtonStyleInherited = false;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtEmail.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtEmail.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtEmail.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(617, 258);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(5);
            this.txtEmail.Radius = 20;
            this.txtEmail.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtEmail.ShowText = false;
            this.txtEmail.Size = new System.Drawing.Size(416, 55);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Text = "Password";
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.Watermark = "";
            this.txtEmail.WatermarkActiveColor = System.Drawing.Color.Silver;
            this.txtEmail.WatermarkColor = System.Drawing.Color.Silver;
            // 
            // txtAnhThe
            // 
            this.txtAnhThe.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtAnhThe.ButtonStyleInherited = false;
            this.txtAnhThe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnhThe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtAnhThe.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtAnhThe.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtAnhThe.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtAnhThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAnhThe.ForeColor = System.Drawing.Color.White;
            this.txtAnhThe.Location = new System.Drawing.Point(629, 140);
            this.txtAnhThe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnhThe.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAnhThe.Name = "txtAnhThe";
            this.txtAnhThe.Padding = new System.Windows.Forms.Padding(5);
            this.txtAnhThe.Radius = 20;
            this.txtAnhThe.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtAnhThe.ShowText = false;
            this.txtAnhThe.Size = new System.Drawing.Size(448, 55);
            this.txtAnhThe.TabIndex = 5;
            this.txtAnhThe.Text = "Password";
            this.txtAnhThe.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAnhThe.Watermark = "";
            this.txtAnhThe.WatermarkActiveColor = System.Drawing.Color.Silver;
            this.txtAnhThe.WatermarkColor = System.Drawing.Color.Silver;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(468, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 26);
            this.label13.TabIndex = 15;
            this.label13.Text = "Ảnh Thẻ";
            // 
            // sataPanel1
            // 
            this.sataPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.sataPanel1.BorderColor = System.Drawing.Color.Black;
            borderRadius3.BottomLeft = 20;
            borderRadius3.BottomRight = 20;
            borderRadius3.TopLeft = 20;
            borderRadius3.TopRight = 20;
            this.sataPanel1.BorderRadius = borderRadius3;
            this.sataPanel1.BorderThickness = 0;
            this.sataPanel1.Controls.Add(this.uiButton1);
            this.sataPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sataPanel1.Location = new System.Drawing.Point(0, 676);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(1123, 125);
            this.sataPanel1.TabIndex = 14;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.uiButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.uiButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.uiButton1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(126)))), ((int)(((byte)(52)))));
            this.uiButton1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(126)))), ((int)(((byte)(52)))));
            this.uiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton1.Location = new System.Drawing.Point(368, 26);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 30;
            this.uiButton1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.uiButton1.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(126)))), ((int)(((byte)(52)))));
            this.uiButton1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(126)))), ((int)(((byte)(52)))));
            this.uiButton1.Size = new System.Drawing.Size(236, 69);
            this.uiButton1.TabIndex = 13;
            this.uiButton1.Text = "Cập Nhập";
            this.uiButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(22, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 26);
            this.label9.TabIndex = 12;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(22, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 26);
            this.label10.TabIndex = 11;
            this.label10.Text = "Set";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "Birthday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(474, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 26);
            this.label8.TabIndex = 9;
            this.label8.Text = "Pass";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(474, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "User";
            // 
            // txtAddress
            // 
            this.txtAddress.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtAddress.ButtonStyleInherited = false;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtAddress.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtAddress.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtAddress.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(175, 287);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(5);
            this.txtAddress.Radius = 20;
            this.txtAddress.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtAddress.ShowText = false;
            this.txtAddress.Size = new System.Drawing.Size(199, 55);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Text = "Địa Chỉ";
            this.txtAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAddress.Watermark = "";
            this.txtAddress.WatermarkActiveColor = System.Drawing.Color.Silver;
            this.txtAddress.WatermarkColor = System.Drawing.Color.Silver;
            // 
            // txtPass
            // 
            this.txtPass.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtPass.ButtonStyleInherited = false;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtPass.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtPass.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtPass.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(629, 75);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPass.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPass.Name = "txtPass";
            this.txtPass.Padding = new System.Windows.Forms.Padding(5);
            this.txtPass.Radius = 20;
            this.txtPass.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtPass.ShowText = false;
            this.txtPass.Size = new System.Drawing.Size(448, 55);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "Password";
            this.txtPass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPass.Watermark = "";
            this.txtPass.WatermarkActiveColor = System.Drawing.Color.Silver;
            this.txtPass.WatermarkColor = System.Drawing.Color.Silver;
            // 
            // txtUser
            // 
            this.txtUser.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtUser.ButtonStyleInherited = false;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtUser.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtUser.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtUser.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(629, 10);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtUser.Name = "txtUser";
            this.txtUser.Padding = new System.Windows.Forms.Padding(5);
            this.txtUser.Radius = 20;
            this.txtUser.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtUser.ShowText = false;
            this.txtUser.Size = new System.Drawing.Size(448, 55);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "UserName";
            this.txtUser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUser.Watermark = "";
            this.txtUser.WatermarkActiveColor = System.Drawing.Color.Silver;
            this.txtUser.WatermarkColor = System.Drawing.Color.Silver;
            // 
            // txtName
            // 
            this.txtName.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtName.ButtonStyleInherited = false;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtName.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtName.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtName.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(176, 10);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(5);
            this.txtName.Radius = 20;
            this.txtName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.txtName.ShowText = false;
            this.txtName.Size = new System.Drawing.Size(338, 55);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Tên";
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtName.Watermark = "";
            this.txtName.WatermarkActiveColor = System.Drawing.Color.Silver;
            this.txtName.WatermarkColor = System.Drawing.Color.Silver;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1363, 897);
            this.Controls.Add(this.pane);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserSetting";
            this.Text = "UserMenu";
            this.Load += new System.EventHandler(this.UserSetting_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictbSourceImage)).EndInit();
            this.pane.ResumeLayout(false);
            this.pane.PerformLayout();
            this.sataPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel pane;
        private System.Windows.Forms.PictureBox pictbSourceImage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Sunny.UI.UITextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UITextBox txtAddress;
        private Sunny.UI.UITextBox txtPass;
        private Sunny.UI.UITextBox txtUser;
        private SATAUiFramework.SATAPanel sataPanel1;
        private Sunny.UI.UIButton uiButton1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private Sunny.UI.UITextBox txtAnhThe;
        private Sunny.UI.UITextBox txtEmail;
        private System.Windows.Forms.Label lbMaDocGia;
        private Sunny.UI.UITextBox txtSdt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private Sunny.UI.UIDatePicker datepBirth;
        private FrameworkTest.SATAButton btnSearchFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Sunny.UI.UIComboBox cbbSet;
    }
}