namespace C__Assignment
{
    partial class Feedback
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.radReservationFeedback = new System.Windows.Forms.RadioButton();
            this.radMenuFeedback = new System.Windows.Forms.RadioButton();
            this.btnSendFeedback = new System.Windows.Forms.Button();
            this.txtFeedback = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 393);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.radReservationFeedback);
            this.groupBox2.Controls.Add(this.radMenuFeedback);
            this.groupBox2.Controls.Add(this.btnSendFeedback);
            this.groupBox2.Controls.Add(this.txtFeedback);
            this.groupBox2.Location = new System.Drawing.Point(6, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 372);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Feedback Form";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(501, 345);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // radReservationFeedback
            // 
            this.radReservationFeedback.AutoSize = true;
            this.radReservationFeedback.Location = new System.Drawing.Point(139, 345);
            this.radReservationFeedback.Name = "radReservationFeedback";
            this.radReservationFeedback.Size = new System.Drawing.Size(166, 20);
            this.radReservationFeedback.TabIndex = 3;
            this.radReservationFeedback.TabStop = true;
            this.radReservationFeedback.Text = "Reservation Feedback";
            this.radReservationFeedback.UseVisualStyleBackColor = true;
            // 
            // radMenuFeedback
            // 
            this.radMenuFeedback.AutoSize = true;
            this.radMenuFeedback.Location = new System.Drawing.Point(7, 345);
            this.radMenuFeedback.Name = "radMenuFeedback";
            this.radMenuFeedback.Size = new System.Drawing.Size(126, 20);
            this.radMenuFeedback.TabIndex = 2;
            this.radMenuFeedback.TabStop = true;
            this.radMenuFeedback.Text = "Menu Feedback";
            this.radMenuFeedback.UseVisualStyleBackColor = true;
            this.radMenuFeedback.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.Location = new System.Drawing.Point(582, 343);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Size = new System.Drawing.Size(75, 23);
            this.btnSendFeedback.TabIndex = 1;
            this.btnSendFeedback.Text = "Send";
            this.btnSendFeedback.UseVisualStyleBackColor = true;
            this.btnSendFeedback.Click += new System.EventHandler(this.btnSendFeedback_Click);
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(0, 21);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(657, 317);
            this.txtFeedback.TabIndex = 0;
            this.txtFeedback.Text = "";
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 417);
            this.Controls.Add(this.groupBox1);
            this.Name = "Feedback";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtFeedback;
        private System.Windows.Forms.RadioButton radReservationFeedback;
        private System.Windows.Forms.RadioButton radMenuFeedback;
        private System.Windows.Forms.Button btnSendFeedback;
        private System.Windows.Forms.Button btnBack;
    }
}