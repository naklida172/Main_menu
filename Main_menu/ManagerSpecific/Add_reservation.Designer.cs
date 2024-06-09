namespace Main_menu
{
    partial class Add_reservation
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
            this.lstbxUsers = new System.Windows.Forms.ListBox();
            this.txtbxUsers = new System.Windows.Forms.TextBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.txtbxType = new System.Windows.Forms.TextBox();
            this.lblReservationType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtbxDate = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtbxStatus = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxUsers
            // 
            this.lstbxUsers.FormattingEnabled = true;
            this.lstbxUsers.Location = new System.Drawing.Point(33, 12);
            this.lstbxUsers.Name = "lstbxUsers";
            this.lstbxUsers.Size = new System.Drawing.Size(728, 56);
            this.lstbxUsers.TabIndex = 0;
            this.lstbxUsers.SelectedIndexChanged += new System.EventHandler(this.lstbxUsers_SelectedIndexChanged);
            // 
            // txtbxUsers
            // 
            this.txtbxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxUsers.Location = new System.Drawing.Point(33, 91);
            this.txtbxUsers.Name = "txtbxUsers";
            this.txtbxUsers.Size = new System.Drawing.Size(131, 29);
            this.txtbxUsers.TabIndex = 1;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(193, 99);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(206, 24);
            this.lblUsers.TabIndex = 2;
            this.lblUsers.Text = "Choose user by their ID";
            // 
            // txtbxType
            // 
            this.txtbxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxType.Location = new System.Drawing.Point(33, 147);
            this.txtbxType.Name = "txtbxType";
            this.txtbxType.Size = new System.Drawing.Size(131, 29);
            this.txtbxType.TabIndex = 3;
            // 
            // lblReservationType
            // 
            this.lblReservationType.AutoSize = true;
            this.lblReservationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationType.Location = new System.Drawing.Point(193, 155);
            this.lblReservationType.Name = "lblReservationType";
            this.lblReservationType.Size = new System.Drawing.Size(287, 24);
            this.lblReservationType.TabIndex = 4;
            this.lblReservationType.Text = "What`s the type of the reservation";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(193, 211);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 24);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // txtbxDate
            // 
            this.txtbxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDate.Location = new System.Drawing.Point(33, 203);
            this.txtbxDate.Name = "txtbxDate";
            this.txtbxDate.Size = new System.Drawing.Size(131, 29);
            this.txtbxDate.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(191, 264);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(208, 24);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status of the reservation";
            this.lblStatus.Visible = false;
            // 
            // txtbxStatus
            // 
            this.txtbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxStatus.Location = new System.Drawing.Point(41, 259);
            this.txtbxStatus.Name = "txtbxStatus";
            this.txtbxStatus.Size = new System.Drawing.Size(131, 29);
            this.txtbxStatus.TabIndex = 7;
            this.txtbxStatus.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(602, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 46);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(303, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(159, 46);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(566, 155);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 24);
            this.lblTest.TabIndex = 11;
            this.lblTest.Visible = false;
            // 
            // Add_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtbxStatus);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtbxDate);
            this.Controls.Add(this.lblReservationType);
            this.Controls.Add(this.txtbxType);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.txtbxUsers);
            this.Controls.Add(this.lstbxUsers);
            this.Name = "Add_reservation";
            this.Text = "Add_reservation";
            this.Load += new System.EventHandler(this.Add_reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxUsers;
        private System.Windows.Forms.TextBox txtbxUsers;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.TextBox txtbxType;
        private System.Windows.Forms.Label lblReservationType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtbxDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtbxStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTest;
    }
}