using System;

namespace OlympusBooking
{
    partial class frmCheckIn
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.Location = new System.Drawing.Point(107, 164);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(172, 41);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(5, 63);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(97, 20);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(12, 114);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password :";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(108, 54);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(172, 29);
            this.Username.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(109, 105);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(171, 29);
            this.tbPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOG-IN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(385, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnLogin);
            this.Name = "login";
            this.Text = "Security request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
    }
}