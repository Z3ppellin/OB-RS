namespace OlympusBooking
{
    partial class frmRoom
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
            this.tcRoom = new System.Windows.Forms.TabControl();
            this.tpNewRoom = new System.Windows.Forms.TabPage();
            this.lblRoomRate = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRoomRate = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblNewRoom = new System.Windows.Forms.Label();
            this.tpRoomList = new System.Windows.Forms.TabPage();
            this.lblRoomList = new System.Windows.Forms.Label();
            this.lvRoomList = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet = new OlympusBooking.App_Data.databaseDataSet();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new OlympusBooking.App_Data.databaseDataSetTableAdapters.RoomTableAdapter();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfPeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcRoom.SuspendLayout();
            this.tpNewRoom.SuspendLayout();
            this.tpRoomList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcRoom
            // 
            this.tcRoom.AllowDrop = true;
            this.tcRoom.Controls.Add(this.tpNewRoom);
            this.tcRoom.Controls.Add(this.tpRoomList);
            this.tcRoom.Location = new System.Drawing.Point(12, 12);
            this.tcRoom.Name = "tcRoom";
            this.tcRoom.SelectedIndex = 0;
            this.tcRoom.Size = new System.Drawing.Size(651, 389);
            this.tcRoom.TabIndex = 0;
            // 
            // tpNewRoom
            // 
            this.tpNewRoom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tpNewRoom.Controls.Add(this.lblRoomRate);
            this.tpNewRoom.Controls.Add(this.lblRoomType);
            this.tpNewRoom.Controls.Add(this.lblRoomNumber);
            this.tpNewRoom.Controls.Add(this.btnCancel);
            this.tpNewRoom.Controls.Add(this.btnSave);
            this.tpNewRoom.Controls.Add(this.txtRoomRate);
            this.tpNewRoom.Controls.Add(this.txtRoomType);
            this.tpNewRoom.Controls.Add(this.txtRoomNumber);
            this.tpNewRoom.Controls.Add(this.lblNewRoom);
            this.tpNewRoom.Location = new System.Drawing.Point(4, 22);
            this.tpNewRoom.Name = "tpNewRoom";
            this.tpNewRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tpNewRoom.Size = new System.Drawing.Size(643, 363);
            this.tpNewRoom.TabIndex = 1;
            this.tpNewRoom.Text = "New Room";
            // 
            // lblRoomRate
            // 
            this.lblRoomRate.AutoSize = true;
            this.lblRoomRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomRate.Location = new System.Drawing.Point(43, 168);
            this.lblRoomRate.Name = "lblRoomRate";
            this.lblRoomRate.Size = new System.Drawing.Size(134, 16);
            this.lblRoomRate.TabIndex = 16;
            this.lblRoomRate.Text = "Room Rate                  :";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(43, 138);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(134, 16);
            this.lblRoomType.TabIndex = 15;
            this.lblRoomType.Text = "Room Type                 :";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(43, 111);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(135, 16);
            this.lblRoomNumber.TabIndex = 14;
            this.lblRoomNumber.Text = "Room Number            :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(342, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 37);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(238, 286);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 37);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRoomRate
            // 
            this.txtRoomRate.Location = new System.Drawing.Point(204, 167);
            this.txtRoomRate.Multiline = true;
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.Size = new System.Drawing.Size(188, 22);
            this.txtRoomRate.TabIndex = 7;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(204, 137);
            this.txtRoomType.Multiline = true;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(188, 22);
            this.txtRoomType.TabIndex = 6;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(204, 108);
            this.txtRoomNumber.Multiline = true;
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(188, 22);
            this.txtRoomNumber.TabIndex = 5;
            // 
            // lblNewRoom
            // 
            this.lblNewRoom.AutoSize = true;
            this.lblNewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRoom.Location = new System.Drawing.Point(42, 37);
            this.lblNewRoom.Name = "lblNewRoom";
            this.lblNewRoom.Size = new System.Drawing.Size(95, 20);
            this.lblNewRoom.TabIndex = 0;
            this.lblNewRoom.Text = "New Room";
            // 
            // tpRoomList
            // 
            this.tpRoomList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tpRoomList.Controls.Add(this.dataGridView1);
            this.tpRoomList.Controls.Add(this.lblRoomList);
            this.tpRoomList.Controls.Add(this.lvRoomList);
            this.tpRoomList.Location = new System.Drawing.Point(4, 22);
            this.tpRoomList.Name = "tpRoomList";
            this.tpRoomList.Padding = new System.Windows.Forms.Padding(3);
            this.tpRoomList.Size = new System.Drawing.Size(643, 363);
            this.tpRoomList.TabIndex = 2;
            this.tpRoomList.Text = "Room List";
            // 
            // lblRoomList
            // 
            this.lblRoomList.AutoSize = true;
            this.lblRoomList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomList.Location = new System.Drawing.Point(11, 13);
            this.lblRoomList.Name = "lblRoomList";
            this.lblRoomList.Size = new System.Drawing.Size(90, 20);
            this.lblRoomList.TabIndex = 1;
            this.lblRoomList.Text = "Room List";
            // 
            // lvRoomList
            // 
            this.lvRoomList.Location = new System.Drawing.Point(15, 36);
            this.lvRoomList.Name = "lvRoomList";
            this.lvRoomList.Size = new System.Drawing.Size(612, 312);
            this.lvRoomList.TabIndex = 0;
            this.lvRoomList.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumberDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.roomRateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.noOfPeopleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(637, 357);
            this.dataGridView1.TabIndex = 2;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.databaseDataSet;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            this.roomTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomRateDataGridViewTextBoxColumn
            // 
            this.roomRateDataGridViewTextBoxColumn.DataPropertyName = "RoomRate";
            this.roomRateDataGridViewTextBoxColumn.HeaderText = "RoomRate";
            this.roomRateDataGridViewTextBoxColumn.Name = "roomRateDataGridViewTextBoxColumn";
            this.roomRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noOfPeopleDataGridViewTextBoxColumn
            // 
            this.noOfPeopleDataGridViewTextBoxColumn.DataPropertyName = "NoOfPeople";
            this.noOfPeopleDataGridViewTextBoxColumn.HeaderText = "NoOfPeople";
            this.noOfPeopleDataGridViewTextBoxColumn.Name = "noOfPeopleDataGridViewTextBoxColumn";
            this.noOfPeopleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 413);
            this.Controls.Add(this.tcRoom);
            this.Name = "frmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room";
            this.Load += new System.EventHandler(this.frmRoom_Load);
            this.tcRoom.ResumeLayout(false);
            this.tpNewRoom.ResumeLayout(false);
            this.tpNewRoom.PerformLayout();
            this.tpRoomList.ResumeLayout(false);
            this.tpRoomList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcRoom;
        private System.Windows.Forms.TabPage tpNewRoom;
        private System.Windows.Forms.TextBox txtRoomRate;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblNewRoom;
        private System.Windows.Forms.TabPage tpRoomList;
        private System.Windows.Forms.Label lblRoomList;
        private System.Windows.Forms.ListView lvRoomList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblRoomRate;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private App_Data.databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private App_Data.databaseDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfPeopleDataGridViewTextBoxColumn;
    }
}