namespace OlympusBooking
{
    partial class frmCheckOut
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnCheckOut = new System.Windows.Forms.Button();
			this.txtSubTotal = new System.Windows.Forms.TextBox();
			this.txtNoPeople = new System.Windows.Forms.TextBox();
			this.txtNoDays = new System.Windows.Forms.TextBox();
			this.txtCheckOut = new System.Windows.Forms.TextBox();
			this.txtCheckIn = new System.Windows.Forms.TextBox();
			this.txtRoomRate = new System.Windows.Forms.TextBox();
			this.txtRoomType = new System.Windows.Forms.TextBox();
			this.txtRoomNo = new System.Windows.Forms.TextBox();
			this.txtGuestName = new System.Windows.Forms.TextBox();
			this.lblSubTotal = new System.Windows.Forms.Label();
			this.lblPeople = new System.Windows.Forms.Label();
			this.lblNoDays = new System.Windows.Forms.Label();
			this.lblCheckOut = new System.Windows.Forms.Label();
			this.lblCheckIn = new System.Windows.Forms.Label();
			this.lblRoomRate = new System.Windows.Forms.Label();
			this.lblRoomType = new System.Windows.Forms.Label();
			this.lblRoomNum = new System.Windows.Forms.Label();
			this.lblGuestName = new System.Windows.Forms.Label();
			this.lblCheckOutGuest = new System.Windows.Forms.Label();
			this.epGuest = new System.Windows.Forms.ErrorProvider(this.components);
			this.epRoomNo = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.epGuest)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epRoomNo)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnCheckOut);
			this.panel1.Controls.Add(this.txtSubTotal);
			this.panel1.Controls.Add(this.txtNoPeople);
			this.panel1.Controls.Add(this.txtNoDays);
			this.panel1.Controls.Add(this.txtCheckOut);
			this.panel1.Controls.Add(this.txtCheckIn);
			this.panel1.Controls.Add(this.txtRoomRate);
			this.panel1.Controls.Add(this.txtRoomType);
			this.panel1.Controls.Add(this.txtRoomNo);
			this.panel1.Controls.Add(this.txtGuestName);
			this.panel1.Controls.Add(this.lblSubTotal);
			this.panel1.Controls.Add(this.lblPeople);
			this.panel1.Controls.Add(this.lblNoDays);
			this.panel1.Controls.Add(this.lblCheckOut);
			this.panel1.Controls.Add(this.lblCheckIn);
			this.panel1.Controls.Add(this.lblRoomRate);
			this.panel1.Controls.Add(this.lblRoomType);
			this.panel1.Controls.Add(this.lblRoomNum);
			this.panel1.Controls.Add(this.lblGuestName);
			this.panel1.Controls.Add(this.lblCheckOutGuest);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(751, 360);
			this.panel1.TabIndex = 35;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnCancel.Location = new System.Drawing.Point(588, 298);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(98, 37);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
			// 
			// btnCheckOut
			// 
			this.btnCheckOut.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnCheckOut.Location = new System.Drawing.Point(484, 298);
			this.btnCheckOut.Name = "btnCheckOut";
			this.btnCheckOut.Size = new System.Drawing.Size(98, 37);
			this.btnCheckOut.TabIndex = 1;
			this.btnCheckOut.Text = "Checkout";
			this.btnCheckOut.UseVisualStyleBackColor = false;
			this.btnCheckOut.Click += new System.EventHandler(this.btnCheckout_Click);
			// 
			// txtSubTotal
			// 
			this.txtSubTotal.Location = new System.Drawing.Point(540, 223);
			this.txtSubTotal.Multiline = true;
			this.txtSubTotal.Name = "txtSubTotal";
			this.txtSubTotal.ReadOnly = true;
			this.txtSubTotal.Size = new System.Drawing.Size(134, 30);
			this.txtSubTotal.TabIndex = 53;
			// 
			// txtNoPeople
			// 
			this.txtNoPeople.Location = new System.Drawing.Point(540, 95);
			this.txtNoPeople.Multiline = true;
			this.txtNoPeople.Name = "txtNoPeople";
			this.txtNoPeople.ReadOnly = true;
			this.txtNoPeople.Size = new System.Drawing.Size(90, 22);
			this.txtNoPeople.TabIndex = 52;
			// 
			// txtNoDays
			// 
			this.txtNoDays.Location = new System.Drawing.Point(540, 62);
			this.txtNoDays.Multiline = true;
			this.txtNoDays.Name = "txtNoDays";
			this.txtNoDays.ReadOnly = true;
			this.txtNoDays.Size = new System.Drawing.Size(90, 22);
			this.txtNoDays.TabIndex = 51;
			// 
			// txtCheckOut
			// 
			this.txtCheckOut.Location = new System.Drawing.Point(155, 230);
			this.txtCheckOut.Multiline = true;
			this.txtCheckOut.Name = "txtCheckOut";
			this.txtCheckOut.ReadOnly = true;
			this.txtCheckOut.Size = new System.Drawing.Size(188, 21);
			this.txtCheckOut.TabIndex = 50;
			// 
			// txtCheckIn
			// 
			this.txtCheckIn.Location = new System.Drawing.Point(155, 196);
			this.txtCheckIn.Multiline = true;
			this.txtCheckIn.Name = "txtCheckIn";
			this.txtCheckIn.ReadOnly = true;
			this.txtCheckIn.Size = new System.Drawing.Size(188, 21);
			this.txtCheckIn.TabIndex = 49;
			// 
			// txtRoomRate
			// 
			this.txtRoomRate.Location = new System.Drawing.Point(155, 163);
			this.txtRoomRate.Multiline = true;
			this.txtRoomRate.Name = "txtRoomRate";
			this.txtRoomRate.ReadOnly = true;
			this.txtRoomRate.Size = new System.Drawing.Size(188, 21);
			this.txtRoomRate.TabIndex = 48;
			// 
			// txtRoomType
			// 
			this.txtRoomType.Location = new System.Drawing.Point(155, 129);
			this.txtRoomType.Multiline = true;
			this.txtRoomType.Name = "txtRoomType";
			this.txtRoomType.ReadOnly = true;
			this.txtRoomType.Size = new System.Drawing.Size(188, 21);
			this.txtRoomType.TabIndex = 47;
			// 
			// txtRoomNo
			// 
			this.txtRoomNo.Location = new System.Drawing.Point(155, 95);
			this.txtRoomNo.Multiline = true;
			this.txtRoomNo.Name = "txtRoomNo";
			this.txtRoomNo.Size = new System.Drawing.Size(188, 22);
			this.txtRoomNo.TabIndex = 0;
			this.txtRoomNo.Leave += new System.EventHandler(this.txtRoomNo_Leave);
			// 
			// txtGuestName
			// 
			this.txtGuestName.Location = new System.Drawing.Point(155, 62);
			this.txtGuestName.Multiline = true;
			this.txtGuestName.Name = "txtGuestName";
			this.txtGuestName.ReadOnly = true;
			this.txtGuestName.Size = new System.Drawing.Size(188, 22);
			this.txtGuestName.TabIndex = 45;
			// 
			// lblSubTotal
			// 
			this.lblSubTotal.AutoSize = true;
			this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubTotal.Location = new System.Drawing.Point(394, 231);
			this.lblSubTotal.Name = "lblSubTotal";
			this.lblSubTotal.Size = new System.Drawing.Size(115, 22);
			this.lblSubTotal.TabIndex = 44;
			this.lblSubTotal.Text = "SUBTOTAL";
			// 
			// lblPeople
			// 
			this.lblPeople.AutoSize = true;
			this.lblPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPeople.Location = new System.Drawing.Point(419, 97);
			this.lblPeople.Name = "lblPeople";
			this.lblPeople.Size = new System.Drawing.Size(90, 16);
			this.lblPeople.TabIndex = 43;
			this.lblPeople.Text = "No. of People";
			// 
			// lblNoDays
			// 
			this.lblNoDays.AutoSize = true;
			this.lblNoDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNoDays.Location = new System.Drawing.Point(419, 64);
			this.lblNoDays.Name = "lblNoDays";
			this.lblNoDays.Size = new System.Drawing.Size(78, 16);
			this.lblNoDays.TabIndex = 42;
			this.lblNoDays.Text = "No. of Days";
			// 
			// lblCheckOut
			// 
			this.lblCheckOut.AutoSize = true;
			this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCheckOut.Location = new System.Drawing.Point(22, 230);
			this.lblCheckOut.Name = "lblCheckOut";
			this.lblCheckOut.Size = new System.Drawing.Size(101, 16);
			this.lblCheckOut.TabIndex = 41;
			this.lblCheckOut.Text = "Check Out Date";
			// 
			// lblCheckIn
			// 
			this.lblCheckIn.AutoSize = true;
			this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCheckIn.Location = new System.Drawing.Point(22, 197);
			this.lblCheckIn.Name = "lblCheckIn";
			this.lblCheckIn.Size = new System.Drawing.Size(91, 16);
			this.lblCheckIn.TabIndex = 40;
			this.lblCheckIn.Text = "Check In Date";
			// 
			// lblRoomRate
			// 
			this.lblRoomRate.AutoSize = true;
			this.lblRoomRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRoomRate.Location = new System.Drawing.Point(23, 164);
			this.lblRoomRate.Name = "lblRoomRate";
			this.lblRoomRate.Size = new System.Drawing.Size(77, 16);
			this.lblRoomRate.TabIndex = 39;
			this.lblRoomRate.Text = "Room Rate";
			// 
			// lblRoomType
			// 
			this.lblRoomType.AutoSize = true;
			this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRoomType.Location = new System.Drawing.Point(23, 130);
			this.lblRoomType.Name = "lblRoomType";
			this.lblRoomType.Size = new System.Drawing.Size(80, 16);
			this.lblRoomType.TabIndex = 38;
			this.lblRoomType.Text = "Room Type";
			// 
			// lblRoomNum
			// 
			this.lblRoomNum.AutoSize = true;
			this.lblRoomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRoomNum.Location = new System.Drawing.Point(23, 97);
			this.lblRoomNum.Name = "lblRoomNum";
			this.lblRoomNum.Size = new System.Drawing.Size(96, 16);
			this.lblRoomNum.TabIndex = 37;
			this.lblRoomNum.Text = "Room Number";
			// 
			// lblGuestName
			// 
			this.lblGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGuestName.Location = new System.Drawing.Point(22, 64);
			this.lblGuestName.Name = "lblGuestName";
			this.lblGuestName.Size = new System.Drawing.Size(99, 16);
			this.lblGuestName.TabIndex = 36;
			this.lblGuestName.Text = "Guest Name";
			// 
			// lblCheckOutGuest
			// 
			this.lblCheckOutGuest.AutoSize = true;
			this.lblCheckOutGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCheckOutGuest.Location = new System.Drawing.Point(22, 11);
			this.lblCheckOutGuest.Name = "lblCheckOutGuest";
			this.lblCheckOutGuest.Size = new System.Drawing.Size(147, 20);
			this.lblCheckOutGuest.TabIndex = 35;
			this.lblCheckOutGuest.Text = "Check Out Guest";
			// 
			// epGuest
			// 
			this.epGuest.ContainerControl = this;
			// 
			// epRoomNo
			// 
			this.epRoomNo.ContainerControl = this;
			// 
			// frmCheckOut
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(775, 384);
			this.Controls.Add(this.panel1);
			this.Name = "frmCheckOut";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Check Out";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.epGuest)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epRoomNo)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtNoPeople;
        private System.Windows.Forms.TextBox txtNoDays;
        private System.Windows.Forms.TextBox txtCheckOut;
        private System.Windows.Forms.TextBox txtCheckIn;
        private System.Windows.Forms.TextBox txtRoomRate;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Label lblNoDays;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblRoomRate;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblCheckOutGuest;
        private System.Windows.Forms.ErrorProvider epGuest;
        private System.Windows.Forms.ErrorProvider epRoomNo;
    }
}