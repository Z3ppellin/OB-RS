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
            this.components = new System.ComponentModel.Container();
            this.tbcCheckIn = new System.Windows.Forms.TabControl();
            this.tpCheckInForm = new System.Windows.Forms.TabPage();
            this.numAdults = new System.Windows.Forms.NumericUpDown();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtNoDays = new System.Windows.Forms.TextBox();
            this.dtpCheckOutTime = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.txtCheckInDate = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtRoomRate = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblPeople = new System.Windows.Forms.Label();
            this.lblNoDays = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblRoomRate = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblCheckInForm = new System.Windows.Forms.Label();
            this.tbCheckInList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new OlympusBooking.App_Data.databaseDataSet();
            this.lblCheckInList = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.checkInTableAdapter = new OlympusBooking.App_Data.databaseDataSetTableAdapters.CheckInTableAdapter();
            this.epRoomNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epGuestName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNumPeople = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkInBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfPeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcCheckIn.SuspendLayout();
            this.tpCheckInForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).BeginInit();
            this.tbCheckInList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRoomNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGuestName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNumPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInBindingSource1)).BeginInit();
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
            this.tpCheckInForm.Controls.Add(this.numAdults);
            this.tpCheckInForm.Controls.Add(this.txtSubTotal);
            this.tpCheckInForm.Controls.Add(this.txtNoDays);
            this.tpCheckInForm.Controls.Add(this.dtpCheckOutTime);
            this.tpCheckInForm.Controls.Add(this.btnCancel);
            this.tpCheckInForm.Controls.Add(this.btnCheckIn);
            this.tpCheckInForm.Controls.Add(this.txtCheckInDate);
            this.tpCheckInForm.Controls.Add(this.lblRoomNumber);
            this.tpCheckInForm.Controls.Add(this.txtRoomRate);
            this.tpCheckInForm.Controls.Add(this.txtRoomType);
            this.tpCheckInForm.Controls.Add(this.dtpCheckOutDate);
            this.tpCheckInForm.Controls.Add(this.txtRoomNumber);
            this.tpCheckInForm.Controls.Add(this.txtGuestName);
            this.tpCheckInForm.Controls.Add(this.lblSubTotal);
            this.tpCheckInForm.Controls.Add(this.lblPeople);
            this.tpCheckInForm.Controls.Add(this.lblNoDays);
            this.tpCheckInForm.Controls.Add(this.lblCheckOutDate);
            this.tpCheckInForm.Controls.Add(this.lblCheckInDate);
            this.tpCheckInForm.Controls.Add(this.lblRoomRate);
            this.tpCheckInForm.Controls.Add(this.lblRoomType);
            this.tpCheckInForm.Controls.Add(this.lblGuestName);
            this.tpCheckInForm.Controls.Add(this.lblCheckInForm);
            this.tpCheckInForm.Location = new System.Drawing.Point(4, 22);
            this.tpCheckInForm.Name = "tpCheckInForm";
            this.tpCheckInForm.Padding = new System.Windows.Forms.Padding(3);
            this.tpCheckInForm.Size = new System.Drawing.Size(788, 398);
            this.tpCheckInForm.TabIndex = 0;
            this.tpCheckInForm.Text = "Check in form";
            // 
            // numAdults
            // 
            this.numAdults.Location = new System.Drawing.Point(558, 109);
            this.numAdults.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numAdults.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdults.Name = "numAdults";
            this.numAdults.Size = new System.Drawing.Size(63, 20);
            this.numAdults.TabIndex = 38;
            this.numAdults.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdults.ValueChanged += new System.EventHandler(this.numAdults_ValueChanged);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(558, 238);
            this.txtSubTotal.Multiline = true;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(134, 30);
            this.txtSubTotal.TabIndex = 36;
            // 
            // txtNoDays
            // 
            this.txtNoDays.Location = new System.Drawing.Point(558, 73);
            this.txtNoDays.Multiline = true;
            this.txtNoDays.Name = "txtNoDays";
            this.txtNoDays.ReadOnly = true;
            this.txtNoDays.Size = new System.Drawing.Size(63, 22);
            this.txtNoDays.TabIndex = 35;
            this.txtNoDays.TextChanged += new System.EventHandler(this.txtNoDays_TextChanged);
            // 
            // dtpCheckOutTime
            // 
            this.dtpCheckOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCheckOutTime.Location = new System.Drawing.Point(278, 248);
            this.dtpCheckOutTime.Name = "dtpCheckOutTime";
            this.dtpCheckOutTime.Size = new System.Drawing.Size(81, 20);
            this.dtpCheckOutTime.TabIndex = 34;
            this.dtpCheckOutTime.Value = new System.DateTime(2018, 10, 23, 9, 0, 0, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(639, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 37);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCheckIn.Location = new System.Drawing.Point(535, 336);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(98, 37);
            this.btnCheckIn.TabIndex = 32;
            this.btnCheckIn.Text = "Save";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // txtCheckInDate
            // 
            this.txtCheckInDate.Location = new System.Drawing.Point(171, 212);
            this.txtCheckInDate.Multiline = true;
            this.txtCheckInDate.Name = "txtCheckInDate";
            this.txtCheckInDate.ReadOnly = true;
            this.txtCheckInDate.Size = new System.Drawing.Size(188, 22);
            this.txtCheckInDate.TabIndex = 31;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(46, 109);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(96, 16);
            this.lblRoomNumber.TabIndex = 30;
            this.lblRoomNumber.Text = "Room Number";
            // 
            // txtRoomRate
            // 
            this.txtRoomRate.Location = new System.Drawing.Point(171, 177);
            this.txtRoomRate.Multiline = true;
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.ReadOnly = true;
            this.txtRoomRate.Size = new System.Drawing.Size(188, 22);
            this.txtRoomRate.TabIndex = 29;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(171, 140);
            this.txtRoomType.Multiline = true;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.ReadOnly = true;
            this.txtRoomType.Size = new System.Drawing.Size(188, 22);
            this.txtRoomType.TabIndex = 28;
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOutDate.Location = new System.Drawing.Point(171, 248);
            this.dtpCheckOutDate.MinDate = new System.DateTime(2018, 10, 24, 0, 0, 0, 0);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(101, 20);
            this.dtpCheckOutDate.TabIndex = 21;
            this.dtpCheckOutDate.Value = new System.DateTime(2018, 10, 25, 0, 0, 0, 0);
            this.dtpCheckOutDate.ValueChanged += new System.EventHandler(this.dtpCheckOutDate_ValueChanged);
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(171, 106);
            this.txtRoomNumber.Multiline = true;
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(188, 22);
            this.txtRoomNumber.TabIndex = 17;
            this.txtRoomNumber.Leave += new System.EventHandler(this.txtRoomNumber_Leave);
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(171, 73);
            this.txtGuestName.Multiline = true;
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(188, 22);
            this.txtGuestName.TabIndex = 16;
            this.txtGuestName.Leave += new System.EventHandler(this.txtGuestName_Leave);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(426, 246);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(115, 22);
            this.lblSubTotal.TabIndex = 13;
            this.lblSubTotal.Text = "SUBTOTAL";
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeople.Location = new System.Drawing.Point(451, 109);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(90, 16);
            this.lblPeople.TabIndex = 10;
            this.lblPeople.Text = "No. of People";
            // 
            // lblNoDays
            // 
            this.lblNoDays.AutoSize = true;
            this.lblNoDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDays.Location = new System.Drawing.Point(451, 74);
            this.lblNoDays.Name = "lblNoDays";
            this.lblNoDays.Size = new System.Drawing.Size(80, 16);
            this.lblNoDays.TabIndex = 9;
            this.lblNoDays.Text = "No. Of Days";
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutDate.Location = new System.Drawing.Point(46, 252);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(101, 16);
            this.lblCheckOutDate.TabIndex = 8;
            this.lblCheckOutDate.Text = "Check Out Date";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInDate.Location = new System.Drawing.Point(46, 213);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(91, 16);
            this.lblCheckInDate.TabIndex = 7;
            this.lblCheckInDate.Text = "Check In Date";
            // 
            // lblRoomRate
            // 
            this.lblRoomRate.AutoSize = true;
            this.lblRoomRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomRate.Location = new System.Drawing.Point(46, 178);
            this.lblRoomRate.Name = "lblRoomRate";
            this.lblRoomRate.Size = new System.Drawing.Size(77, 16);
            this.lblRoomRate.TabIndex = 6;
            this.lblRoomRate.Text = "Room Rate";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(46, 141);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(80, 16);
            this.lblRoomType.TabIndex = 5;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.Location = new System.Drawing.Point(46, 74);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(83, 16);
            this.lblGuestName.TabIndex = 3;
            this.lblGuestName.Text = "Guest Name";
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
            // 
            // tbCheckInList
            // 
            this.tbCheckInList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCheckInList.Controls.Add(this.dataGridView1);
            this.tbCheckInList.Controls.Add(this.lblCheckInList);
            this.tbCheckInList.Controls.Add(this.listView1);
            this.tbCheckInList.Location = new System.Drawing.Point(4, 22);
            this.tbCheckInList.Name = "tbCheckInList";
            this.tbCheckInList.Padding = new System.Windows.Forms.Padding(3);
            this.tbCheckInList.Size = new System.Drawing.Size(788, 398);
            this.tbCheckInList.TabIndex = 1;
            this.tbCheckInList.Text = "Check in list";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transIDDataGridViewTextBoxColumn,
            this.roomNumDataGridViewTextBoxColumn,
            this.checkInDateDataGridViewTextBoxColumn,
            this.checkOutDateDataGridViewTextBoxColumn,
            this.guestNameDataGridViewTextBoxColumn,
            this.noOfDaysDataGridViewTextBoxColumn,
            this.noOfPeopleDataGridViewTextBoxColumn,
            this.totalDueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.checkInBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(782, 392);
            this.dataGridView1.TabIndex = 5;
            // 
            // checkInBindingSource
            // 
            this.checkInBindingSource.DataMember = "CheckIn";
            this.checkInBindingSource.DataSource = this.databaseDataSetBindingSource;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(15, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(767, 327);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // checkInTableAdapter
            // 
            this.checkInTableAdapter.ClearBeforeFill = true;
            // 
            // epRoomNo
            // 
            this.epRoomNo.ContainerControl = this;
            // 
            // epGuestName
            // 
            this.epGuestName.ContainerControl = this;
            // 
            // epNumPeople
            // 
            this.epNumPeople.ContainerControl = this;
            // 
            // checkInBindingSource1
            // 
            this.checkInBindingSource1.DataMember = "CheckIn";
            this.checkInBindingSource1.DataSource = this.databaseDataSet;
            // 
            // transIDDataGridViewTextBoxColumn
            // 
            this.transIDDataGridViewTextBoxColumn.DataPropertyName = "TransID";
            this.transIDDataGridViewTextBoxColumn.HeaderText = "TransID";
            this.transIDDataGridViewTextBoxColumn.Name = "transIDDataGridViewTextBoxColumn";
            this.transIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNumDataGridViewTextBoxColumn
            // 
            this.roomNumDataGridViewTextBoxColumn.DataPropertyName = "RoomNum";
            this.roomNumDataGridViewTextBoxColumn.HeaderText = "RoomNum";
            this.roomNumDataGridViewTextBoxColumn.Name = "roomNumDataGridViewTextBoxColumn";
            this.roomNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkInDateDataGridViewTextBoxColumn
            // 
            this.checkInDateDataGridViewTextBoxColumn.DataPropertyName = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.HeaderText = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.Name = "checkInDateDataGridViewTextBoxColumn";
            this.checkInDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            this.checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.HeaderText = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
            this.checkOutDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestNameDataGridViewTextBoxColumn
            // 
            this.guestNameDataGridViewTextBoxColumn.DataPropertyName = "GuestName";
            this.guestNameDataGridViewTextBoxColumn.HeaderText = "GuestName";
            this.guestNameDataGridViewTextBoxColumn.Name = "guestNameDataGridViewTextBoxColumn";
            this.guestNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noOfDaysDataGridViewTextBoxColumn
            // 
            this.noOfDaysDataGridViewTextBoxColumn.DataPropertyName = "NoOfDays";
            this.noOfDaysDataGridViewTextBoxColumn.HeaderText = "NoOfDays";
            this.noOfDaysDataGridViewTextBoxColumn.Name = "noOfDaysDataGridViewTextBoxColumn";
            this.noOfDaysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noOfPeopleDataGridViewTextBoxColumn
            // 
            this.noOfPeopleDataGridViewTextBoxColumn.DataPropertyName = "NoOfPeople";
            this.noOfPeopleDataGridViewTextBoxColumn.HeaderText = "NoOfPeople";
            this.noOfPeopleDataGridViewTextBoxColumn.Name = "noOfPeopleDataGridViewTextBoxColumn";
            this.noOfPeopleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDueDataGridViewTextBoxColumn
            // 
            this.totalDueDataGridViewTextBoxColumn.DataPropertyName = "TotalDue";
            this.totalDueDataGridViewTextBoxColumn.HeaderText = "TotalDue";
            this.totalDueDataGridViewTextBoxColumn.Name = "totalDueDataGridViewTextBoxColumn";
            this.totalDueDataGridViewTextBoxColumn.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).EndInit();
            this.tbCheckInList.ResumeLayout(false);
            this.tbCheckInList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRoomNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGuestName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNumPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tbcCheckIn;
        private System.Windows.Forms.TabPage tpCheckInForm;
        private System.Windows.Forms.Label lblCheckInForm;
        private System.Windows.Forms.TabPage tbCheckInList;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Label lblNoDays;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblRoomRate;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblCheckInList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtCheckInDate;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtRoomRate;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtNoDays;
        private System.Windows.Forms.DateTimePicker dtpCheckOutTime;
        private System.Windows.Forms.NumericUpDown numAdults;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private App_Data.databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource checkInBindingSource;
        private App_Data.databaseDataSetTableAdapters.CheckInTableAdapter checkInTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfChildDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfAdultDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider epRoomNo;
        private System.Windows.Forms.ErrorProvider epGuestName;
        private System.Windows.Forms.ErrorProvider epNumPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn transIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfPeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource checkInBindingSource1;
    }
}