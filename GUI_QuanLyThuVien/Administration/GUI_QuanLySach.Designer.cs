namespace GUI_QuanLyThuVien
{
    partial class GUI_QuanLySach
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
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtg1 = new System.Windows.Forms.DataGridView();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddBook.Location = new System.Drawing.Point(598, 25);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(260, 47);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Thêm sách mới";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Location = new System.Drawing.Point(930, 25);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(210, 47);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDel.Location = new System.Drawing.Point(1224, 25);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(210, 47);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa sách";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRefesh);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAddBook);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1720, 100);
            this.panel1.TabIndex = 4;
            // 
            // dtg1
            // 
            this.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg1.Location = new System.Drawing.Point(0, 100);
            this.dtg1.Name = "dtg1";
            this.dtg1.RowHeadersWidth = 51;
            this.dtg1.RowTemplate.Height = 24;
            this.dtg1.Size = new System.Drawing.Size(1720, 880);
            this.dtg1.TabIndex = 5;
            this.dtg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg1_CellClick);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefesh.Location = new System.Drawing.Point(127, 25);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(169, 47);
            this.btnRefesh.TabIndex = 4;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(341, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tìm sách ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GUI_QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 980);
            this.Controls.Add(this.dtg1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_QuanLySach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_QuanLySach";
            this.Load += new System.EventHandler(this.GUI_QuanLySach_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtg1;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button button1;
    }
}