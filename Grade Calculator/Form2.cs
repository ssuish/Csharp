using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Calculator
{
    public partial class FormSignup : Form
    {
        public FormSignup()
        {
            InitializeComponent();
        }

        private void buttonToLogin_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.Show();
        }

        private string logininfo = string.Empty;

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            string _logininfo = textBoxUsername.Text + "" + textBoxPwd;
        }

        private void buttonShowPwd_Click(object sender, EventArgs e)
        {

        }
    }
}
