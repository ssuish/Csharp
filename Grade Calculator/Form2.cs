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

        private bool checkFieldsIfEmpty()
        { 
            if (textBoxLogUsername.Text is null || textBoxLogUsername.Text.Length == 0)
            {
                if (textBoxEmail.Text is null || textBoxEmail.Text.Length == 0)
                {
                    if (textBoxLogPwrd.Text is null || textBoxLogPwrd.Text.Length == 0)
                    {
                        return true;
                    }

                    return true;
                }

                return true;
            }

            return false;
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            try
            {
                Security aes = new Security();

                string cap = string.Empty;
                string msg = string.Empty;

                if (!checkFieldsIfEmpty())
                {
                    if (textBoxLogPwrd.Text == textBoxRepeatPwrd.Text)
                    {
                        string userInfo = textBoxLogUsername.Text + "," + textBoxLogPwrd.Text;
                        string loginToken = aes.Encrypt(userInfo);

                        string runTimeDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        string dataDirectory = Path.Combine(runTimeDirectory, "Data");
                        if (!Directory.Exists(dataDirectory))
                            Directory.CreateDirectory(dataDirectory);

                        TextWriter writerToken = new StreamWriter(Path.Combine(dataDirectory, "userData.txt"));
                        writerToken.WriteLine(loginToken);
                        writerToken.Close();

                        cap = "Sign up successful";
                        msg = "You have created new account! Please proceed to login.";
                        MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cap = "Invalid Information";
                        msg = "Passwords aren't matched. Please try again.";
                        MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    cap = "Empty Information";
                    msg = "Please supply are required information!";
                    MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fatal error occured. " + ex);
            }
        }
    }
}
