namespace Grade_Calculator
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prelimCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prelimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.midtermToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semestralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalGWAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foregroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBacktoLogin = new System.Windows.Forms.Button();
            this.buttonShowSelectedCalculator = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTotalGWA = new System.Windows.Forms.RadioButton();
            this.radioButtonSemestral = new System.Windows.Forms.RadioButton();
            this.radioButtonFinals = new System.Windows.Forms.RadioButton();
            this.radioButtonMidterm = new System.Windows.Forms.RadioButton();
            this.radioButtonPrelim = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prelimCalculatorToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // prelimCalculatorToolStripMenuItem
            // 
            this.prelimCalculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prelimToolStripMenuItem,
            this.midtermToolStripMenuItem,
            this.finalsToolStripMenuItem,
            this.semestralToolStripMenuItem,
            this.totalGWAToolStripMenuItem});
            this.prelimCalculatorToolStripMenuItem.Name = "prelimCalculatorToolStripMenuItem";
            this.prelimCalculatorToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.prelimCalculatorToolStripMenuItem.Text = "Grade Calculator";
            // 
            // prelimToolStripMenuItem
            // 
            this.prelimToolStripMenuItem.Name = "prelimToolStripMenuItem";
            this.prelimToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.prelimToolStripMenuItem.Text = "Prelim";
            this.prelimToolStripMenuItem.Click += new System.EventHandler(this.prelimToolStripMenuItem_Click);
            // 
            // midtermToolStripMenuItem
            // 
            this.midtermToolStripMenuItem.Name = "midtermToolStripMenuItem";
            this.midtermToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.midtermToolStripMenuItem.Text = "Midterm";
            this.midtermToolStripMenuItem.Click += new System.EventHandler(this.midtermToolStripMenuItem_Click);
            // 
            // finalsToolStripMenuItem
            // 
            this.finalsToolStripMenuItem.Name = "finalsToolStripMenuItem";
            this.finalsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.finalsToolStripMenuItem.Text = "Finals";
            this.finalsToolStripMenuItem.Click += new System.EventHandler(this.finalsToolStripMenuItem_Click);
            // 
            // semestralToolStripMenuItem
            // 
            this.semestralToolStripMenuItem.Name = "semestralToolStripMenuItem";
            this.semestralToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.semestralToolStripMenuItem.Text = "Semestral";
            this.semestralToolStripMenuItem.Click += new System.EventHandler(this.semestralToolStripMenuItem_Click);
            // 
            // totalGWAToolStripMenuItem
            // 
            this.totalGWAToolStripMenuItem.Name = "totalGWAToolStripMenuItem";
            this.totalGWAToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.totalGWAToolStripMenuItem.Text = "Total GWA";
            this.totalGWAToolStripMenuItem.Click += new System.EventHandler(this.totalGWAToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foregroundToolStripMenuItem,
            this.backgroundToolStripMenuItem});
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.changeColorToolStripMenuItem.Text = "Change Color";
            // 
            // foregroundToolStripMenuItem
            // 
            this.foregroundToolStripMenuItem.Name = "foregroundToolStripMenuItem";
            this.foregroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.foregroundToolStripMenuItem.Text = "Foreground";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.buttonBacktoLogin);
            this.panel1.Controls.Add(this.buttonShowSelectedCalculator);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 437);
            this.panel1.TabIndex = 1;
            // 
            // buttonBacktoLogin
            // 
            this.buttonBacktoLogin.FlatAppearance.BorderSize = 0;
            this.buttonBacktoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBacktoLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonBacktoLogin.Image")));
            this.buttonBacktoLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBacktoLogin.Location = new System.Drawing.Point(14, 362);
            this.buttonBacktoLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBacktoLogin.Name = "buttonBacktoLogin";
            this.buttonBacktoLogin.Size = new System.Drawing.Size(136, 41);
            this.buttonBacktoLogin.TabIndex = 7;
            this.buttonBacktoLogin.Text = " Back to Login";
            this.buttonBacktoLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBacktoLogin.UseVisualStyleBackColor = true;
            this.buttonBacktoLogin.Click += new System.EventHandler(this.buttonBacktoLogin_Click);
            // 
            // buttonShowSelectedCalculator
            // 
            this.buttonShowSelectedCalculator.FlatAppearance.BorderSize = 0;
            this.buttonShowSelectedCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowSelectedCalculator.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowSelectedCalculator.Image")));
            this.buttonShowSelectedCalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowSelectedCalculator.Location = new System.Drawing.Point(14, 313);
            this.buttonShowSelectedCalculator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonShowSelectedCalculator.Name = "buttonShowSelectedCalculator";
            this.buttonShowSelectedCalculator.Size = new System.Drawing.Size(89, 41);
            this.buttonShowSelectedCalculator.TabIndex = 6;
            this.buttonShowSelectedCalculator.Text = " Enter";
            this.buttonShowSelectedCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonShowSelectedCalculator.UseVisualStyleBackColor = true;
            this.buttonShowSelectedCalculator.Click += new System.EventHandler(this.buttonShowSelectedCalculator_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTotalGWA);
            this.groupBox1.Controls.Add(this.radioButtonSemestral);
            this.groupBox1.Controls.Add(this.radioButtonFinals);
            this.groupBox1.Controls.Add(this.radioButtonMidterm);
            this.groupBox1.Controls.Add(this.radioButtonPrelim);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 130);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(201, 175);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a calculator";
            // 
            // radioButtonTotalGWA
            // 
            this.radioButtonTotalGWA.AutoSize = true;
            this.radioButtonTotalGWA.Location = new System.Drawing.Point(7, 146);
            this.radioButtonTotalGWA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonTotalGWA.Name = "radioButtonTotalGWA";
            this.radioButtonTotalGWA.Size = new System.Drawing.Size(92, 22);
            this.radioButtonTotalGWA.TabIndex = 7;
            this.radioButtonTotalGWA.TabStop = true;
            this.radioButtonTotalGWA.Text = "Total GWA";
            this.radioButtonTotalGWA.UseVisualStyleBackColor = true;
            // 
            // radioButtonSemestral
            // 
            this.radioButtonSemestral.AutoSize = true;
            this.radioButtonSemestral.Location = new System.Drawing.Point(7, 116);
            this.radioButtonSemestral.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonSemestral.Name = "radioButtonSemestral";
            this.radioButtonSemestral.Size = new System.Drawing.Size(90, 22);
            this.radioButtonSemestral.TabIndex = 6;
            this.radioButtonSemestral.TabStop = true;
            this.radioButtonSemestral.Text = "Semestral";
            this.radioButtonSemestral.UseVisualStyleBackColor = true;
            // 
            // radioButtonFinals
            // 
            this.radioButtonFinals.AutoSize = true;
            this.radioButtonFinals.Location = new System.Drawing.Point(7, 86);
            this.radioButtonFinals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonFinals.Name = "radioButtonFinals";
            this.radioButtonFinals.Size = new System.Drawing.Size(63, 22);
            this.radioButtonFinals.TabIndex = 5;
            this.radioButtonFinals.TabStop = true;
            this.radioButtonFinals.Text = "Finals";
            this.radioButtonFinals.UseVisualStyleBackColor = true;
            // 
            // radioButtonMidterm
            // 
            this.radioButtonMidterm.AutoSize = true;
            this.radioButtonMidterm.Location = new System.Drawing.Point(7, 56);
            this.radioButtonMidterm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonMidterm.Name = "radioButtonMidterm";
            this.radioButtonMidterm.Size = new System.Drawing.Size(82, 22);
            this.radioButtonMidterm.TabIndex = 4;
            this.radioButtonMidterm.TabStop = true;
            this.radioButtonMidterm.Text = "Midterm";
            this.radioButtonMidterm.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrelim
            // 
            this.radioButtonPrelim.AutoSize = true;
            this.radioButtonPrelim.Location = new System.Drawing.Point(7, 26);
            this.radioButtonPrelim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonPrelim.Name = "radioButtonPrelim";
            this.radioButtonPrelim.Size = new System.Drawing.Size(68, 22);
            this.radioButtonPrelim.TabIndex = 3;
            this.radioButtonPrelim.TabStop = true;
            this.radioButtonPrelim.Text = "Prelim";
            this.radioButtonPrelim.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to \r\nGrade Calculator";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Grade Calculator App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem prelimCalculatorToolStripMenuItem;
        private ToolStripMenuItem prelimToolStripMenuItem;
        private ToolStripMenuItem midtermToolStripMenuItem;
        private ToolStripMenuItem finalsToolStripMenuItem;
        private ToolStripMenuItem semestralToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioButtonTotalGWA;
        private RadioButton radioButtonSemestral;
        private RadioButton radioButtonFinals;
        private RadioButton radioButtonMidterm;
        private RadioButton radioButtonPrelim;
        private Button buttonShowSelectedCalculator;
        private ToolStripMenuItem changeColorToolStripMenuItem;
        private ToolStripMenuItem foregroundToolStripMenuItem;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem totalGWAToolStripMenuItem;
        private Button buttonBacktoLogin;
    }
}