using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Loops_and_Arrays
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void whileLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 titleform = new Form1();
            titleform.Show();
        }

        private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog forecolor = new ColorDialog();
            forecolor.AllowFullOpen = true;
            if (forecolor.ShowDialog() == DialogResult.OK)
            {
                tabPage1GettingStarted.ForeColor = forecolor.Color;
                tabPage1Examples.ForeColor = forecolor.Color;
            }
;        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog backcolor = new ColorDialog();
            backcolor.AllowFullOpen = true;
            if (backcolor.ShowDialog() == DialogResult.OK)
            {
                tabPage1GettingStarted.BackColor = backcolor.Color;
                tabPage1Examples.BackColor = backcolor.Color;
            }
        }

        private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage1Examples.ForeColor = Color.Black;
            tabPage1GettingStarted.ForeColor = Color.Black;
            tabPage1Examples.BackColor = Color.White;
            tabPage1GettingStarted.BackColor = Color.White;
        }

        private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage1Examples.ForeColor = Color.White;
            tabPage1GettingStarted.ForeColor = Color.White;
            tabPage1Examples.BackColor = Color.FromArgb(40, 44, 52);
            tabPage1GettingStarted.BackColor = Color.FromArgb(40, 44, 52);
        }

        private void draculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage1Examples.ForeColor = Color.FromArgb(180, 120, 206);
            tabPage1GettingStarted.ForeColor = Color.FromArgb(180, 120, 206);
            tabPage1Examples.BackColor = Color.FromArgb(40, 44, 52);
            tabPage1GettingStarted.BackColor = Color.FromArgb(40, 44, 52);
        }

        private void forLoopToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void whileLoopToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void doWhileLoopToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void foreachLoopToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void singleDimensionalToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void twoDimensionalToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void multidimensionalToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
