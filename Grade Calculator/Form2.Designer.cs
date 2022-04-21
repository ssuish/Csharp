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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonShowPwd = new System.Windows.Forms.Button();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.buttonToLogin = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxRepeatPwd = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonShowPwd);
            this.panel1.Controls.Add(this.buttonSignup);
            this.panel1.Controls.Add(this.buttonToLogin);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxRepeatPwd);
            this.panel1.Controls.Add(this.textBoxPwd);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 361);
            this.panel1.TabIndex = 0;
            // 
            // buttonShowPwd
            // 
            this.buttonShowPwd.Location = new System.Drawing.Point(88, 276);
            this.buttonShowPwd.Name = "buttonShowPwd";
            this.buttonShowPwd.Size = new System.Drawing.Size(115, 23);
            this.buttonShowPwd.TabIndex = 23;
            this.buttonShowPwd.Text = "Show password";
            this.buttonShowPwd.UseVisualStyleBackColor = true;
            this.buttonShowPwd.Click += new System.EventHandler(this.buttonShowPwd_Click);
            // 
            // buttonSignup
            // 
            this.buttonSignup.Location = new System.Drawing.Point(88, 247);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(75, 23);
            this.buttonSignup.TabIndex = 22;
            this.buttonSignup.Text = "Sign up";
            this.buttonSignup.UseVisualStyleBackColor = true;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // buttonToLogin
            // 
            this.buttonToLogin.Location = new System.Drawing.Point(88, 218);
            this.buttonToLogin.Name = "buttonToLogin";
            this.buttonToLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonToLogin.TabIndex = 21;
            this.buttonToLogin.Text = "To Login";
            this.buttonToLogin.UseVisualStyleBackColor = true;
            this.buttonToLogin.Click += new System.EventHandler(this.buttonToLogin_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(197, 178);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 23);
            this.textBoxEmail.TabIndex = 20;
            // 
            // textBoxRepeatPwd
            // 
            this.textBoxRepeatPwd.Location = new System.Drawing.Point(197, 151);
            this.textBoxRepeatPwd.Name = "textBoxRepeatPwd";
            this.textBoxRepeatPwd.Size = new System.Drawing.Size(100, 23);
            this.textBoxRepeatPwd.TabIndex = 19;
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(197, 123);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(100, 23);
            this.textBoxPwd.TabIndex = 18;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(197, 93);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 23);
            this.textBoxUsername.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Repeat Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sign Up";
            // 
            // FormSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.panel1);
            this.Name = "FormSignup";
            this.Text = "Sign up";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonShowPwd;
        private Button buttonSignup;
        private Button buttonToLogin;
        private TextBox textBoxEmail;
        private TextBox textBoxRepeatPwd;
        private TextBox textBoxPwd;
        private TextBox textBoxUsername;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}