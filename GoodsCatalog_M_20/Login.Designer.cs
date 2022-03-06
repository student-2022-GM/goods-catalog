
namespace GoodsCatalog_M_20
{
    partial class Login
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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.verifyLoginButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.askLogin = new System.Windows.Forms.Label();
            this.askPassword = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(150, 202);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 0;
            // 
            // verifyLoginButton
            // 
            this.verifyLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.verifyLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verifyLoginButton.Location = new System.Drawing.Point(436, 359);
            this.verifyLoginButton.Name = "verifyLoginButton";
            this.verifyLoginButton.Size = new System.Drawing.Size(185, 39);
            this.verifyLoginButton.TabIndex = 2;
            this.verifyLoginButton.Text = "PRESS TO LOGIN";
            this.verifyLoginButton.UseVisualStyleBackColor = false;
            this.verifyLoginButton.Click += new System.EventHandler(this.verifyLoginButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(323, 45);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(104, 31);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "LOGIN";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // askLogin
            // 
            this.askLogin.AutoSize = true;
            this.askLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.askLogin.Location = new System.Drawing.Point(135, 169);
            this.askLogin.Name = "askLogin";
            this.askLogin.Size = new System.Drawing.Size(131, 20);
            this.askLogin.TabIndex = 5;
            this.askLogin.Text = "Enter Your login :";
            // 
            // askPassword
            // 
            this.askPassword.AutoSize = true;
            this.askPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.askPassword.Location = new System.Drawing.Point(455, 169);
            this.askPassword.Name = "askPassword";
            this.askPassword.Size = new System.Drawing.Size(166, 20);
            this.askPassword.TabIndex = 6;
            this.askPassword.Text = "Enter Your password :";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(486, 202);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '#';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.Location = new System.Drawing.Point(139, 359);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(223, 40);
            this.registrationButton.TabIndex = 3;
            this.registrationButton.Text = "REGISTRATION";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.askPassword);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.askLogin);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.verifyLoginButton);
            this.Controls.Add(this.loginTextBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button verifyLoginButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label askLogin;
        private System.Windows.Forms.Label askPassword;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button registrationButton;
    }
}