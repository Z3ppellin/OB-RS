namespace OlympusBooking
{
    partial class frmReservation
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
            this.tcReservation = new System.Windows.Forms.TabControl();
            this.tpReservation = new System.Windows.Forms.TabPage();
            this.numAdults = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblfName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.tbNoDays = new System.Windows.Forms.TextBox();
            this.tbRoomRate = new System.Windows.Forms.TextBox();
            this.tbRoomType = new System.Windows.Forms.TextBox();
            this.tbRoomNum = new System.Windows.Forms.TextBox();
            this.tbGuestName = new System.Windows.Forms.TextBox();
            this.lblReservationForm = new System.Windows.Forms.Label();
            this.tpReservationList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reservationBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new OlympusBooking.App_Data.databaseDataSet();
            this.epGuestName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRoomNum = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNoOfPeople = new System.Windows.Forms.ErrorProvider(this.components);
            this.reservationBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.reservationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationTableAdapter = new OlympusBooking.App_Data.databaseDataSetTableAdapters.ReservationTableAdapter();
            this.reservationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.epStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.reservationBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tcReservation.SuspendLayout();
            this.tpReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).BeginInit();
            this.tpReservationList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGuestName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRoomNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNoOfPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // tcReservation
            // 
            this.tcReservation.Controls.Add(this.tpReservation);
            this.tcReservation.Controls.Add(this.tpReservationList);
            this.tcReservation.Location = new System.Drawing.Point(20, 17);
            this.tcReservation.Name = "tcReservation";
            this.tcReservation.SelectedIndex = 0;
            this.tcReservation.Size = new System.Drawing.Size(768, 421);
            this.tcReservation.TabIndex = 0;
            // 
            // tpReservation
            // 
            this.tpReservation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tpReservation.Controls.Add(this.numAdults);
            this.tpReservation.Controls.Add(this.label8);
            this.tpReservation.Controls.Add(this.label7);
            this.tpReservation.Controls.Add(this.label6);
            this.tpReservation.Controls.Add(this.label5);
            this.tpReservation.Controls.Add(this.label4);
            this.tpReservation.Controls.Add(this.label3);
            this.tpReservation.Controls.Add(this.label2);
            this.tpReservation.Controls.Add(this.label1);
            this.tpReservation.Controls.Add(this.lblfName);
            this.tpReservation.Controls.Add(this.btnCancel);
            this.tpReservation.Controls.Add(this.btnReserve);
            this.tpReservation.Controls.Add(this.dtpCheckOut);
            this.tpReservation.Controls.Add(this.dtpCheckIn);
            this.tpReservation.Controls.Add(this.tbSubTotal);
            this.tpReservation.Controls.Add(this.tbNoDays);
            this.tpReservation.Controls.Add(this.tbRoomRate);
            this.tpReservation.Controls.Add(this.tbRoomType);
            this.tpReservation.Controls.Add(this.tbRoomNum);
            this.tpReservation.Controls.Add(this.tbGuestName);
            this.tpReservation.Controls.Add(this.lblReservationForm);
            this.tpReservation.Location = new System.Drawing.Point(4, 22);
            this.tpReservation.Name = "tpReservation";
            this.tpReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tpReservation.Size = new System.Drawing.Size(760, 395);
            this.tpReservation.TabIndex = 0;
            this.tpReservation.Text = "Reservation Form";
            // 
            // numAdults
            // 
            this.numAdults.Location = new System.Drawing.Point(562, 81);
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
            this.numAdults.TabIndex = 4;
            this.numAdults.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdults.ValueChanged += new System.EventHandler(this.numAdults_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(458, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Sub Total          :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(458, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "No. Of People :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "No. Of Days                 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Check Out Date          :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Check In Date             :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Room Rate                  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Room Type                 :    ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Room No.                     ;";
            // 
            // lblfName
            // 
            this.lblfName.AutoSize = true;
            this.lblfName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfName.Location = new System.Drawing.Point(53, 76);
            this.lblfName.Name = "lblfName";
            this.lblfName.Size = new System.Drawing.Size(137, 16);
            this.lblfName.TabIndex = 32;
            this.lblfName.Text = "Guest Name                 :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(634, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 33);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(519, 348);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(109, 33);
            this.btnReserve.TabIndex = 5;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(214, 265);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(188, 20);
            this.dtpCheckOut.TabIndex = 3;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(214, 226);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(188, 20);
            this.dtpCheckIn.TabIndex = 2;
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Location = new System.Drawing.Point(562, 118);
            this.tbSubTotal.Multiline = true;
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.ReadOnly = true;
            this.tbSubTotal.Size = new System.Drawing.Size(188, 22);
            this.tbSubTotal.TabIndex = 24;
            // 
            // tbNoDays
            // 
            this.tbNoDays.Location = new System.Drawing.Point(214, 302);
            this.tbNoDays.Multiline = true;
            this.tbNoDays.Name = "tbNoDays";
            this.tbNoDays.ReadOnly = true;
            this.tbNoDays.Size = new System.Drawing.Size(85, 22);
            this.tbNoDays.TabIndex = 21;
            this.tbNoDays.TextChanged += new System.EventHandler(this.tbNoDays_TextChanged);
            // 
            // tbRoomRate
            // 
            this.tbRoomRate.Location = new System.Drawing.Point(214, 188);
            this.tbRoomRate.Multiline = true;
            this.tbRoomRate.Name = "tbRoomRate";
            this.tbRoomRate.ReadOnly = true;
            this.tbRoomRate.Size = new System.Drawing.Size(188, 22);
            this.tbRoomRate.TabIndex = 18;
            // 
            // tbRoomType
            // 
            this.tbRoomType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbRoomType.Location = new System.Drawing.Point(214, 151);
            this.tbRoomType.Multiline = true;
            this.tbRoomType.Name = "tbRoomType";
            this.tbRoomType.ReadOnly = true;
            this.tbRoomType.Size = new System.Drawing.Size(188, 22);
            this.tbRoomType.TabIndex = 17;
            // 
            // tbRoomNum
            // 
            this.tbRoomNum.Location = new System.Drawing.Point(214, 113);
            this.tbRoomNum.Multiline = true;
            this.tbRoomNum.Name = "tbRoomNum";
            this.tbRoomNum.Size = new System.Drawing.Size(188, 22);
            this.tbRoomNum.TabIndex = 1;
            this.tbRoomNum.TextChanged += new System.EventHandler(this.tbRoomNum_TextChanged);
            this.tbRoomNum.Leave += new System.EventHandler(this.tbRoomNum_Leave);
            this.tbRoomNum.Validating += new System.ComponentModel.CancelEventHandler(this.tbRoomNum_Validating);
            // 
            // tbGuestName
            // 
            this.tbGuestName.Location = new System.Drawing.Point(214, 75);
            this.tbGuestName.Multiline = true;
            this.tbGuestName.Name = "tbGuestName";
            this.tbGuestName.Size = new System.Drawing.Size(188, 22);
            this.tbGuestName.TabIndex = 0;
            this.tbGuestName.Leave += new System.EventHandler(this.tbGuestName_Leave);
            this.tbGuestName.Validating += new System.ComponentModel.CancelEventHandler(this.tbGuestName_Validating);
            // 
            // lblReservationForm
            // 
            this.lblReservationForm.AutoSize = true;
            this.lblReservationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationForm.Location = new System.Drawing.Point(54, 21);
            this.lblReservationForm.Name = "lblReservationForm";
            this.lblReservationForm.Size = new System.Drawing.Size(151, 20);
            this.lblReservationForm.TabIndex = 0;
            this.lblReservationForm.Text = "Reservation Form";
            // 
            // tpReservationList
            // 
            this.tpReservationList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tpReservationList.Controls.Add(this.button1);
            this.tpReservationList.Controls.Add(this.btnDelete);
            this.tpReservationList.Controls.Add(this.dataGridView1);
            this.tpReservationList.Location = new System.Drawing.Point(4, 22);
            this.tpReservationList.Name = "tpReservationList";
            this.tpReservationList.Padding = new System.Windows.Forms.Padding(3);
            this.tpReservationList.Size = new System.Drawing.Size(760, 395);
            this.tpReservationList.TabIndex = 1;
            this.tpReservationList.Text = "Reservation List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(754, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // reservationBindingSource3
            // 
            this.reservationBindingSource3.DataMember = "Reservation";
            this.reservationBindingSource3.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // epGuestName
            // 
            this.epGuestName.ContainerControl = this;
            // 
            // epRoomNum
            // 
            this.epRoomNum.ContainerControl = this;
            // 
            // epNoOfPeople
            // 
            this.epNoOfPeople.ContainerControl = this;
            // 
            // reservationBindingSource4
            // 
            this.reservationBindingSource4.DataMember = "Reservation";
            this.reservationBindingSource4.DataSource = this.databaseDataSet;
            // 
            // reservationBindingSource2
            // 
            this.reservationBindingSource2.DataMember = "Reservation";
            this.reservationBindingSource2.DataSource = this.databaseDataSet;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "Reservation";
            this.reservationBindingSource.DataSource = this.databaseDataSet;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // reservationBindingSource1
            // 
            this.reservationBindingSource1.DataMember = "Reservation";
            this.reservationBindingSource1.DataSource = this.databaseDataSet;
            // 
            // epStatus
            // 
            this.epStatus.ContainerControl = this;
            // 
            // reservationBindingSource5
            // 
            this.reservationBindingSource5.DataMember = "Reservation";
            this.reservationBindingSource5.DataSource = this.databaseDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(297, 366);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcReservation);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.frmReservation_Load);
            this.tcReservation.ResumeLayout(false);
            this.tpReservation.ResumeLayout(false);
            this.tpReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).EndInit();
            this.tpReservationList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGuestName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRoomNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNoOfPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tcReservation;
        private System.Windows.Forms.TabPage tpReservation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.TextBox tbNoDays;
        private System.Windows.Forms.TextBox tbRoomRate;
        private System.Windows.Forms.TextBox tbRoomType;
        private System.Windows.Forms.TextBox tbRoomNum;
        private System.Windows.Forms.TextBox tbGuestName;
        private System.Windows.Forms.Label lblReservationForm;
        private System.Windows.Forms.TabPage tpReservationList;
        private App_Data.databaseDataSet databaseDataSet;
        private App_Data.databaseDataSetTableAdapters.ReservationTableAdapter reservationTableAdapter;
		private System.Windows.Forms.Label lblfName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider epGuestName;
		private System.Windows.Forms.ErrorProvider epRoomNum;
		private System.Windows.Forms.ErrorProvider epNoOfPeople;
		private System.Windows.Forms.NumericUpDown numAdults;
		private System.Windows.Forms.BindingSource reservationBindingSource;
		private System.Windows.Forms.BindingSource reservationBindingSource2;
		private System.Windows.Forms.BindingSource reservationBindingSource1;
		private System.Windows.Forms.BindingSource reservationBindingSource3;
		private System.Windows.Forms.BindingSource reservationBindingSource4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn guestNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomNumDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noOfDaysDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noOfPeopleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalDueDataGridViewTextBoxColumn;
		private System.Windows.Forms.ErrorProvider epStatus;
        private System.Windows.Forms.BindingSource reservationBindingSource5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
    }
}