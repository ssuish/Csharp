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
using System.Reflection;

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

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            Security aes = new Security();
            string userInfo = textBoxLogUsername.Text + "//" + textBoxLogPwrd.Text;
            string loginToken = aes.Encrypt(userInfo);

            string runTimeDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string dataDirectory = Path.Combine(runTimeDirectory, "Data");
            if (!Directory.Exists(dataDirectory))
                Directory.CreateDirectory(dataDirectory);

            TextWriter writerToken = new StreamWriter(Path.Combine(dataDirectory, "userData.txt"));
            writerToken.WriteLine(loginToken);
            writerToken.Close();
        }
    }
}
