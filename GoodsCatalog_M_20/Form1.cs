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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login loginWindow = new GoodsCatalog_M_20.Login();
            if (loginWindow.ShowDialog() == DialogResult.OK)
            {
                string login = loginWindow.UserLogin;
                string password = loginWindow.UserPassword;
                if (login == "admin" && password == "pass")
                {
                    MessageBox.Show("Access granted !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Access denied !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
                this.Close();
        }

        private void registrationMainButton_Click(object sender, EventArgs e)
        {
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
                        new XAttribute("email", email)
                            )
                        );
                    registerWindow.userDocument.Save(GoodsCatalog_M_20.Register.userDataPath);
                }

            }
        }
    }
}