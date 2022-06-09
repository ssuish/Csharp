namespace GUI_Loops_and_Arrays
{
    public partial class FormTitle : Form
    {
        public FormTitle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain main = new FormMain();
            main.Show();
        }

    }
}