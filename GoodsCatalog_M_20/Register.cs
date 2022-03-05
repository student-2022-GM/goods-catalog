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
    public partial class Register : Form
    {
        public string loginR { get; set; }
        public string passwordR { get; set; }
        public string passwordConfirmR { get; set; }
        public string nameR { get; set; }
        public string emailR { get; set; }
        public const string userDataPath = @"..\..\Data\users.xml";
        public XDocument userDocument = XDocument.Load(userDataPath);

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void registrationButtonOk_Click(object sender, EventArgs e)
        {
            loginR = loginTextBox.Text;
            passwordR = passwordOriginTextBox.Text;
            passwordConfirmR = confirmPasswordTextBox.Text;
            nameR = nameTextBox.Text;
            emailR = emailTextBox.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}