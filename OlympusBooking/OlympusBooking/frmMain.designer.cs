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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripGuest = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbarRoom = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbarCheckIn = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbarCheckOut = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbarReserve = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.status.SuspendLayout();
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
            // 
            // newReservationToolStripMenuItem
            // 
            this.newReservationToolStripMenuItem.Name = "newReservationToolStripMenuItem";
            this.newReservationToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.newReservationToolStripMenuItem.Text = "New Reservation";
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
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.checkOutToolStripMenuItem.Text = "Check-Out";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
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
            this.listsToolStripMenuItem.Name = "listsToolStripMenuItem";
            this.listsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.listsToolStripMenuItem.Text = "Lists";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripGuest,
            this.ToolStripSeparator7,
            this.toolbarRoom,
            this.ToolStripSeparator9,
            this.toolbarCheckIn,
            this.ToolStripButton11,
            this.toolbarCheckOut,
            this.ToolStripSeparator6,
            this.toolbarReserve,
            this.ToolStripSeparator8,
            this.ToolStripButton12,
            this.ToolStripSeparator10,
            this.ToolStripButton13});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1007, 39);
            this.ToolStrip1.TabIndex = 15;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripGuest
            // 
            this.ToolStripGuest.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripGuest.Image")));
            this.ToolStripGuest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripGuest.Name = "ToolStripGuest";
            this.ToolStripGuest.Size = new System.Drawing.Size(73, 36);
            this.ToolStripGuest.Text = "Guest";
            this.ToolStripGuest.ToolTipText = "Guest";
            this.ToolStripGuest.Click += new System.EventHandler(this.ToolStripButton10_Click);
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(6, 39);
            // 
            // toolbarRoom
            // 
            this.toolbarRoom.Image = ((System.Drawing.Image)(resources.GetObject("toolbarRoom.Image")));
            this.toolbarRoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarRoom.Name = "toolbarRoom";
            this.toolbarRoom.Size = new System.Drawing.Size(80, 36);
            this.toolbarRoom.Text = "Rooms";
            this.toolbarRoom.ToolTipText = "Room";
            // 
            // ToolStripSeparator9
            // 
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new System.Drawing.Size(6, 39);
            // 
            // toolbarCheckIn
            // 
            this.toolbarCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("toolbarCheckIn.Image")));
            this.toolbarCheckIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarCheckIn.Name = "toolbarCheckIn";
            this.toolbarCheckIn.Size = new System.Drawing.Size(91, 36);
            this.toolbarCheckIn.Text = "Check-in";
            this.toolbarCheckIn.ToolTipText = "Checkin";
            // 
            // ToolStripButton11
            // 
            this.ToolStripButton11.Name = "ToolStripButton11";
            this.ToolStripButton11.Size = new System.Drawing.Size(6, 39);
            // 
            // toolbarCheckOut
            // 
            this.toolbarCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("toolbarCheckOut.Image")));
            this.toolbarCheckOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarCheckOut.Name = "toolbarCheckOut";
            this.toolbarCheckOut.Size = new System.Drawing.Size(94, 36);
            this.toolbarCheckOut.Text = "Checkout";
            this.toolbarCheckOut.ToolTipText = "Checkout";
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // toolbarReserve
            // 
            this.toolbarReserve.Image = ((System.Drawing.Image)(resources.GetObject("toolbarReserve.Image")));
            this.toolbarReserve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarReserve.Name = "toolbarReserve";
            this.toolbarReserve.Size = new System.Drawing.Size(104, 36);
            this.toolbarReserve.Text = "Reservation";
            this.toolbarReserve.ToolTipText = "Reserve";
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(6, 39);
            // 
            // ToolStripButton12
            // 
            this.ToolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton12.Image")));
            this.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton12.Name = "ToolStripButton12";
            this.ToolStripButton12.Size = new System.Drawing.Size(81, 36);
            this.ToolStripButton12.Text = "Logout";
            this.ToolStripButton12.ToolTipText = "Logout";
            // 
            // ToolStripSeparator10
            // 
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            this.ToolStripSeparator10.Size = new System.Drawing.Size(6, 39);
            // 
            // ToolStripButton13
            // 
            this.ToolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton13.Image")));
            this.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton13.Name = "ToolStripButton13";
            this.ToolStripButton13.Size = new System.Drawing.Size(61, 36);
            this.ToolStripButton13.Text = "Exit";
            this.ToolStripButton13.ToolTipText = "Exit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1007, 551);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel4,
            this.ToolStripStatusLabel5,
            this.ToolStripStatusLabel6});
            this.status.Location = new System.Drawing.Point(0, 592);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1007, 22);
            this.status.TabIndex = 17;
            this.status.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel4
            // 
            this.ToolStripStatusLabel4.AutoSize = false;
            this.ToolStripStatusLabel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolStripStatusLabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
            this.ToolStripStatusLabel4.Size = new System.Drawing.Size(330, 17);
            this.ToolStripStatusLabel4.Spring = true;
            this.ToolStripStatusLabel4.Text = "Logged in : ";
            // 
            // ToolStripStatusLabel5
            // 
            this.ToolStripStatusLabel5.AutoSize = false;
            this.ToolStripStatusLabel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
            this.ToolStripStatusLabel5.Size = new System.Drawing.Size(330, 17);
            this.ToolStripStatusLabel5.Spring = true;
            this.ToolStripStatusLabel5.Text = "Olympus Booking";
            // 
            // ToolStripStatusLabel6
            // 
            this.ToolStripStatusLabel6.AutoSize = false;
            this.ToolStripStatusLabel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolStripStatusLabel6.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6";
            this.ToolStripStatusLabel6.Size = new System.Drawing.Size(330, 17);
            this.ToolStripStatusLabel6.Spring = true;
            this.ToolStripStatusLabel6.Text = "Date and Time :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 614);
            this.Controls.Add(this.status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Olympus Booking and Reservations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton toolbarCheckIn;
        internal System.Windows.Forms.ToolStripSeparator ToolStripButton11;
        internal System.Windows.Forms.ToolStripButton toolbarCheckOut;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        internal System.Windows.Forms.ToolStripButton toolbarReserve;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator7;
        internal System.Windows.Forms.ToolStripButton toolbarRoom;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
        internal System.Windows.Forms.ToolStripButton ToolStripGuest;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator9;
        internal System.Windows.Forms.ToolStripButton ToolStripButton12;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator10;
        internal System.Windows.Forms.ToolStripButton ToolStripButton13;
        private System.Windows.Forms.ToolStripMenuItem newGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.StatusStrip status;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel4;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel5;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel6;
        private System.Windows.Forms.ToolStripMenuItem listsToolStripMenuItem;
    }
}