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
            this.tcRoom = new System.Windows.Forms.TabControl();
            this.tpNewRoom = new System.Windows.Forms.TabPage();
            this.lblNewRoom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRoomNumber = new System.Windows.Forms.TextBox();
            this.tbRoomType = new System.Windows.Forms.TextBox();
            this.tbRoomRate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbNumPeople = new System.Windows.Forms.ComboBox();
            this.tpRoomList = new System.Windows.Forms.TabPage();
            this.lvRoomList = new System.Windows.Forms.ListView();
            this.lblRoomList = new System.Windows.Forms.Label();
            this.tcRoom.SuspendLayout();
            this.tpNewRoom.SuspendLayout();
            this.tpRoomList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcRoom
            // 
            this.tcRoom.AllowDrop = true;
            this.tcRoom.Controls.Add(this.tpNewRoom);
            this.tcRoom.Controls.Add(this.tpRoomList);
            this.tcRoom.Location = new System.Drawing.Point(20, 21);
            this.tcRoom.Name = "tcRoom";
            this.tcRoom.SelectedIndex = 0;
            this.tcRoom.Size = new System.Drawing.Size(560, 361);
            this.tcRoom.TabIndex = 0;
            // 
            // tpNewRoom
            // 
            this.tpNewRoom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tpNewRoom.Controls.Add(this.cbNumPeople);
            this.tpNewRoom.Controls.Add(this.btnCancel);
            this.tpNewRoom.Controls.Add(this.btnSave);
            this.tpNewRoom.Controls.Add(this.tbRoomRate);
            this.tpNewRoom.Controls.Add(this.tbRoomType);
            this.tpNewRoom.Controls.Add(this.tbRoomNumber);
            this.tpNewRoom.Controls.Add(this.label4);
            this.tpNewRoom.Controls.Add(this.label3);
            this.tpNewRoom.Controls.Add(this.label2);
            this.tpNewRoom.Controls.Add(this.label1);
            this.tpNewRoom.Controls.Add(this.lblNewRoom);
            this.tpNewRoom.Location = new System.Drawing.Point(4, 22);
            this.tpNewRoom.Name = "tpNewRoom";
            this.tpNewRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tpNewRoom.Size = new System.Drawing.Size(552, 335);
            this.tpNewRoom.TabIndex = 1;
            this.tpNewRoom.Text = "New Room";
            // 
            // lblNewRoom
            // 
            this.lblNewRoom.AutoSize = true;
            this.lblNewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRoom.Location = new System.Drawing.Point(227, 20);
            this.lblNewRoom.Name = "lblNewRoom";
            this.lblNewRoom.Size = new System.Drawing.Size(95, 20);
            this.lblNewRoom.TabIndex = 0;
            this.lblNewRoom.Text = "New Room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of People";
            // 
            // tbRoomNumber
            // 
            this.tbRoomNumber.Location = new System.Drawing.Point(160, 90);
            this.tbRoomNumber.Multiline = true;
            this.tbRoomNumber.Name = "tbRoomNumber";
            this.tbRoomNumber.Size = new System.Drawing.Size(59, 30);
            this.tbRoomNumber.TabIndex = 5;
            // 
            // tbRoomType
            // 
            this.tbRoomType.Location = new System.Drawing.Point(160, 128);
            this.tbRoomType.Multiline = true;
            this.tbRoomType.Name = "tbRoomType";
            this.tbRoomType.Size = new System.Drawing.Size(201, 30);
            this.tbRoomType.TabIndex = 6;
            // 
            // tbRoomRate
            // 
            this.tbRoomRate.Location = new System.Drawing.Point(160, 168);
            this.tbRoomRate.Multiline = true;
            this.tbRoomRate.Name = "tbRoomRate";
            this.tbRoomRate.Size = new System.Drawing.Size(90, 30);
            this.tbRoomRate.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(315, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 43);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(415, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 43);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbNumPeople
            // 
            this.cbNumPeople.FormattingEnabled = true;
            this.cbNumPeople.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbNumPeople.Location = new System.Drawing.Point(160, 213);
            this.cbNumPeople.Name = "cbNumPeople";
            this.cbNumPeople.Size = new System.Drawing.Size(121, 21);
            this.cbNumPeople.TabIndex = 11;
            this.cbNumPeople.Text = "0";
            // 
            // tpRoomList
            // 
            this.tpRoomList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tpRoomList.Controls.Add(this.lblRoomList);
            this.tpRoomList.Controls.Add(this.lvRoomList);
            this.tpRoomList.Location = new System.Drawing.Point(4, 22);
            this.tpRoomList.Name = "tpRoomList";
            this.tpRoomList.Padding = new System.Windows.Forms.Padding(3);
            this.tpRoomList.Size = new System.Drawing.Size(552, 335);
            this.tpRoomList.TabIndex = 2;
            this.tpRoomList.Text = "Room List";
            // 
            // lvRoomList
            // 
            this.lvRoomList.Location = new System.Drawing.Point(15, 60);
            this.lvRoomList.Name = "lvRoomList";
            this.lvRoomList.Size = new System.Drawing.Size(507, 252);
            this.lvRoomList.TabIndex = 0;
            this.lvRoomList.UseCompatibleStateImageBehavior = false;
            // 
            // lblRoomList
            // 
            this.lblRoomList.AutoSize = true;
            this.lblRoomList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomList.Location = new System.Drawing.Point(223, 19);
            this.lblRoomList.Name = "lblRoomList";
            this.lblRoomList.Size = new System.Drawing.Size(90, 20);
            this.lblRoomList.TabIndex = 1;
            this.lblRoomList.Text = "Room List";
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 412);
            this.Controls.Add(this.tcRoom);
            this.Name = "frmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room";
            this.tcRoom.ResumeLayout(false);
            this.tpNewRoom.ResumeLayout(false);
            this.tpNewRoom.PerformLayout();
            this.tpRoomList.ResumeLayout(false);
            this.tpRoomList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcRoom;
        private System.Windows.Forms.TabPage tpNewRoom;
        private System.Windows.Forms.ComboBox cbNumPeople;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbRoomRate;
        private System.Windows.Forms.TextBox tbRoomType;
        private System.Windows.Forms.TextBox tbRoomNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNewRoom;
        private System.Windows.Forms.TabPage tpRoomList;
        private System.Windows.Forms.Label lblRoomList;
        private System.Windows.Forms.ListView lvRoomList;
    }
}