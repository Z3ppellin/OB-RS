namespace OlympusBooking
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.checkInListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton11 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.status = new System.Windows.Forms.StatusStrip();
            this.lblLoggedIn = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSysName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.removeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.toolbarGuest = new System.Windows.Forms.ToolStripButton();
            this.toolbarRoom = new System.Windows.Forms.ToolStripButton();
            this.toolbarCheckIn = new System.Windows.Forms.ToolStripButton();
            this.toolbarCheckOut = new System.Windows.Forms.ToolStripButton();
            this.toolbarReserve = new System.Windows.Forms.ToolStripButton();
            this.toolbarLogout = new System.Windows.Forms.ToolStripButton();
            this.toolbarExit = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.listsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGuestToolStripMenuItem,
            this.newReservationToolStripMenuItem,
            this.toolStripSeparator1,
            this.checkInToolStripMenuItem,
            this.checkOutToolStripMenuItem,
            this.toolStripSeparator2,
            this.newUserToolStripMenuItem,
            this.removeUserToolStripMenuItem,
            this.toolStripSeparator3,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGuestToolStripMenuItem
            // 
            this.newGuestToolStripMenuItem.Name = "newGuestToolStripMenuItem";
            this.newGuestToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.newGuestToolStripMenuItem.Text = "New Guest";
            this.newGuestToolStripMenuItem.Click += new System.EventHandler(this.newGuestToolStripMenuItem_Click);
            // 
            // newReservationToolStripMenuItem
            // 
            this.newReservationToolStripMenuItem.Name = "newReservationToolStripMenuItem";
            this.newReservationToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.newReservationToolStripMenuItem.Text = "New Reservation";
            this.newReservationToolStripMenuItem.Click += new System.EventHandler(this.newReservationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.checkInToolStripMenuItem.Text = "Check-In";
            this.checkInToolStripMenuItem.Click += new System.EventHandler(this.checkInToolStripMenuItem_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.checkOutToolStripMenuItem.Text = "Check-Out";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.newUserToolStripMenuItem.Text = "New User";
            this.newUserToolStripMenuItem.Visible = false;
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(159, 6);
            this.toolStripSeparator3.Visible = false;
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.logOutToolStripMenuItem.Text = "Log-Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // listsToolStripMenuItem
            // 
            this.listsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationsToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.toolStripSeparator4,
            this.checkInListToolStripMenuItem,
            this.guestListToolStripMenuItem});
            this.listsToolStripMenuItem.Name = "listsToolStripMenuItem";
            this.listsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.listsToolStripMenuItem.Text = "Lists";
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.reservationsToolStripMenuItem.Text = "Reservation List";
            this.reservationsToolStripMenuItem.Click += new System.EventHandler(this.reservationsToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.roomsToolStripMenuItem.Text = "Room List";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(153, 6);
            // 
            // checkInListToolStripMenuItem
            // 
            this.checkInListToolStripMenuItem.Name = "checkInListToolStripMenuItem";
            this.checkInListToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.checkInListToolStripMenuItem.Text = "Check-In List";
            this.checkInListToolStripMenuItem.Click += new System.EventHandler(this.checkInListToolStripMenuItem_Click);
            // 
            // guestListToolStripMenuItem
            // 
            this.guestListToolStripMenuItem.Name = "guestListToolStripMenuItem";
            this.guestListToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.guestListToolStripMenuItem.Text = "Guest List";
            this.guestListToolStripMenuItem.Click += new System.EventHandler(this.guestListToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarGuest,
            this.ToolStripSeparator7,
            this.toolbarRoom,
            this.ToolStripSeparator9,
            this.toolbarCheckIn,
            this.ToolStripButton11,
            this.toolbarCheckOut,
            this.ToolStripSeparator6,
            this.toolbarReserve,
            this.ToolStripSeparator8,
            this.toolbarLogout,
            this.ToolStripSeparator10,
            this.toolbarExit});
            this.tsMenu.Location = new System.Drawing.Point(0, 24);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1007, 39);
            this.tsMenu.TabIndex = 15;
            this.tsMenu.Text = "ToolStrip1";
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(6, 39);
            // 
            // ToolStripSeparator9
            // 
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new System.Drawing.Size(6, 39);
            // 
            // ToolStripButton11
            // 
            this.ToolStripButton11.Name = "ToolStripButton11";
            this.ToolStripButton11.Size = new System.Drawing.Size(6, 39);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(6, 39);
            // 
            // ToolStripSeparator10
            // 
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            this.ToolStripSeparator10.Size = new System.Drawing.Size(6, 39);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLoggedIn,
            this.lblSysName,
            this.lblDateTime});
            this.status.Location = new System.Drawing.Point(0, 592);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1007, 22);
            this.status.TabIndex = 17;
            this.status.Text = "StatusStrip1";
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = false;
            this.lblLoggedIn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblLoggedIn.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(330, 17);
            this.lblLoggedIn.Spring = true;
            this.lblLoggedIn.Text = "Logged in : ";
            // 
            // lblSysName
            // 
            this.lblSysName.AutoSize = false;
            this.lblSysName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSysName.Name = "lblSysName";
            this.lblSysName.Size = new System.Drawing.Size(330, 17);
            this.lblSysName.Spring = true;
            this.lblSysName.Text = "Olympus Booking";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = false;
            this.lblDateTime.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDateTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(330, 17);
            this.lblDateTime.Spring = true;
            this.lblDateTime.Text = "Date and Time :";
            // 
            // tCurrentTime
            // 
            this.tCurrentTime.Interval = 1000;
            this.tCurrentTime.Tick += new System.EventHandler(this.tCurrentTime_Tick);
            // 
            // removeUserToolStripMenuItem
            // 
            this.removeUserToolStripMenuItem.Name = "removeUserToolStripMenuItem";
            this.removeUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeUserToolStripMenuItem.Text = "Remove User";
            this.removeUserToolStripMenuItem.Visible = false;
            this.removeUserToolStripMenuItem.Click += new System.EventHandler(this.removeUserToolStripMenuItem_Click);
            // 
            // pbMain
            // 
            this.pbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pbMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMain.BackgroundImage")));
            this.pbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMain.Image = ((System.Drawing.Image)(resources.GetObject("pbMain.Image")));
            this.pbMain.Location = new System.Drawing.Point(0, 63);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(1007, 551);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMain.TabIndex = 16;
            this.pbMain.TabStop = false;
            // 
            // toolbarGuest
            // 
            this.toolbarGuest.Image = ((System.Drawing.Image)(resources.GetObject("toolbarGuest.Image")));
            this.toolbarGuest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarGuest.Name = "toolbarGuest";
            this.toolbarGuest.Size = new System.Drawing.Size(73, 36);
            this.toolbarGuest.Text = "Guest";
            this.toolbarGuest.ToolTipText = "Guest";
            this.toolbarGuest.Click += new System.EventHandler(this.toolbarGuest_Click);
            // 
            // toolbarRoom
            // 
            this.toolbarRoom.Image = ((System.Drawing.Image)(resources.GetObject("toolbarRoom.Image")));
            this.toolbarRoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarRoom.Name = "toolbarRoom";
            this.toolbarRoom.Size = new System.Drawing.Size(80, 36);
            this.toolbarRoom.Text = "Rooms";
            this.toolbarRoom.ToolTipText = "Room";
            this.toolbarRoom.Click += new System.EventHandler(this.toolbarRoom_Click);
            // 
            // toolbarCheckIn
            // 
            this.toolbarCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("toolbarCheckIn.Image")));
            this.toolbarCheckIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarCheckIn.Name = "toolbarCheckIn";
            this.toolbarCheckIn.Size = new System.Drawing.Size(91, 36);
            this.toolbarCheckIn.Text = "Check-in";
            this.toolbarCheckIn.ToolTipText = "Checkin";
            this.toolbarCheckIn.Click += new System.EventHandler(this.toolbarCheckIn_Click);
            // 
            // toolbarCheckOut
            // 
            this.toolbarCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("toolbarCheckOut.Image")));
            this.toolbarCheckOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarCheckOut.Name = "toolbarCheckOut";
            this.toolbarCheckOut.Size = new System.Drawing.Size(94, 36);
            this.toolbarCheckOut.Text = "Checkout";
            this.toolbarCheckOut.ToolTipText = "Checkout";
            this.toolbarCheckOut.Click += new System.EventHandler(this.toolbarCheckOut_Click);
            // 
            // toolbarReserve
            // 
            this.toolbarReserve.Image = ((System.Drawing.Image)(resources.GetObject("toolbarReserve.Image")));
            this.toolbarReserve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarReserve.Name = "toolbarReserve";
            this.toolbarReserve.Size = new System.Drawing.Size(104, 36);
            this.toolbarReserve.Text = "Reservation";
            this.toolbarReserve.ToolTipText = "Reserve";
            this.toolbarReserve.Click += new System.EventHandler(this.toolbarReserve_Click);
            // 
            // toolbarLogout
            // 
            this.toolbarLogout.Image = ((System.Drawing.Image)(resources.GetObject("toolbarLogout.Image")));
            this.toolbarLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarLogout.Name = "toolbarLogout";
            this.toolbarLogout.Size = new System.Drawing.Size(81, 36);
            this.toolbarLogout.Text = "Logout";
            this.toolbarLogout.ToolTipText = "Logout";
            this.toolbarLogout.Click += new System.EventHandler(this.toolbarLogout_Click);
            // 
            // toolbarExit
            // 
            this.toolbarExit.Image = ((System.Drawing.Image)(resources.GetObject("toolbarExit.Image")));
            this.toolbarExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarExit.Name = "toolbarExit";
            this.toolbarExit.Size = new System.Drawing.Size(61, 36);
            this.toolbarExit.Text = "Exit";
            this.toolbarExit.ToolTipText = "Exit";
            this.toolbarExit.Click += new System.EventHandler(this.toolbarExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 614);
            this.Controls.Add(this.status);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Olympus Booking and Reservations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.ToolStrip tsMenu;
        internal System.Windows.Forms.ToolStripButton toolbarCheckIn;
        internal System.Windows.Forms.ToolStripSeparator ToolStripButton11;
        internal System.Windows.Forms.ToolStripButton toolbarCheckOut;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        internal System.Windows.Forms.ToolStripButton toolbarReserve;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator7;
        internal System.Windows.Forms.ToolStripButton toolbarRoom;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
        internal System.Windows.Forms.ToolStripButton toolbarGuest;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator9;
        internal System.Windows.Forms.ToolStripButton toolbarLogout;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator10;
        internal System.Windows.Forms.ToolStripButton toolbarExit;
        private System.Windows.Forms.ToolStripMenuItem newGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbMain;
        internal System.Windows.Forms.StatusStrip status;
        internal System.Windows.Forms.ToolStripStatusLabel lblLoggedIn;
        internal System.Windows.Forms.ToolStripStatusLabel lblSysName;
        internal System.Windows.Forms.ToolStripStatusLabel lblDateTime;
        private System.Windows.Forms.ToolStripMenuItem listsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem checkInListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Timer tCurrentTime;
		private System.Windows.Forms.ToolStripMenuItem guestListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeUserToolStripMenuItem;
    }
}