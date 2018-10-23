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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.cbChildren = new System.Windows.Forms.ComboBox();
            this.cbAdults = new System.Windows.Forms.ComboBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.tbNoDays = new System.Windows.Forms.TextBox();
            this.tbRoomRate = new System.Windows.Forms.TextBox();
            this.tbRoomType = new System.Windows.Forms.TextBox();
            this.tbRoomNum = new System.Windows.Forms.TextBox();
            this.tbGuestName = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblChildren = new System.Windows.Forms.Label();
            this.lblAdults = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblRoomRate = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblReservationForm = new System.Windows.Forms.Label();
            this.tpReservationList = new System.Windows.Forms.TabPage();
            this.lblReservationList = new System.Windows.Forms.Label();
            this.lvReservation = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet = new OlympusBooking.App_Data.databaseDataSet();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationTableAdapter = new OlympusBooking.App_Data.databaseDataSetTableAdapters.ReservationTableAdapter();
            this.reservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcReservation.SuspendLayout();
            this.tpReservation.SuspendLayout();
            this.tpReservationList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
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
            this.tpReservation.Controls.Add(this.btnCancel);
            this.tpReservation.Controls.Add(this.btnReserve);
            this.tpReservation.Controls.Add(this.dtpCheckOut);
            this.tpReservation.Controls.Add(this.dtpCheckIn);
            this.tpReservation.Controls.Add(this.cbChildren);
            this.tpReservation.Controls.Add(this.cbAdults);
            this.tpReservation.Controls.Add(this.tbTotal);
            this.tpReservation.Controls.Add(this.tbSubTotal);
            this.tpReservation.Controls.Add(this.tbNoDays);
            this.tpReservation.Controls.Add(this.tbRoomRate);
            this.tpReservation.Controls.Add(this.tbRoomType);
            this.tpReservation.Controls.Add(this.tbRoomNum);
            this.tpReservation.Controls.Add(this.tbGuestName);
            this.tpReservation.Controls.Add(this.lblTotal);
            this.tpReservation.Controls.Add(this.lblSubTotal);
            this.tpReservation.Controls.Add(this.lblChildren);
            this.tpReservation.Controls.Add(this.lblAdults);
            this.tpReservation.Controls.Add(this.lblDays);
            this.tpReservation.Controls.Add(this.lblCheckOut);
            this.tpReservation.Controls.Add(this.lblCheckIn);
            this.tpReservation.Controls.Add(this.lblRoomRate);
            this.tpReservation.Controls.Add(this.lblRoomType);
            this.tpReservation.Controls.Add(this.lblRoomNumber);
            this.tpReservation.Controls.Add(this.lblGuestName);
            this.tpReservation.Controls.Add(this.lblReservationForm);
            this.tpReservation.Location = new System.Drawing.Point(4, 22);
            this.tpReservation.Name = "tpReservation";
            this.tpReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tpReservation.Size = new System.Drawing.Size(760, 395);
            this.tpReservation.TabIndex = 0;
            this.tpReservation.Text = "Reservation Form";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(598, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 33);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(471, 348);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(109, 33);
            this.btnReserve.TabIndex = 30;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(214, 271);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckOut.TabIndex = 29;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(214, 236);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckIn.TabIndex = 28;
            // 
            // cbChildren
            // 
            this.cbChildren.FormattingEnabled = true;
            this.cbChildren.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbChildren.Location = new System.Drawing.Point(568, 118);
            this.cbChildren.Name = "cbChildren";
            this.cbChildren.Size = new System.Drawing.Size(121, 21);
            this.cbChildren.TabIndex = 27;
            this.cbChildren.Text = "0";
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
            this.cbAdults.Location = new System.Drawing.Point(568, 81);
            this.cbAdults.Name = "cbAdults";
            this.cbAdults.Size = new System.Drawing.Size(121, 21);
            this.cbAdults.Sorted = true;
            this.cbAdults.TabIndex = 26;
            this.cbAdults.Text = "0";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(598, 291);
            this.tbTotal.Multiline = true;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(109, 27);
            this.tbTotal.TabIndex = 25;
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Location = new System.Drawing.Point(568, 156);
            this.tbSubTotal.Multiline = true;
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.Size = new System.Drawing.Size(164, 27);
            this.tbSubTotal.TabIndex = 24;
            // 
            // tbNoDays
            // 
            this.tbNoDays.Location = new System.Drawing.Point(214, 302);
            this.tbNoDays.Multiline = true;
            this.tbNoDays.Name = "tbNoDays";
            this.tbNoDays.Size = new System.Drawing.Size(164, 27);
            this.tbNoDays.TabIndex = 21;
            // 
            // tbRoomRate
            // 
            this.tbRoomRate.Location = new System.Drawing.Point(214, 193);
            this.tbRoomRate.Multiline = true;
            this.tbRoomRate.Name = "tbRoomRate";
            this.tbRoomRate.Size = new System.Drawing.Size(164, 27);
            this.tbRoomRate.TabIndex = 18;
            // 
            // tbRoomType
            // 
            this.tbRoomType.Location = new System.Drawing.Point(214, 156);
            this.tbRoomType.Multiline = true;
            this.tbRoomType.Name = "tbRoomType";
            this.tbRoomType.Size = new System.Drawing.Size(164, 27);
            this.tbRoomType.TabIndex = 17;
            // 
            // tbRoomNum
            // 
            this.tbRoomNum.Location = new System.Drawing.Point(214, 118);
            this.tbRoomNum.Multiline = true;
            this.tbRoomNum.Name = "tbRoomNum";
            this.tbRoomNum.Size = new System.Drawing.Size(164, 27);
            this.tbRoomNum.TabIndex = 16;
            // 
            // tbGuestName
            // 
            this.tbGuestName.Location = new System.Drawing.Point(214, 75);
            this.tbGuestName.Multiline = true;
            this.tbGuestName.Name = "tbGuestName";
            this.tbGuestName.Size = new System.Drawing.Size(164, 27);
            this.tbGuestName.TabIndex = 15;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(457, 291);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(457, 163);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(77, 20);
            this.lblSubTotal.TabIndex = 12;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildren.Location = new System.Drawing.Point(457, 125);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(67, 20);
            this.lblChildren.TabIndex = 10;
            this.lblChildren.Text = "Children";
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdults.Location = new System.Drawing.Point(457, 82);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(54, 20);
            this.lblAdults.TabIndex = 9;
            this.lblAdults.Text = "Adults";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(39, 309);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(94, 20);
            this.lblDays.TabIndex = 8;
            this.lblDays.Text = "No. Of Days";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(39, 271);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(123, 20);
            this.lblCheckOut.TabIndex = 7;
            this.lblCheckOut.Text = "Check Out Date";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(39, 236);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(111, 20);
            this.lblCheckIn.TabIndex = 6;
            this.lblCheckIn.Text = "Check In Date";
            // 
            // lblRoomRate
            // 
            this.lblRoomRate.AutoSize = true;
            this.lblRoomRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomRate.Location = new System.Drawing.Point(39, 200);
            this.lblRoomRate.Name = "lblRoomRate";
            this.lblRoomRate.Size = new System.Drawing.Size(91, 20);
            this.lblRoomRate.TabIndex = 5;
            this.lblRoomRate.Text = "Room Rate";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(39, 163);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(90, 20);
            this.lblRoomType.TabIndex = 4;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(39, 125);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(112, 20);
            this.lblRoomNumber.TabIndex = 3;
            this.lblRoomNumber.Text = "Room Number";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.Location = new System.Drawing.Point(39, 91);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(99, 20);
            this.lblGuestName.TabIndex = 2;
            this.lblGuestName.Text = "Guest Name";
            // 
            // lblReservationForm
            // 
            this.lblReservationForm.AutoSize = true;
            this.lblReservationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationForm.Location = new System.Drawing.Point(271, 30);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservationBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(754, 389);
            this.dataGridView1.TabIndex = 2;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // reservationIDDataGridViewTextBoxColumn
            // 
            this.reservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            this.reservationIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcReservation;
        private System.Windows.Forms.TabPage tpReservation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.ComboBox cbChildren;
        private System.Windows.Forms.ComboBox cbAdults;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.TextBox tbNoDays;
        private System.Windows.Forms.TextBox tbRoomRate;
        private System.Windows.Forms.TextBox tbRoomType;
        private System.Windows.Forms.TextBox tbRoomNum;
        private System.Windows.Forms.TextBox tbGuestName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblRoomRate;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblReservationForm;
        private System.Windows.Forms.TabPage tpReservationList;
        private System.Windows.Forms.Label lblReservationList;
        private System.Windows.Forms.ListView lvReservation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private App_Data.databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private App_Data.databaseDataSetTableAdapters.ReservationTableAdapter reservationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
    }
}