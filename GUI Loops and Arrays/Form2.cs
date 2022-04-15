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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTitle titleform = new FormTitle();
            titleform.Show();
        }

        private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog forecolor = new ColorDialog();
            forecolor.AllowFullOpen = true;
            if (forecolor.ShowDialog() == DialogResult.OK)
            {
                tabPageHome.ForeColor = forecolor.Color;
                tabPageExamples.ForeColor = forecolor.Color;
            }
            walkthroughEventHappened(checkBoxUI);
            ;        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog backcolor = new ColorDialog();
            backcolor.AllowFullOpen = true;
            if (backcolor.ShowDialog() == DialogResult.OK)
            {
                tabPageHome.BackColor = backcolor.Color;
                tabPageExamples.BackColor = backcolor.Color;
            }
            walkthroughEventHappened(checkBoxUI);
        }

        private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPageExamples.ForeColor = Color.Black;
            tabPageHome.ForeColor = Color.Black;
            tabPageExamples.BackColor = Color.White;
            tabPageHome.BackColor = Color.White;
            walkthroughEventHappened(checkBoxUI);
        }

        private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPageExamples.ForeColor = Color.White;
            tabPageHome.ForeColor = Color.White;
            tabPageExamples.BackColor = Color.FromArgb(40, 44, 52);
            tabPageHome.BackColor = Color.FromArgb(40, 44, 52);
            walkthroughEventHappened(checkBoxUI);
        }

        private void draculaToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            tabPageExamples.ForeColor = Color.FromArgb(180, 120, 206);
            tabPageHome.ForeColor = Color.FromArgb(180, 120, 206);
            tabPageExamples.BackColor = Color.FromArgb(40, 44, 52);
            tabPageHome.BackColor = Color.FromArgb(40, 44, 52);
            walkthroughEventHappened(checkBoxUI);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            checkBoxCMS.CheckState = CheckState.Unchecked;
            checkBoxHelp.CheckState = CheckState.Unchecked;
            checkBoxHome.CheckState = CheckState.Unchecked;
            checkBoxMS.CheckState = CheckState.Unchecked;
            checkBoxUI.CheckState = CheckState.Unchecked;
        }

        private void walkthroughEventHappened(CheckBox checkbox)
        {
            checkbox.CheckState = CheckState.Checked;
        }

        private void forloopCode()
        {
            labelExampleTitle.Text = "For Loop \nExample";
            labelDescription.Text = "All odd numbers from 1-20.";
            int oddNum = 0;
            for (int i = 0; i <= 20; i++)
            {
                if (oddNum % 2 != 0)
                {
                    listBoxShowOutput.Items.Add(oddNum + " is odd number");
                }
                oddNum++;
                listBoxIntNo.Items.Add("No. of interations: " + i);
            }
        }

        private void forLoopToolStripMenuItemExample_Click(object sender, EventArgs e)
        {
            walkthroughEventHappened(checkBoxMS);
            forloopCode();
            tabControl.SelectedTab = tabPageExamples;
        }

        private void forLoopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            walkthroughEventHappened(checkBoxCMS);
            forloopCode();
            tabControl.SelectedTab = tabPageExamples;
        }
    }
}
