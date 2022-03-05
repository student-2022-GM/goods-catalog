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
    }
}