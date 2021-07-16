using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAVapp
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void createAccountLabel_Click(object sender, EventArgs e)
        {
            new CreateAccount().Show();
        }

        private void forgotPasswdLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ForgotPasswd().Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
