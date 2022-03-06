
namespace GoodsCatalog_M_20
{
    partial class Register
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.registrationButtonOk = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel2 = new System.Windows.Forms.Label();
            this.passwordOriginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.Black;
            this.infoLabel.Location = new System.Drawing.Point(152, 19);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(486, 28);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Put Your data and press OK to make registration";
            // 
            // registrationButtonOk
            // 
            this.registrationButtonOk.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.registrationButtonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButtonOk.Location = new System.Drawing.Point(348, 396);
            this.registrationButtonOk.Name = "registrationButtonOk";
            this.registrationButtonOk.Size = new System.Drawing.Size(75, 42);
            this.registrationButtonOk.TabIndex = 1;
            this.registrationButtonOk.Text = "OK";
            this.registrationButtonOk.UseVisualStyleBackColor = false;
            this.registrationButtonOk.Click += new System.EventHandler(this.registrationButtonOk_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(346, 73);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(77, 16);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Enter login :";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(336, 102);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 3;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(407, 176);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '#';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.confirmPasswordTextBox.TabIndex = 5;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel2
            // 
            this.passwordLabel2.AutoSize = true;
            this.passwordLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel2.Location = new System.Drawing.Point(404, 147);
            this.passwordLabel2.Name = "passwordLabel2";
            this.passwordLabel2.Size = new System.Drawing.Size(121, 16);
            this.passwordLabel2.TabIndex = 4;
            this.passwordLabel2.Text = "Confirm password :";
            // 
            // passwordOriginTextBox
            // 
            this.passwordOriginTextBox.Location = new System.Drawing.Point(262, 176);
            this.passwordOriginTextBox.Name = "passwordOriginTextBox";
            this.passwordOriginTextBox.PasswordChar = '#';
            this.passwordOriginTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordOriginTextBox.TabIndex = 7;
            this.passwordOriginTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel1
            // 
            this.passwordLabel1.AutoSize = true;
            this.passwordLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel1.Location = new System.Drawing.Point(259, 147);
            this.passwordLabel1.Name = "passwordLabel1";
            this.passwordLabel1.Size = new System.Drawing.Size(107, 16);
            this.passwordLabel1.TabIndex = 6;
            this.passwordLabel1.Text = "Enter password :";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(336, 253);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(346, 224);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(82, 16);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Enter name :";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(336, 322);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 11;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(346, 293);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(86, 16);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Enter E-mail :";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.passwordOriginTextBox);
            this.Controls.Add(this.passwordLabel1);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.passwordLabel2);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.registrationButtonOk);
            this.Controls.Add(this.infoLabel);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button registrationButtonOk;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label passwordLabel2;
        private System.Windows.Forms.TextBox passwordOriginTextBox;
        private System.Windows.Forms.Label passwordLabel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
    }
}