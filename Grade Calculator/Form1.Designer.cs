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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonToSignup = new System.Windows.Forms.Button();
            this.textBoxLogPwd = new System.Windows.Forms.TextBox();
            this.textBoxLogUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.buttonToSignup);
            this.panelLogin.Controls.Add(this.textBoxLogPwd);
            this.panelLogin.Controls.Add(this.textBoxLogUsername);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(384, 361);
            this.panelLogin.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(103, 105);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonToSignup
            // 
            this.buttonToSignup.Location = new System.Drawing.Point(12, 105);
            this.buttonToSignup.Name = "buttonToSignup";
            this.buttonToSignup.Size = new System.Drawing.Size(75, 23);
            this.buttonToSignup.TabIndex = 5;
            this.buttonToSignup.Text = "To Sign up";
            this.buttonToSignup.UseVisualStyleBackColor = true;
            this.buttonToSignup.Click += new System.EventHandler(this.buttonToSignup_Click);
            // 
            // textBoxLogPwd
            // 
            this.textBoxLogPwd.Location = new System.Drawing.Point(78, 65);
            this.textBoxLogPwd.Name = "textBoxLogPwd";
            this.textBoxLogPwd.PasswordChar = '•';
            this.textBoxLogPwd.Size = new System.Drawing.Size(100, 23);
            this.textBoxLogPwd.TabIndex = 4;
            // 
            // textBoxLogUsername
            // 
            this.textBoxLogUsername.Location = new System.Drawing.Point(78, 35);
            this.textBoxLogUsername.Name = "textBoxLogUsername";
            this.textBoxLogUsername.Size = new System.Drawing.Size(100, 23);
            this.textBoxLogUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(12, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(40, 15);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login ";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.panelLogin);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLogin;
        private Button buttonLogin;
        private Button buttonToSignup;
        private TextBox textBoxLogPwd;
        private TextBox textBoxLogUsername;
        private Label label2;
        private Label label1;
        private Label labelLogin;
    }
}