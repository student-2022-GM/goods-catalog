using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsCatalog_M_20
{
    public partial class Login : Form
    {
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void verifyLoginButton_Click(object sender, EventArgs e)
        {
            UserLogin = loginTextBox.Text;
            UserPassword = passwordTextBox.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}