namespace OlympusBooking
{
	partial class frmAdminConfirm
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
			this.lblAdminPassword = new System.Windows.Forms.Label();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tbAdminPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblAdminPassword
			// 
			this.lblAdminPassword.AutoSize = true;
			this.lblAdminPassword.Location = new System.Drawing.Point(68, 45);
			this.lblAdminPassword.Name = "lblAdminPassword";
			this.lblAdminPassword.Size = new System.Drawing.Size(85, 13);
			this.lblAdminPassword.TabIndex = 1;
			this.lblAdminPassword.Text = "Admin Password";
			// 
			// btnConfirm
			// 
			this.btnConfirm.Location = new System.Drawing.Point(71, 87);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(75, 23);
			this.btnConfirm.TabIndex = 2;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(152, 87);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// tbAdminPassword
			// 
			this.tbAdminPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbAdminPassword.Location = new System.Drawing.Point(71, 61);
			this.tbAdminPassword.Name = "tbAdminPassword";
			this.tbAdminPassword.PasswordChar = '•';
			this.tbAdminPassword.Size = new System.Drawing.Size(156, 20);
			this.tbAdminPassword.TabIndex = 5;
			// 
			// frmAdminConfirm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(312, 160);
			this.Controls.Add(this.tbAdminPassword);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.lblAdminPassword);
			this.Name = "frmAdminConfirm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin Confirm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblAdminPassword;
		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox tbAdminPassword;
	}
}