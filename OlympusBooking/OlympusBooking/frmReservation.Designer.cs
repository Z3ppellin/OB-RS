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
			this.cbAdults = new System.Windows.Forms.ComboBox();
			this.tbSubTotal = new System.Windows.Forms.TextBox();
			this.tbNoDays = new System.Windows.Forms.TextBox();
			this.tbRoomRate = new System.Windows.Forms.TextBox();
			this.tbRoomType = new System.Windows.Forms.TextBox();
			this.tbRoomNum = new System.Windows.Forms.TextBox();
			this.tbGuestName = new System.Windows.Forms.TextBox();
			this.lblReservationForm = new System.Windows.Forms.Label();
			this.tpReservationList = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.reservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.databaseDataSet = new OlympusBooking.App_Data.databaseDataSet();
			this.lblReservationList = new System.Windows.Forms.Label();
			this.lvReservation = new System.Windows.Forms.ListView();
			this.reservationTableAdapter = new OlympusBooking.App_Data.databaseDataSetTableAdapters.ReservationTableAdapter();
			this.epGuestName = new System.Windows.Forms.ErrorProvider(this.components);
			this.epRoomNum = new System.Windows.Forms.ErrorProvider(this.components);
			this.reservationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.tcReservation.SuspendLayout();
			this.tpReservation.SuspendLayout();
			this.tpReservationList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epGuestName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epRoomNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).BeginInit();
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
			this.tpReservation.Controls.Add(this.cbAdults);
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
			this.label4.Location = new System.Drawing.Point(55, 230);
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
			this.label3.Text = "Raam Rate                  :";
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
			this.btnCancel.TabIndex = 31;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnReserve
			// 
			this.btnReserve.Location = new System.Drawing.Point(519, 348);
			this.btnReserve.Name = "btnReserve";
			this.btnReserve.Size = new System.Drawing.Size(109, 33);
			this.btnReserve.TabIndex = 30;
			this.btnReserve.Text = "Reserve";
			this.btnReserve.UseVisualStyleBackColor = true;
			this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
			// 
			// dtpCheckOut
			// 
			this.dtpCheckOut.Location = new System.Drawing.Point(214, 265);
			this.dtpCheckOut.Name = "dtpCheckOut";
			this.dtpCheckOut.Size = new System.Drawing.Size(188, 20);
			this.dtpCheckOut.TabIndex = 29;
			// 
			// dtpCheckIn
			// 
			this.dtpCheckIn.Location = new System.Drawing.Point(214, 226);
			this.dtpCheckIn.Name = "dtpCheckIn";
			this.dtpCheckIn.Size = new System.Drawing.Size(188, 20);
			this.dtpCheckIn.TabIndex = 28;
			// 
			// cbAdults
			// 
			this.cbAdults.FormattingEnabled = true;
			this.cbAdults.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
			this.cbAdults.Location = new System.Drawing.Point(562, 75);
			this.cbAdults.Name = "cbAdults";
			this.cbAdults.Size = new System.Drawing.Size(188, 21);
			this.cbAdults.Sorted = true;
			this.cbAdults.TabIndex = 26;
			this.cbAdults.Text = "0";
			// 
			// tbSubTotal
			// 
			this.tbSubTotal.Location = new System.Drawing.Point(562, 118);
			this.tbSubTotal.Multiline = true;
			this.tbSubTotal.Name = "tbSubTotal";
			this.tbSubTotal.Size = new System.Drawing.Size(188, 22);
			this.tbSubTotal.TabIndex = 24;
			// 
			// tbNoDays
			// 
			this.tbNoDays.Location = new System.Drawing.Point(214, 302);
			this.tbNoDays.Multiline = true;
			this.tbNoDays.Name = "tbNoDays";
			this.tbNoDays.Size = new System.Drawing.Size(188, 22);
			this.tbNoDays.TabIndex = 21;
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
			this.tbRoomNum.TabIndex = 16;
			// 
			// tbGuestName
			// 
			this.tbGuestName.Location = new System.Drawing.Point(214, 75);
			this.tbGuestName.Multiline = true;
			this.tbGuestName.Name = "tbGuestName";
			this.tbGuestName.Size = new System.Drawing.Size(188, 22);
			this.tbGuestName.TabIndex = 15;
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
			this.tpReservationList.Controls.Add(this.dataGridView1);
			this.tpReservationList.Controls.Add(this.lblReservationList);
			this.tpReservationList.Controls.Add(this.lvReservation);
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
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationIDDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.reservationBindingSource1;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(754, 389);
			this.dataGridView1.TabIndex = 2;
			// 
			// reservationIDDataGridViewTextBoxColumn
			// 
			this.reservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID";
			this.reservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID";
			this.reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
			this.reservationIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// reservationBindingSource
			// 
			this.reservationBindingSource.DataMember = "Reservation";
			this.reservationBindingSource.DataSource = this.databaseDataSet;
			// 
			// databaseDataSet
			// 
			this.databaseDataSet.DataSetName = "databaseDataSet";
			this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// lblReservationList
			// 
			this.lblReservationList.AutoSize = true;
			this.lblReservationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReservationList.Location = new System.Drawing.Point(16, 16);
			this.lblReservationList.Name = "lblReservationList";
			this.lblReservationList.Size = new System.Drawing.Size(139, 20);
			this.lblReservationList.TabIndex = 1;
			this.lblReservationList.Text = "Reservation List";
			// 
			// lvReservation
			// 
			this.lvReservation.Location = new System.Drawing.Point(20, 39);
			this.lvReservation.Name = "lvReservation";
			this.lvReservation.Size = new System.Drawing.Size(718, 338);
			this.lvReservation.TabIndex = 0;
			this.lvReservation.UseCompatibleStateImageBehavior = false;
			// 
			// reservationTableAdapter
			// 
			this.reservationTableAdapter.ClearBeforeFill = true;
			// 
			// epGuestName
			// 
			this.epGuestName.ContainerControl = this;
			// 
			// epRoomNum
			// 
			this.epRoomNum.ContainerControl = this;
			// 
			// reservationBindingSource1
			// 
			this.reservationBindingSource1.DataMember = "Reservation";
			this.reservationBindingSource1.DataSource = this.databaseDataSet;
			// 
			// frmReservation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tcReservation);
			this.Name = "frmReservation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reservation";
			this.Load += new System.EventHandler(this.frmReservation_Load);
			this.tcReservation.ResumeLayout(false);
			this.tpReservation.ResumeLayout(false);
			this.tpReservation.PerformLayout();
			this.tpReservationList.ResumeLayout(false);
			this.tpReservationList.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epGuestName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epRoomNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tcReservation;
        private System.Windows.Forms.TabPage tpReservation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.ComboBox cbAdults;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.TextBox tbNoDays;
        private System.Windows.Forms.TextBox tbRoomRate;
        private System.Windows.Forms.TextBox tbRoomType;
        private System.Windows.Forms.TextBox tbRoomNum;
        private System.Windows.Forms.TextBox tbGuestName;
        private System.Windows.Forms.Label lblReservationForm;
        private System.Windows.Forms.TabPage tpReservationList;
        private System.Windows.Forms.Label lblReservationList;
        private System.Windows.Forms.ListView lvReservation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private App_Data.databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private App_Data.databaseDataSetTableAdapters.ReservationTableAdapter reservationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
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
		private System.Windows.Forms.BindingSource reservationBindingSource1;
	}
}