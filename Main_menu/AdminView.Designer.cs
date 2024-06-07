namespace Main_menu
{
    partial class AdminView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.btnUpdateOwnProfile = new System.Windows.Forms.Button();
            this.btnViewCustomerFeedback = new System.Windows.Forms.Button();
            this.btnViewSalesReport = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.WelcomeText = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 31);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(10, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(737, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.Logo);
            this.panel2.Controls.Add(this.logout);
            this.panel2.Controls.Add(this.btnUpdateOwnProfile);
            this.panel2.Controls.Add(this.btnViewCustomerFeedback);
            this.panel2.Controls.Add(this.btnViewSalesReport);
            this.panel2.Controls.Add(this.btnManageUsers);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.WelcomeText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 481);
            this.panel2.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.Image = global::Main_menu.Properties.Resources.LOGO;
            this.Logo.Location = new System.Drawing.Point(54, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(115, 116);
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(23, 383);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(73, 30);
            this.logout.TabIndex = 2;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // btnUpdateOwnProfile
            // 
            this.btnUpdateOwnProfile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOwnProfile.Location = new System.Drawing.Point(23, 331);
            this.btnUpdateOwnProfile.Name = "btnUpdateOwnProfile";
            this.btnUpdateOwnProfile.Size = new System.Drawing.Size(191, 46);
            this.btnUpdateOwnProfile.TabIndex = 7;
            this.btnUpdateOwnProfile.Text = "UPDATE OWN PROFILE\r\n";
            this.btnUpdateOwnProfile.UseVisualStyleBackColor = true;
            this.btnUpdateOwnProfile.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnViewCustomerFeedback
            // 
            this.btnViewCustomerFeedback.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomerFeedback.Location = new System.Drawing.Point(23, 276);
            this.btnViewCustomerFeedback.Name = "btnViewCustomerFeedback";
            this.btnViewCustomerFeedback.Size = new System.Drawing.Size(191, 49);
            this.btnViewCustomerFeedback.TabIndex = 6;
            this.btnViewCustomerFeedback.Text = "VIEW CUSTOMER FEEDBACK";
            this.btnViewCustomerFeedback.UseVisualStyleBackColor = true;
            // 
            // btnViewSalesReport
            // 
            this.btnViewSalesReport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSalesReport.Location = new System.Drawing.Point(23, 226);
            this.btnViewSalesReport.Name = "btnViewSalesReport";
            this.btnViewSalesReport.Size = new System.Drawing.Size(191, 44);
            this.btnViewSalesReport.TabIndex = 5;
            this.btnViewSalesReport.Text = "VIEW SALES REPORT";
            this.btnViewSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.Location = new System.Drawing.Point(23, 185);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(194, 35);
            this.btnManageUsers.TabIndex = 4;
            this.btnManageUsers.Text = "MANAGE USERS";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(23, 140);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(194, 39);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // WelcomeText
            // 
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WelcomeText.Location = new System.Drawing.Point(33, 121);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(181, 16);
            this.WelcomeText.TabIndex = 1;
            this.WelcomeText.Text = "Welcome to Admin Menu!";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(233, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 481);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(768, 512);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label WelcomeText;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnViewSalesReport;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnUpdateOwnProfile;
        private System.Windows.Forms.Button btnViewCustomerFeedback;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panel3;
    }
}

