namespace OlympusBooking
{
    partial class frmGuest
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.tblName = new System.Windows.Forms.TextBox();
            this.tbfName = new System.Windows.Forms.TextBox();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lbllName = new System.Windows.Forms.Label();
            this.lblfName = new System.Windows.Forms.Label();
            this.lblNewGuest = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblGuestList2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(19, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 390);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage1.Controls.Add(this.cbGender);
            this.tabPage1.Controls.Add(this.tbEmail);
            this.tabPage1.Controls.Add(this.tbAdd);
            this.tabPage1.Controls.Add(this.tblName);
            this.tabPage1.Controls.Add(this.tbfName);
            this.tabPage1.Controls.Add(this.tbNum);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.lblGender);
            this.tabPage1.Controls.Add(this.lblNum);
            this.tabPage1.Controls.Add(this.lblAdd);
            this.tabPage1.Controls.Add(this.lbllName);
            this.tabPage1.Controls.Add(this.lblfName);
            this.tabPage1.Controls.Add(this.lblNewGuest);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Guest";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(157, 211);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 24);
            this.cbGender.TabIndex = 16;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(157, 241);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(188, 28);
            this.tbEmail.TabIndex = 15;
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(157, 143);
            this.tbAdd.Multiline = true;
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(188, 28);
            this.tbAdd.TabIndex = 14;
            // 
            // tblName
            // 
            this.tblName.Location = new System.Drawing.Point(157, 109);
            this.tblName.Multiline = true;
            this.tblName.Name = "tblName";
            this.tblName.Size = new System.Drawing.Size(188, 28);
            this.tblName.TabIndex = 12;
            // 
            // tbfName
            // 
            this.tbfName.Location = new System.Drawing.Point(157, 75);
            this.tbfName.Multiline = true;
            this.tbfName.Name = "tbfName";
            this.tbfName.Size = new System.Drawing.Size(188, 28);
            this.tbfName.TabIndex = 11;
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(157, 177);
            this.tbNum.Multiline = true;
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(188, 28);
            this.tbNum.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(377, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 37);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSave.Location = new System.Drawing.Point(274, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 37);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(45, 253);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(96, 16);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email Address";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(45, 219);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(53, 16);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(45, 189);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(104, 16);
            this.lblNum.TabIndex = 5;
            this.lblNum.Text = "Contact Number";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(45, 155);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(59, 16);
            this.lblAdd.TabIndex = 4;
            this.lblAdd.Text = "Address";
            // 
            // lbllName
            // 
            this.lbllName.AutoSize = true;
            this.lbllName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllName.Location = new System.Drawing.Point(45, 121);
            this.lbllName.Name = "lbllName";
            this.lbllName.Size = new System.Drawing.Size(73, 16);
            this.lbllName.TabIndex = 2;
            this.lbllName.Text = "Last Name";
            // 
            // lblfName
            // 
            this.lblfName.AutoSize = true;
            this.lblfName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfName.Location = new System.Drawing.Point(45, 87);
            this.lblfName.Name = "lblfName";
            this.lblfName.Size = new System.Drawing.Size(73, 16);
            this.lblfName.TabIndex = 1;
            this.lblfName.Text = "First Name";
            // 
            // lblNewGuest
            // 
            this.lblNewGuest.AutoSize = true;
            this.lblNewGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewGuest.Location = new System.Drawing.Point(45, 38);
            this.lblNewGuest.Name = "lblNewGuest";
            this.lblNewGuest.Size = new System.Drawing.Size(143, 20);
            this.lblNewGuest.TabIndex = 0;
            this.lblNewGuest.Text = "New Guest Form";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage2.Controls.Add(this.lblGuestList2);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Guest List";
            // 
            // lblGuestList2
            // 
            this.lblGuestList2.AutoSize = true;
            this.lblGuestList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestList2.Location = new System.Drawing.Point(31, 27);
            this.lblGuestList2.Name = "lblGuestList2";
            this.lblGuestList2.Size = new System.Drawing.Size(92, 20);
            this.lblGuestList2.TabIndex = 1;
            this.lblGuestList2.Text = "Guest List";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(25, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(714, 278);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.TextBox tblName;
        private System.Windows.Forms.TextBox tbfName;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lbllName;
        private System.Windows.Forms.Label lblfName;
        private System.Windows.Forms.Label lblNewGuest;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblGuestList2;
        private System.Windows.Forms.ListView listView1;
    }
}