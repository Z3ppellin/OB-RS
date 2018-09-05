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
            this.tbcCheckIn = new System.Windows.Forms.TabControl();
            this.tpCheckInForm = new System.Windows.Forms.TabPage();
            this.tbCheckInList = new System.Windows.Forms.TabPage();
            this.lblCheckInForm = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomRate = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblNoDays = new System.Windows.Forms.Label();
            this.lblAdults = new System.Windows.Forms.Label();
            this.lblChildren = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.tbGuestName = new System.Windows.Forms.TextBox();
            this.tbRoomNumber = new System.Windows.Forms.TextBox();
            this.tbRoomType = new System.Windows.Forms.TextBox();
            this.tbRoomRate = new System.Windows.Forms.TextBox();
            this.tbCheckInDate = new System.Windows.Forms.TextBox();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.tbNoOfDays = new System.Windows.Forms.TextBox();
            this.cbAdults = new System.Windows.Forms.ComboBox();
            this.cbChildren = new System.Windows.Forms.ComboBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblCheckInList = new System.Windows.Forms.Label();
            this.tbcCheckIn.SuspendLayout();
            this.tpCheckInForm.SuspendLayout();
            this.tbCheckInList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCheckIn
            // 
            this.tbcCheckIn.Controls.Add(this.tpCheckInForm);
            this.tbcCheckIn.Controls.Add(this.tbCheckInList);
            this.tbcCheckIn.Location = new System.Drawing.Point(12, 12);
            this.tbcCheckIn.Name = "tbcCheckIn";
            this.tbcCheckIn.SelectedIndex = 0;
            this.tbcCheckIn.Size = new System.Drawing.Size(796, 424);
            this.tbcCheckIn.TabIndex = 0;
            // 
            // tpCheckInForm
            // 
            this.tpCheckInForm.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tpCheckInForm.Controls.Add(this.tbBalance);
            this.tpCheckInForm.Controls.Add(this.tbTotal);
            this.tpCheckInForm.Controls.Add(this.cbChildren);
            this.tpCheckInForm.Controls.Add(this.cbAdults);
            this.tpCheckInForm.Controls.Add(this.tbNoOfDays);
            this.tpCheckInForm.Controls.Add(this.dtpCheckOutDate);
            this.tpCheckInForm.Controls.Add(this.tbCheckInDate);
            this.tpCheckInForm.Controls.Add(this.tbRoomRate);
            this.tpCheckInForm.Controls.Add(this.tbRoomType);
            this.tpCheckInForm.Controls.Add(this.tbRoomNumber);
            this.tpCheckInForm.Controls.Add(this.tbGuestName);
            this.tpCheckInForm.Controls.Add(this.lblBalance);
            this.tpCheckInForm.Controls.Add(this.lblSubTotal);
            this.tpCheckInForm.Controls.Add(this.lblChildren);
            this.tpCheckInForm.Controls.Add(this.lblAdults);
            this.tpCheckInForm.Controls.Add(this.lblNoDays);
            this.tpCheckInForm.Controls.Add(this.lblCheckOutDate);
            this.tpCheckInForm.Controls.Add(this.lblCheckInDate);
            this.tpCheckInForm.Controls.Add(this.lblRoomRate);
            this.tpCheckInForm.Controls.Add(this.lblRoomType);
            this.tpCheckInForm.Controls.Add(this.lblRoomNumber);
            this.tpCheckInForm.Controls.Add(this.lblGuestName);
            this.tpCheckInForm.Controls.Add(this.btnCancel);
            this.tpCheckInForm.Controls.Add(this.btnCheckIn);
            this.tpCheckInForm.Controls.Add(this.lblCheckInForm);
            this.tpCheckInForm.Location = new System.Drawing.Point(4, 22);
            this.tpCheckInForm.Name = "tpCheckInForm";
            this.tpCheckInForm.Padding = new System.Windows.Forms.Padding(3);
            this.tpCheckInForm.Size = new System.Drawing.Size(788, 398);
            this.tpCheckInForm.TabIndex = 0;
            this.tpCheckInForm.Text = "Check in form";
            // 
            // tbCheckInList
            // 
            this.tbCheckInList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCheckInList.Controls.Add(this.lblCheckInList);
            this.tbCheckInList.Controls.Add(this.dtpTo);
            this.tbCheckInList.Controls.Add(this.dtpFrom);
            this.tbCheckInList.Controls.Add(this.listView1);
            this.tbCheckInList.Location = new System.Drawing.Point(4, 22);
            this.tbCheckInList.Name = "tbCheckInList";
            this.tbCheckInList.Padding = new System.Windows.Forms.Padding(3);
            this.tbCheckInList.Size = new System.Drawing.Size(788, 398);
            this.tbCheckInList.TabIndex = 1;
            this.tbCheckInList.Text = "Check in list";
            // 
            // lblCheckInForm
            // 
            this.lblCheckInForm.AutoSize = true;
            this.lblCheckInForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInForm.Location = new System.Drawing.Point(323, 12);
            this.lblCheckInForm.Name = "lblCheckInForm";
            this.lblCheckInForm.Size = new System.Drawing.Size(126, 20);
            this.lblCheckInForm.TabIndex = 0;
            this.lblCheckInForm.Text = "Check In Form";
            this.lblCheckInForm.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(592, 336);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(92, 39);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(690, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.Location = new System.Drawing.Point(46, 68);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(80, 16);
            this.lblGuestName.TabIndex = 3;
            this.lblGuestName.Text = "Guest name";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(46, 109);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(87, 16);
            this.lblRoomNumber.TabIndex = 4;
            this.lblRoomNumber.Text = "room number";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(46, 151);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(80, 16);
            this.lblRoomType.TabIndex = 5;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblRoomRate
            // 
            this.lblRoomRate.AutoSize = true;
            this.lblRoomRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomRate.Location = new System.Drawing.Point(46, 190);
            this.lblRoomRate.Name = "lblRoomRate";
            this.lblRoomRate.Size = new System.Drawing.Size(77, 16);
            this.lblRoomRate.TabIndex = 6;
            this.lblRoomRate.Text = "Room Rate";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInDate.Location = new System.Drawing.Point(46, 226);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(91, 16);
            this.lblCheckInDate.TabIndex = 7;
            this.lblCheckInDate.Text = "Check In Date";
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutDate.Location = new System.Drawing.Point(46, 264);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(101, 16);
            this.lblCheckOutDate.TabIndex = 8;
            this.lblCheckOutDate.Text = "Check Out Date";
            // 
            // lblNoDays
            // 
            this.lblNoDays.AutoSize = true;
            this.lblNoDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDays.Location = new System.Drawing.Point(46, 303);
            this.lblNoDays.Name = "lblNoDays";
            this.lblNoDays.Size = new System.Drawing.Size(80, 16);
            this.lblNoDays.TabIndex = 9;
            this.lblNoDays.Text = "No. Of Days";
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdults.Location = new System.Drawing.Point(477, 68);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(85, 16);
            this.lblAdults.TabIndex = 10;
            this.lblAdults.Text = "No. Of Adults";
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildren.Location = new System.Drawing.Point(475, 112);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(97, 16);
            this.lblChildren.TabIndex = 11;
            this.lblChildren.Text = "No. Of Children";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(477, 151);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(66, 16);
            this.lblSubTotal.TabIndex = 13;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(475, 225);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(92, 16);
            this.lblBalance.TabIndex = 15;
            this.lblBalance.Text = "Total Balance";
            // 
            // tbGuestName
            // 
            this.tbGuestName.Location = new System.Drawing.Point(171, 68);
            this.tbGuestName.Name = "tbGuestName";
            this.tbGuestName.Size = new System.Drawing.Size(153, 20);
            this.tbGuestName.TabIndex = 16;
            // 
            // tbRoomNumber
            // 
            this.tbRoomNumber.Location = new System.Drawing.Point(171, 109);
            this.tbRoomNumber.Name = "tbRoomNumber";
            this.tbRoomNumber.Size = new System.Drawing.Size(153, 20);
            this.tbRoomNumber.TabIndex = 17;
            // 
            // tbRoomType
            // 
            this.tbRoomType.Location = new System.Drawing.Point(171, 148);
            this.tbRoomType.Name = "tbRoomType";
            this.tbRoomType.Size = new System.Drawing.Size(153, 20);
            this.tbRoomType.TabIndex = 18;
            // 
            // tbRoomRate
            // 
            this.tbRoomRate.Location = new System.Drawing.Point(171, 186);
            this.tbRoomRate.Name = "tbRoomRate";
            this.tbRoomRate.Size = new System.Drawing.Size(153, 20);
            this.tbRoomRate.TabIndex = 19;
            // 
            // tbCheckInDate
            // 
            this.tbCheckInDate.Location = new System.Drawing.Point(171, 222);
            this.tbCheckInDate.Name = "tbCheckInDate";
            this.tbCheckInDate.ReadOnly = true;
            this.tbCheckInDate.Size = new System.Drawing.Size(153, 20);
            this.tbCheckInDate.TabIndex = 20;
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Location = new System.Drawing.Point(171, 266);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckOutDate.TabIndex = 21;
            // 
            // tbNoOfDays
            // 
            this.tbNoOfDays.Location = new System.Drawing.Point(171, 303);
            this.tbNoOfDays.Name = "tbNoOfDays";
            this.tbNoOfDays.Size = new System.Drawing.Size(153, 20);
            this.tbNoOfDays.TabIndex = 22;
            // 
            // cbAdults
            // 
            this.cbAdults.FormattingEnabled = true;
            this.cbAdults.Location = new System.Drawing.Point(612, 68);
            this.cbAdults.Name = "cbAdults";
            this.cbAdults.Size = new System.Drawing.Size(54, 21);
            this.cbAdults.TabIndex = 23;
            this.cbAdults.Text = "0";
            // 
            // cbChildren
            // 
            this.cbChildren.FormattingEnabled = true;
            this.cbChildren.Location = new System.Drawing.Point(612, 108);
            this.cbChildren.Name = "cbChildren";
            this.cbChildren.Size = new System.Drawing.Size(54, 21);
            this.cbChildren.TabIndex = 24;
            this.cbChildren.Text = "0";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(614, 151);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(135, 20);
            this.tbTotal.TabIndex = 25;
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(614, 224);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(135, 20);
            this.tbBalance.TabIndex = 27;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(15, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(767, 327);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(15, 370);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(221, 370);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 2;
            // 
            // lblCheckInList
            // 
            this.lblCheckInList.AutoSize = true;
            this.lblCheckInList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInList.Location = new System.Drawing.Point(11, 14);
            this.lblCheckInList.Name = "lblCheckInList";
            this.lblCheckInList.Size = new System.Drawing.Size(114, 20);
            this.lblCheckInList.TabIndex = 4;
            this.lblCheckInList.Text = "Check In List";
            // 
            // frmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 448);
            this.Controls.Add(this.tbcCheckIn);
            this.Name = "frmCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check_In";
            this.Load += new System.EventHandler(this.frmCheckIn_Load);
            this.tbcCheckIn.ResumeLayout(false);
            this.tpCheckInForm.ResumeLayout(false);
            this.tpCheckInForm.PerformLayout();
            this.tbCheckInList.ResumeLayout(false);
            this.tbCheckInList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCheckIn;
        private System.Windows.Forms.TabPage tpCheckInForm;
        private System.Windows.Forms.Label lblCheckInForm;
        private System.Windows.Forms.TabPage tbCheckInList;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.ComboBox cbChildren;
        private System.Windows.Forms.ComboBox cbAdults;
        private System.Windows.Forms.TextBox tbNoOfDays;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.TextBox tbCheckInDate;
        private System.Windows.Forms.TextBox tbRoomRate;
        private System.Windows.Forms.TextBox tbRoomType;
        private System.Windows.Forms.TextBox tbRoomNumber;
        private System.Windows.Forms.TextBox tbGuestName;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.Label lblNoDays;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblRoomRate;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label lblCheckInList;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ListView listView1;
    }
}