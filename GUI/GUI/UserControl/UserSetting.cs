using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControl
{
    public partial class UserSetting : Form
    {
        private Form1 parentForm;
        Account Acc = new Account();
        public UserSetting(Form1 parentForm, Account Acc)
        {
            InitializeComponent();
            this.Acc = Acc;
            this.parentForm = parentForm;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            parentForm.Close();
        }
        private void UserSetting_Load_1(object sender, EventArgs e)
        {
            Load_Data();
        }
        private void Load_Data()
        {
            txtName.Text = Acc.Name;
            txtBirth.Text = Acc.Birth;
            txtGioitinh.Text = Acc.Gioitinh;
            txtPass.Text = Acc.Pass;
            txtUser.Text = Acc.User;
            txtAddress.Text = Acc.Address;
        }

        private void sataButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
