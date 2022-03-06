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

                XDocument userDocument = XDocument.Load(GoodsCatalog_M_20.Register.userDataPath);
                bool found = false;
                foreach (XElement element in userDocument.Root.Elements("user"))
                {
                    if (element.Attribute("login").Value == login && element.Attribute("password").Value == password)
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
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
    }
}