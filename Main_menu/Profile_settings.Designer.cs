namespace Main_menu
{
    partial class Profile_settings
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
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeUsername = new System.Windows.Forms.Button();
            this.btnChangeEmail = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNewInfo = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblNewInfo = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnChangePhone = new System.Windows.Forms.Button();
            this.btnChangeAddress = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancelSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(135, 158);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(376, 66);
            this.btnChangePassword.TabIndex = 0;
            this.btnChangePassword.Text = "Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnChangeUsername
            // 
            this.btnChangeUsername.Location = new System.Drawing.Point(135, 256);
            this.btnChangeUsername.Name = "btnChangeUsername";
            this.btnChangeUsername.Size = new System.Drawing.Size(376, 66);
            this.btnChangeUsername.TabIndex = 1;
            this.btnChangeUsername.Text = "Username";
            this.btnChangeUsername.UseVisualStyleBackColor = true;
            this.btnChangeUsername.Click += new System.EventHandler(this.btnChangeUsername_Click);
            // 
            // btnChangeEmail
            // 
            this.btnChangeEmail.Location = new System.Drawing.Point(326, 342);
            this.btnChangeEmail.Name = "btnChangeEmail";
            this.btnChangeEmail.Size = new System.Drawing.Size(376, 66);
            this.btnChangeEmail.TabIndex = 2;
            this.btnChangeEmail.Text = "Email";
            this.btnChangeEmail.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(320, 112);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(389, 31);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "What would  you like to update:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(413, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(214, 67);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNewInfo
            // 
            this.txtNewInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewInfo.Location = new System.Drawing.Point(368, 230);
            this.txtNewInfo.Name = "txtNewInfo";
            this.txtNewInfo.Size = new System.Drawing.Size(276, 47);
            this.txtNewInfo.TabIndex = 5;
            this.txtNewInfo.Visible = false;
            this.txtNewInfo.TextChanged += new System.EventHandler(this.txtNewInfo_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(368, 302);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(276, 47);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Visible = false;
            // 
            // lblNewInfo
            // 
            this.lblNewInfo.AutoSize = true;
            this.lblNewInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInfo.Location = new System.Drawing.Point(174, 242);
            this.lblNewInfo.Name = "lblNewInfo";
            this.lblNewInfo.Size = new System.Drawing.Size(137, 31);
            this.lblNewInfo.TabIndex = 7;
            this.lblNewInfo.Text = "New data:";
            this.lblNewInfo.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(25, 311);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(295, 31);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Your current password:";
            this.lblPassword.Visible = false;
            // 
            // btnChangePhone
            // 
            this.btnChangePhone.Location = new System.Drawing.Point(517, 158);
            this.btnChangePhone.Name = "btnChangePhone";
            this.btnChangePhone.Size = new System.Drawing.Size(376, 66);
            this.btnChangePhone.TabIndex = 9;
            this.btnChangePhone.Text = "Phone";
            this.btnChangePhone.UseVisualStyleBackColor = true;
            this.btnChangePhone.Click += new System.EventHandler(this.btnChangePhone_Click);
            // 
            // btnChangeAddress
            // 
            this.btnChangeAddress.Location = new System.Drawing.Point(517, 256);
            this.btnChangeAddress.Name = "btnChangeAddress";
            this.btnChangeAddress.Size = new System.Drawing.Size(376, 66);
            this.btnChangeAddress.TabIndex = 10;
            this.btnChangeAddress.Text = "Address";
            this.btnChangeAddress.UseVisualStyleBackColor = true;
            this.btnChangeAddress.Click += new System.EventHandler(this.btnChangeAddress_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(326, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(376, 66);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCancelSave
            // 
            this.btnCancelSave.Location = new System.Drawing.Point(413, 506);
            this.btnCancelSave.Name = "btnCancelSave";
            this.btnCancelSave.Size = new System.Drawing.Size(214, 67);
            this.btnCancelSave.TabIndex = 12;
            this.btnCancelSave.Text = "Cancel";
            this.btnCancelSave.UseVisualStyleBackColor = true;
            this.btnCancelSave.Visible = false;
            this.btnCancelSave.Click += new System.EventHandler(this.btnCancelSave_Click);
            // 
            // Profile_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1040, 634);
            this.Controls.Add(this.btnCancelSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangeAddress);
            this.Controls.Add(this.btnChangePhone);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNewInfo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNewInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnChangeEmail);
            this.Controls.Add(this.btnChangeUsername);
            this.Controls.Add(this.btnChangePassword);
            this.Name = "Profile_settings";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangeUsername;
        private System.Windows.Forms.Button btnChangeEmail;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNewInfo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblNewInfo;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnChangePhone;
        private System.Windows.Forms.Button btnChangeAddress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancelSave;
    }
}