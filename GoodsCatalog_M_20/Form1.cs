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
using GoodsCatalog_M_20.Storage;
using GoodsCatalog_M_20.Models;
using GoodsCatalog_M_20.Services;

namespace GoodsCatalog_M_20
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1();
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

                password = SecurityManager.GetHash(password);
                var res = db.Accounts.Where(a => a.Login == login && a.Password == password).FirstOrDefault();
                if (res != null)
                {
                    MessageBox.Show("Access granted !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (login == "Admin_123") 
                    {
                        Products adminProductsWindow = new Products();
                        adminProductsWindow.Show();
                    }
                }
                else 
                {
                    MessageBox.Show("Access denied !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                /*
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
                */
            }
            else
                this.Close();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            db.Accounts.Add(new Account() { 
                Login = "Admin_123",
                Password = "928685e214fa387530cc8e14d09a1858"
            });

            db.Accounts.Add(new Account()
            {
                Login = "User_123",
                Password = "33f5b4c440a77f3743eb7545bae37805"
            });
            db.SaveChanges();
            MessageBox.Show("Ініціалізація", "Повідомлення",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}