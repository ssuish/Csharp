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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Form4 midterm;

        private void midtermToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (midterm is null)
            {
                midterm = new Form4();
                midterm.MdiParent = this;
                midterm.FormClosed += Midterm_FormClosed;
                midterm.Show();
                midterm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                midterm.Activate();
            }
        }

        private void Midterm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            midterm = null;
        }
    }
}
