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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        FormMidtermCalculator midterm;

        private void UnavailableFeature()
        {
            string cap = "Unavailable Feature";
            string msg = "This is feature is not yet available. " +
                "\nI apologize for my inconvenience. Thank you";
            MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ToFormMidtermCalc()
        {
            if (midterm is null)
            {
                midterm = new FormMidtermCalculator();
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

        private void prelimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnavailableFeature();
        }

        private void finalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnavailableFeature();
        }

        private void semestralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnavailableFeature();
        }

        private void totalGWAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnavailableFeature();
        }

        private void midtermToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToFormMidtermCalc();
        }

        private void Midterm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            midterm = null;
        }

        private void buttonShowSelectedCalculator_Click(object sender, EventArgs e)
        {
            if (radioButtonPrelim.Checked)
            {
                UnavailableFeature();
            }
            else if (radioButtonMidterm.Checked)
            {
                if (midterm is null)
                {
                    midterm = new FormMidtermCalculator();
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
            else if (radioButtonFinals.Checked)
            {
                UnavailableFeature();
            }
            else if (radioButtonSemestral.Checked)
            {
                UnavailableFeature();
            }
            else if (radioButtonTotalGWA.Checked)
            {
                UnavailableFeature();
            }
        }

        private void buttonToLoginPage_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.Show();
        }

        
    }
}
