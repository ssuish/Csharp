using System.IO;
using System.Reflection;

namespace Grade_Calculator
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonToSignup_Click(object sender, EventArgs e)
        {
            FormSignup signup = new FormSignup();
            this.Hide();
            signup.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Security aes = new Security();

            string runTimeDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string dataDirectory = Path.Combine(runTimeDirectory, "Data");

            StreamReader reader = new StreamReader(Path.Combine(dataDirectory, "userData.txt"));
            try
            {
                var userInfo = string.Empty;
                do
                {
                    userInfo = reader.ReadLine();
                }
                while(reader.Peek() != -1);
                
                MessageBox.Show(aes.Decrypt(userInfo));
            }
            catch
            {
                MessageBox.Show("File is Empty!");
            }
            finally
            {
                reader.Dispose();
                reader.Close();
            }
        }
    }
}