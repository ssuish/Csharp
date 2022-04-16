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
                listBoxIntNo.ForeColor = forecolor.Color;
                listBoxShowOutput.ForeColor = forecolor.Color;
            }
            walkthroughEventHappened(checkBoxUI);
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog backcolor = new ColorDialog();
            backcolor.AllowFullOpen = true;
            if (backcolor.ShowDialog() == DialogResult.OK)
            {
                tabPageHome.BackColor = backcolor.Color;
                tabPageExamples.BackColor = backcolor.Color;
                listBoxIntNo.ForeColor = backcolor.Color;
                listBoxShowOutput.ForeColor = backcolor.Color;
            }
            walkthroughEventHappened(checkBoxUI);
        }

        private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPageExamples.ForeColor = Color.Black;
            tabPageHome.ForeColor = Color.Black;
            tabPageExamples.BackColor = Color.White;
            tabPageHome.BackColor = Color.White;
            listBoxIntNo.ForeColor = Color.Black;
            listBoxShowOutput.ForeColor = Color.Black;
            listBoxIntNo.BackColor = Color.White;
            listBoxShowOutput.BackColor = Color.White;
            walkthroughEventHappened(checkBoxUI);
        }

        private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPageExamples.ForeColor = Color.White;
            tabPageHome.ForeColor = Color.White;
            tabPageExamples.BackColor = Color.FromArgb(40, 44, 52);
            tabPageHome.BackColor = Color.FromArgb(40, 44, 52);
            listBoxShowOutput.BackColor = Color.FromArgb(40, 44, 52);
            listBoxIntNo.BackColor = Color.FromArgb(40, 44, 52);
            listBoxShowOutput.ForeColor = Color.Lime;
            listBoxIntNo.ForeColor = Color.Lime;
            walkthroughEventHappened(checkBoxUI);
        }

        private void draculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPageExamples.ForeColor = Color.FromArgb(180, 120, 206);
            tabPageHome.ForeColor = Color.FromArgb(180, 120, 206);
            tabPageExamples.BackColor = Color.FromArgb(40, 44, 52);
            tabPageHome.BackColor = Color.FromArgb(40, 44, 52);
            listBoxIntNo.ForeColor = Color.Cyan;
            listBoxShowOutput.ForeColor = Color.Cyan;
            listBoxIntNo.BackColor = Color.FromArgb(40, 44, 52);
            listBoxShowOutput.BackColor = Color.FromArgb(40, 44, 52);
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

        private void forLoopCode()
        {
            listBoxShowOutput.Items.Clear();
            listBoxIntNo.Items.Clear();
            labelExampleTitle.Text = "For Loop \nExample";
            labelDescription.Text = "All odd numbers from 1-20.";
            int oddNum = 1;
            for (int i = 0; i < 20; i++)
            {
                if (oddNum % 2 != 0)
                {
                    listBoxShowOutput.Items.Add(oddNum + " is odd number");
                }
                listBoxIntNo.Items.Add("No. of interations: " + i);
                oddNum++;

            }
        }

        private void whileLoopCode()
        {
            listBoxShowOutput.Items.Clear();
            listBoxIntNo.Items.Clear();
            labelExampleTitle.Text = "While Loop \nExample";
            labelDescription.Text = "All even numbers from 1-20.";
            int i = 0;
            int evenNum = 1;
            while (i < 20)
            {
                if (evenNum % 2 == 0)
                {
                    listBoxShowOutput.Items.Add(evenNum + " is even number");
                }
                listBoxIntNo.Items.Add("No. of interations: " + i);
                evenNum++;
                i++;
            }
        }

        private void doWhileLoopCode()
        {
            listBoxShowOutput.Items.Clear();
            listBoxIntNo.Items.Clear();
            labelExampleTitle.Text = "Do While\nLoop Example";
            labelDescription.Text = "Check if a number is even or\nodd from 1 - 25.";
            int i = 0;
            int isOddorEven = 1;
            do
            {
                if (isOddorEven % 2 == 0)
                {
                    listBoxShowOutput.Items.Add(isOddorEven + " is even number");
                }
                else if (isOddorEven % 2 != 0)
                {
                    listBoxShowOutput.Items.Add(isOddorEven + " is odd number");
                }
                listBoxIntNo.Items.Add("No. of interations: " + i);
                isOddorEven++;
                i++;
            }
            while (i < 25);
        }

        private void foreachLoopCode()
        {
            listBoxShowOutput.Items.Clear();
            listBoxIntNo.Items.Clear();
            labelExampleTitle.Text = "Foreach\nLoop";
            labelDescription.Text = "List all your favorite games.";
            string[] allgames = { "Guardian Tales", "Genshin Impact", "Valorant", "Minecraft" };
            listBoxShowOutput.Items.Add("My Favorite Games:");
            int index = 0;
            foreach (string x in allgames)
            {
                listBoxShowOutput.Items.Add(x);
                listBoxIntNo.Items.Add($"Index of {x} in array: {index}");
                index++;
            }
        }

        private void singleDimArrCode()
        {
            listBoxShowOutput.Items.Clear();
            listBoxIntNo.Items.Clear();
            labelExampleTitle.Text = "One Dimensional\nArray";
            labelDescription.Text = "List all your favorite anime\nthis season.";
            string[] allanime = { "Ya Boy Kongming", "Spy x Family", "LoveLive", "Kaguya-sama" };
            listBoxShowOutput.Items.Add("My Favorite Anime:");
            int index = 0;
            foreach (string x in allanime)
            {
                listBoxShowOutput.Items.Add(x);
                listBoxIntNo.Items.Add($"Index of {x} in array: {index}");
                index++;
            }
        }

        private void twoDimArrCode()
        {
            listBoxShowOutput.Items.Clear();
            listBoxIntNo.Items.Clear();
            labelExampleTitle.Text = "Two Dimensional\nArray";
            labelDescription.Text = "List some countries and\nthier well-known cities.";
            string[,] countrycity = { { "Japan", "USA", "UK" }, { "Tokyo", "New York", "London" } };
            listBoxShowOutput.Items.Add("Countries and Cities:");
            for (int x = 0; x < 3; x++)
            {
                listBoxShowOutput.Items.Add($"Country: {countrycity[0, x]}");
                listBoxShowOutput.Items.Add($"City: {countrycity[1, x]}");
            }
            for (int x = 0; x < 2; x++)
                for (int y = 0; y < 3; y++)
                    listBoxIntNo.Items.Add($"Index of {countrycity[x, y]} is: arr[{x},{y}]");

        }

        private void multiDimArrCode()
        {
            listBoxShowOutput.Items.Clear();
            listBoxIntNo.Items.Clear();
            labelExampleTitle.Text = "Multidimensional\nArray";
            labelDescription.Text = "List all rows, columns,\nand blocks of an array";
            string[,,] arr = { { { "row1", "row2" }, { "row3", "row4" } }, { { "row5", "row6" }, { "row7", "row8" } } };
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        listBoxShowOutput.Items.Add($"index of {arr[i, j, k]} is arr[{i}, {j}, {k}]");
                        listBoxIntNo.Items.Add($"block loops: {i} times, columns loops: {j} times, rows loops: {k} times");
                    }
        }

        private void forLoopToolStripMenuItemExample_Click(object sender, EventArgs e)
        {
            walkthroughEventHappened(checkBoxMS);
            forLoopCode();
            tabControl.SelectedTab = tabPageExamples;
        }

        private void whileLoopToolStripMenuItemExample_Click(object sender, EventArgs e)
        {
            walkthroughEventHappened(checkBoxMS);
            whileLoopCode();
            tabControl.SelectedTab = tabPageExamples;
        }

        private void doWhileLoopToolStripMenuItemExample_Click(object sender, EventArgs e)
        {
            walkthroughEventHappened(checkBoxMS);
            doWhileLoopCode();
            tabControl.SelectedTab = tabPageExamples;
        }

        private void foreachLoopToolStripMenuItemExample_Click(object sender, EventArgs e)
        {
            walkthroughEventHappened(checkBoxMS);
            foreachLoopCode();
            tabControl.SelectedTab = tabPageExamples;
        }

        private void forLoopsToolStripMenuItemContext_Click(object sender, EventArgs e)
        {
            walkthroughEventHappened(checkBoxCMS);
            forLoopCode();
            tabControl.SelectedTab = tabPageExamples;
        }

        private void whileLoopsToolStripMenuItemContext_Click(object sender, EventArgs e)
        {
            walkthroughEventHappened(checkBoxCMS);
            whileLoopCode();
            tabControl.SelectedTab = tabPageExamples;
        }

        private void doWhileLoopsToolStripMenuItemContext_Click(object sender, EventArgs e)
        {
            walkthroughEventHappened(checkBoxCMS);
            doWhileLoopCode();
            tabControl.SelectedTab = tabPageExamples;
        }

        private void foreachLoopsToolStripMenuItemContext_Click(object sender, EventArgs e)
        {
            walkthroughEventHappened(checkBoxCMS);
            foreachLoopCode();
            tabControl.SelectedTab = tabPageExamples;
        }

        private void singleDimensionalToolStripMenuItemExample_Click(object sender, EventArgs e)
        {
            walkthroughEventHappened(checkBoxMS);
            singleDimArrCode();
            tabControl.SelectedTab = tabPageExamples;
        }

        private void twoDimensionalToolStripMenuItemExample_Click(object sender, EventArgs e)
        {
            walkthroughEventHappened(checkBoxMS);
            twoDimArrCode();
            tabControl.SelectedTab = tabPageExamples;
        }

        private void multidimensionalToolStripMenuItemExample_Click(object sender, EventArgs e)
        {
            walkthroughEventHappened(checkBoxMS);
            multiDimArrCode();
            tabControl.SelectedTab = tabPageExamples;
        }

        private void singleDimensionalToolStripMenuItemContext_Click(object sender, EventArgs e)
        {
            walkthroughEventHappened(checkBoxCMS);
            singleDimArrCode();
            tabControl.SelectedTab = tabPageExamples;
        }

        private void twoDimensionalToolStripMenuItemContext_Click(object sender, EventArgs e)
        {
            walkthroughEventHappened(checkBoxCMS);
            twoDimArrCode();
            tabControl.SelectedTab = tabPageExamples;
        }

        private void multidimensionalToolStripMenuItemContext_Click(object sender, EventArgs e)
        {
            walkthroughEventHappened(checkBoxCMS);
            multiDimArrCode();
            tabControl.SelectedTab = tabPageExamples;
        }
    }
}
