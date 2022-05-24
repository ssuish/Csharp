using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            string selectDB = "SELECT * FROM PARKINGDB";
            string con = @"Data Source=.\sqlexpress;Initial Catalog=parkingdb;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter(selectDB, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "PARKINGDB");
            dataGridViewLogs.DataSource = ds.Tables["PARKINGDB"].DefaultView;

        }

        private void buttonLogs_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain main = new FormMain();
            main.Show();
        }
    }
}
