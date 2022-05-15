namespace Grade_Calculator
{
    partial class FormSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRepeatPwrd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.buttonToLogin = new System.Windows.Forms.Button();
            this.textBoxLogPwrd = new System.Windows.Forms.TextBox();
            this.textBoxLogUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxRepeatPwrd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonSignup);
            this.panel1.Controls.Add(this.buttonToLogin);
            this.panel1.Controls.Add(this.textBoxLogPwrd);
            this.panel1.Controls.Add(this.textBoxLogUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 361);
            this.panel1.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(44, 210);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(128, 23);
            this.textBoxEmail.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(86, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            // 
            // textBoxRepeatPwrd
            // 
            this.textBoxRepeatPwrd.Location = new System.Drawing.Point(44, 161);
            this.textBoxRepeatPwrd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRepeatPwrd.Name = "textBoxRepeatPwrd";
            this.textBoxRepeatPwrd.PasswordChar = '•';
            this.textBoxRepeatPwrd.Size = new System.Drawing.Size(128, 23);
            this.textBoxRepeatPwrd.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(52, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Repeat Password";
            // 
            // buttonSignup
            // 
            this.buttonSignup.FlatAppearance.BorderSize = 0;
            this.buttonSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignup.Image = ((System.Drawing.Image)(resources.GetObject("buttonSignup.Image")));
            this.buttonSignup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSignup.Location = new System.Drawing.Point(111, 305);
            this.buttonSignup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(100, 43);
            this.buttonSignup.TabIndex = 13;
            this.buttonSignup.Text = " Sign up";
            this.buttonSignup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSignup.UseVisualStyleBackColor = true;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // buttonToLogin
            // 
            this.buttonToLogin.FlatAppearance.BorderSize = 0;
            this.buttonToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonToLogin.Image")));
            this.buttonToLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToLogin.Location = new System.Drawing.Point(19, 305);
            this.buttonToLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonToLogin.Name = "buttonToLogin";
            this.buttonToLogin.Size = new System.Drawing.Size(86, 43);
            this.buttonToLogin.TabIndex = 12;
            this.buttonToLogin.Text = " Back";
            this.buttonToLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonToLogin.UseVisualStyleBackColor = true;
            this.buttonToLogin.Click += new System.EventHandler(this.buttonToLogin_Click);
            // 
            // textBoxLogPwrd
            // 
            this.textBoxLogPwrd.Location = new System.Drawing.Point(44, 112);
            this.textBoxLogPwrd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLogPwrd.Name = "textBoxLogPwrd";
            this.textBoxLogPwrd.PasswordChar = '•';
            this.textBoxLogPwrd.Size = new System.Drawing.Size(128, 23);
            this.textBoxLogPwrd.TabIndex = 11;
            // 
            // textBoxLogUsername
            // 
            this.textBoxLogUsername.Location = new System.Drawing.Point(42, 63);
            this.textBoxLogUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLogUsername.Name = "textBoxLogUsername";
            this.textBoxLogUsername.Size = new System.Drawing.Size(130, 23);
            this.textBoxLogUsername.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(73, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(73, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelLogin.Location = new System.Drawing.Point(60, 21);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(89, 26);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Sign Up";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(217, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 361);
            this.panel2.TabIndex = 18;
            // 
            // FormSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSignup";
            this.Text = "Sign Up";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonSignup;
        private Button buttonToLogin;
        private TextBox textBoxLogPwrd;
        private TextBox textBoxLogUsername;
        private Label label2;
        private Label label1;
        private Label labelLogin;
        private TextBox textBoxEmail;
        private Label label4;
        private TextBox textBoxRepeatPwrd;
        private Label label3;
        private Panel panel2;
    }
}