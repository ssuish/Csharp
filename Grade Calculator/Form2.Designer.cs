namespace Grade_Calculator
{
    partial class Form2
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
            this.buttonSignup = new System.Windows.Forms.Button();
            this.buttonToLogin = new System.Windows.Forms.Button();
            this.textBoxLogPwrd = new System.Windows.Forms.TextBox();
            this.textBoxLogUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxRepeatPwrd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 361);
            this.panel1.TabIndex = 0;
            // 
            // buttonSignup
            // 
            this.buttonSignup.Location = new System.Drawing.Point(200, 217);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(75, 23);
            this.buttonSignup.TabIndex = 13;
            this.buttonSignup.Text = "Sign up";
            this.buttonSignup.UseVisualStyleBackColor = true;
            // 
            // buttonToLogin
            // 
            this.buttonToLogin.Location = new System.Drawing.Point(109, 217);
            this.buttonToLogin.Name = "buttonToLogin";
            this.buttonToLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonToLogin.TabIndex = 12;
            this.buttonToLogin.Text = "Log In";
            this.buttonToLogin.UseVisualStyleBackColor = true;
            // 
            // textBoxLogPwrd
            // 
            this.textBoxLogPwrd.Location = new System.Drawing.Point(200, 109);
            this.textBoxLogPwrd.Name = "textBoxLogPwrd";
            this.textBoxLogPwrd.PasswordChar = '•';
            this.textBoxLogPwrd.Size = new System.Drawing.Size(100, 23);
            this.textBoxLogPwrd.TabIndex = 11;
            // 
            // textBoxLogUsername
            // 
            this.textBoxLogUsername.Location = new System.Drawing.Point(200, 80);
            this.textBoxLogUsername.Name = "textBoxLogUsername";
            this.textBoxLogUsername.Size = new System.Drawing.Size(100, 23);
            this.textBoxLogUsername.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(95, 62);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(48, 15);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Sign Up";
            // 
            // textBoxRepeatPwrd
            // 
            this.textBoxRepeatPwrd.Location = new System.Drawing.Point(200, 139);
            this.textBoxRepeatPwrd.Name = "textBoxRepeatPwrd";
            this.textBoxRepeatPwrd.PasswordChar = '•';
            this.textBoxRepeatPwrd.Size = new System.Drawing.Size(100, 23);
            this.textBoxRepeatPwrd.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Repeat Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(200, 168);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 23);
            this.textBoxEmail.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
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
    }
}