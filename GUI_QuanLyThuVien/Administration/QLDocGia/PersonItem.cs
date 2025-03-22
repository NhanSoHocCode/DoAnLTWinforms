using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLyThuVien;
using GUI_QuanLyThuVien.Administration.QLDocGia;
namespace GUI_QuanLyThuVien.Administration
{
    public partial class PersonItem : UserControl
    {
        public PersonItem()
        {
            InitializeComponent();
        }
        public DTO_Person person;

        private void PersonItem_Load(object sender, EventArgs e)  // them phan khi nhan vao item thi hien them form thong tin chi tiet (co them vai chuc nang nho trong do )
        {
            lbName.Text = person.sHoTen;
            if (person.sGioiTinh == true)
            {
                lbSet.Text = "Giới tính Nam";
            } else
            {
                lbSet.Text = "Giới tính Nữ";
            }
            lbMa.Text =  "Mã: "+ person.sMa;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string path = "D:\\K25_Project_LTWinform\\DoAn\\images\\" + person.sSourceImage;
            pictureBox1.Image = Image.FromFile(path);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GUI_ControlChiTietDocGia gui_ControlChiTietDocGia = new GUI_ControlChiTietDocGia();
            gui_ControlChiTietDocGia.person = person;
            gui_ControlChiTietDocGia.ShowDialog();

        }
    }
}
