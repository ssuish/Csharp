namespace Grade_Calculator
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDeleteAcc = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonToSignup = new System.Windows.Forms.Button();
            this.textBoxLogPwrd = new System.Windows.Forms.TextBox();
            this.textBoxLogUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Controls.Add(this.buttonDeleteAcc);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.buttonToSignup);
            this.panelLogin.Controls.Add(this.textBoxLogPwrd);
            this.panelLogin.Controls.Add(this.textBoxLogUsername);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(384, 361);
            this.panelLogin.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Prepared by:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(152, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Grade Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 361);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDeleteAcc
            // 
            this.buttonDeleteAcc.FlatAppearance.BorderSize = 0;
            this.buttonDeleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteAcc.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteAcc.Image")));
            this.buttonDeleteAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteAcc.Location = new System.Drawing.Point(197, 311);
            this.buttonDeleteAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteAcc.Name = "buttonDeleteAcc";
            this.buttonDeleteAcc.Size = new System.Drawing.Size(144, 37);
            this.buttonDeleteAcc.TabIndex = 7;
            this.buttonDeleteAcc.Text = " Delete Account";
            this.buttonDeleteAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeleteAcc.UseVisualStyleBackColor = true;
            this.buttonDeleteAcc.Click += new System.EventHandler(this.buttonDeleteAcc_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogin.Image")));
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.Location = new System.Drawing.Point(197, 214);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(95, 40);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = " Log In";
            this.buttonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonToSignup
            // 
            this.buttonToSignup.FlatAppearance.BorderSize = 0;
            this.buttonToSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToSignup.Image = ((System.Drawing.Image)(resources.GetObject("buttonToSignup.Image")));
            this.buttonToSignup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToSignup.Location = new System.Drawing.Point(197, 262);
            this.buttonToSignup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonToSignup.Name = "buttonToSignup";
            this.buttonToSignup.Size = new System.Drawing.Size(144, 41);
            this.buttonToSignup.TabIndex = 5;
            this.buttonToSignup.Text = " Create Account";
            this.buttonToSignup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonToSignup.UseVisualStyleBackColor = true;
            this.buttonToSignup.Click += new System.EventHandler(this.buttonToSignup_Click);
            // 
            // textBoxLogPwrd
            // 
            this.textBoxLogPwrd.Location = new System.Drawing.Point(197, 165);
            this.textBoxLogPwrd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLogPwrd.Name = "textBoxLogPwrd";
            this.textBoxLogPwrd.PasswordChar = '•';
            this.textBoxLogPwrd.Size = new System.Drawing.Size(130, 23);
            this.textBoxLogPwrd.TabIndex = 4;
            // 
            // textBoxLogUsername
            // 
            this.textBoxLogUsername.Location = new System.Drawing.Point(197, 116);
            this.textBoxLogUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLogUsername.Name = "textBoxLogUsername";
            this.textBoxLogUsername.Size = new System.Drawing.Size(130, 23);
            this.textBoxLogUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(226, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(226, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelLogin.Location = new System.Drawing.Point(226, 86);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(72, 26);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login ";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.panelLogin);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLogin;
        private Button buttonLogin;
        private Button buttonToSignup;
        private TextBox textBoxLogPwrd;
        private TextBox textBoxLogUsername;
        private Label label2;
        private Label label1;
        private Label labelLogin;
        private Button buttonDeleteAcc;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
    }
}