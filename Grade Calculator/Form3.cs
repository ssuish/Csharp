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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Fatal error occured.\n" + ex);
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Fatal error occured.\n" + ex);
            }
        }

        private void buttonToLoginPage_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.Show();
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog forecolor = new ColorDialog();
            forecolor.AllowFullOpen = true;
            if (forecolor.ShowDialog() == DialogResult.OK)
            {
                panelMain.ForeColor = forecolor.Color;
                groupBoxCalc.ForeColor = forecolor.Color;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cap = "Help";
            string msg = "Formula Used\n\n" +
                "Quizzes - 25%\n" +
                "Quiz 1 & 2 = 40 items\n\n" +
                "Assignments - 20%\n" +
                "Assignments 1 & 2 = 100 items\n\n" +
                "Lab Activities - 25%\n" +
                "Lab Act 1, 2, 3, 4 = 100 items\n\n" +
                "Midterm Exam - 30%\n" +
                "Midterm Exam = 40 items\n\n" +
                "Midterm Grade = Quizzes + Assignments + Lab Activity + Midterm Exam";
            MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
