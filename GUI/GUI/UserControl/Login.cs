using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI.UserControl
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Close();
            if (false)
            {
                File.WriteAllText("Login.txt", "TK:\nMK:");
                
            }    
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {

        }
    }
}
