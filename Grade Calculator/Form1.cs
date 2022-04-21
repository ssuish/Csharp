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
            ClassAES aes = new ClassAES();
            var strPwd = textBoxPwd.Text;
            var securedLogin = aes.Encrypt(strPwd);
            MessageBox.Show(securedLogin);
        }
    }
}