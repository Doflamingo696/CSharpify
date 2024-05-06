namespace AttendanceSystem
{
    partial class RegisterForm
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
            this.tbRegisterFormUsername = new MetroFramework.Controls.MetroTextBox();
            this.tbRegisterFormPassword = new MetroFramework.Controls.MetroTextBox();
            this.tbRegisterFormConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.lblConfirmPassword = new MetroFramework.Controls.MetroLabel();
            this.btnRegisterFormRegister = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // tbRegisterFormUsername
            // 
            this.tbRegisterFormUsername.Location = new System.Drawing.Point(189, 161);
            this.tbRegisterFormUsername.Name = "tbRegisterFormUsername";
            this.tbRegisterFormUsername.Size = new System.Drawing.Size(420, 23);
            this.tbRegisterFormUsername.TabIndex = 0;
            // 
            // tbRegisterFormPassword
            // 
            this.tbRegisterFormPassword.Location = new System.Drawing.Point(189, 215);
            this.tbRegisterFormPassword.Name = "tbRegisterFormPassword";
            this.tbRegisterFormPassword.PasswordChar = '*';
            this.tbRegisterFormPassword.Size = new System.Drawing.Size(420, 23);
            this.tbRegisterFormPassword.TabIndex = 1;
            // 
            // tbRegisterFormConfirmPassword
            // 
            this.tbRegisterFormConfirmPassword.Location = new System.Drawing.Point(189, 269);
            this.tbRegisterFormConfirmPassword.Name = "tbRegisterFormConfirmPassword";
            this.tbRegisterFormConfirmPassword.PasswordChar = '*';
            this.tbRegisterFormConfirmPassword.Size = new System.Drawing.Size(420, 23);
            this.tbRegisterFormConfirmPassword.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(189, 136);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 19);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(189, 193);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 19);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(189, 247);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(118, 19);
            this.lblConfirmPassword.TabIndex = 5;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // btnRegisterFormRegister
            // 
            this.btnRegisterFormRegister.Location = new System.Drawing.Point(534, 316);
            this.btnRegisterFormRegister.Name = "btnRegisterFormRegister";
            this.btnRegisterFormRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterFormRegister.TabIndex = 6;
            this.btnRegisterFormRegister.Text = "Register";
            this.btnRegisterFormRegister.Click += new System.EventHandler(this.btnRegisterFormRegister_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegisterFormRegister);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbRegisterFormConfirmPassword);
            this.Controls.Add(this.tbRegisterFormPassword);
            this.Controls.Add(this.tbRegisterFormUsername);
            this.Name = "RegisterForm";
            this.Text = "Register Form";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbRegisterFormUsername;
        private MetroFramework.Controls.MetroTextBox tbRegisterFormPassword;
        private MetroFramework.Controls.MetroTextBox tbRegisterFormConfirmPassword;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroLabel lblConfirmPassword;
        private MetroFramework.Controls.MetroButton btnRegisterFormRegister;
    }
}