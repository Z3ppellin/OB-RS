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
            this.tcRoom.Location = new System.Drawing.Point(12, 12);
            this.tcRoom.Name = "tcRoom";
            this.tcRoom.SelectedIndex = 0;
            this.tcRoom.Size = new System.Drawing.Size(669, 385);
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
            this.tpNewRoom.Size = new System.Drawing.Size(661, 359);
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
            this.tpRoomList.Controls.Add(this.lblRoomList);
            this.tpRoomList.Controls.Add(this.lvRoomList);
            this.tpRoomList.Location = new System.Drawing.Point(4, 22);
            this.tpRoomList.Name = "tpRoomList";
            this.tpRoomList.Padding = new System.Windows.Forms.Padding(3);
            this.tpRoomList.Size = new System.Drawing.Size(661, 359);
            this.tpRoomList.TabIndex = 2;
            this.tpRoomList.Text = "Room List";
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
            // lvRoomList
            // 
            this.lvRoomList.Location = new System.Drawing.Point(15, 60);
            this.lvRoomList.Name = "lvRoomList";
            this.lvRoomList.Size = new System.Drawing.Size(507, 252);
            this.lvRoomList.TabIndex = 0;
            this.lvRoomList.UseCompatibleStateImageBehavior = false;
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 409);
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
    }
}