using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

        private void registrationButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Register registerWindow = new GoodsCatalog_M_20.Register();
            if (registerWindow.ShowDialog() == DialogResult.OK)
            {
                string log = registerWindow.loginR;
                string pass1 = registerWindow.passwordR;
                string pass2 = registerWindow.passwordConfirmR;
                string name = registerWindow.nameR;
                string email = registerWindow.emailR;
                if (log != "" && pass1 != "" && pass1 == pass2 && name != "" && email != "")
                {
                    registerWindow.userDocument.Element("root").Add(
                        new XElement("user",
                        new XAttribute("login", log),
                        new XAttribute("password", pass1),
                        new XAttribute("name", name),
                        new XAttribute("email", email.GetHashCode())
                            )
                        );
                    registerWindow.userDocument.Save(GoodsCatalog_M_20.Register.userDataPath);
                    MessageBox.Show("User was added !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Incorect information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
    }
}