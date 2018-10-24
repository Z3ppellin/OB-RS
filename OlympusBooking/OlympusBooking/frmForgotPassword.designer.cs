namespace OlympusBooking
{
	partial class frmForgotPassword
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
            this.components = new System.ComponentModel.Container();
            this.Reset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.lnlUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.epPassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(55, 160);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(143, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(143, 68);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(143, 107);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '•';
            this.tbConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.tbConfirmPassword.TabIndex = 2;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(52, 71);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(78, 13);
            this.lblNewPassword.TabIndex = 4;
            this.lblNewPassword.Text = "New Password";
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(14, 110);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(116, 13);
            this.lblConfirmNewPassword.TabIndex = 5;
            this.lblConfirmNewPassword.Text = "Confirm New Password";
            // 
            // lnlUserName
            // 
            this.lnlUserName.AutoSize = true;
            this.lnlUserName.Location = new System.Drawing.Point(70, 34);
            this.lnlUserName.Name = "lnlUserName";
            this.lnlUserName.Size = new System.Drawing.Size(60, 13);
            this.lnlUserName.TabIndex = 6;
            this.lnlUserName.Text = "User Name";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(143, 31);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 0;
            // 
            // epPassword
            // 
            this.epPassword.ContainerControl = this;
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(319, 198);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lnlUserName);
            this.Controls.Add(this.lblConfirmNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.Reset);
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Reset;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.TextBox tbConfirmPassword;
		private System.Windows.Forms.Label lblNewPassword;
		private System.Windows.Forms.Label lblConfirmNewPassword;
		private System.Windows.Forms.Label lnlUserName;
		private System.Windows.Forms.TextBox tbUserName;
		private System.Windows.Forms.ErrorProvider epPassword;
	}
}