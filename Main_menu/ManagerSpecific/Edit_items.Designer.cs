namespace Main_menu
{
    partial class Edit_items
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
            this.lstbxItems = new System.Windows.Forms.ListBox();
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxItems
            // 
            this.lstbxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxItems.FormattingEnabled = true;
            this.lstbxItems.ItemHeight = 16;
            this.lstbxItems.Location = new System.Drawing.Point(110, 24);
            this.lstbxItems.Name = "lstbxItems";
            this.lstbxItems.ScrollAlwaysVisible = true;
            this.lstbxItems.Size = new System.Drawing.Size(619, 260);
            this.lstbxItems.TabIndex = 0;
            this.lstbxItems.SelectedIndexChanged += new System.EventHandler(this.lstbxItems_SelectedIndexChanged);
            // 
            // txtbxID
            // 
            this.txtbxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxID.Location = new System.Drawing.Point(341, 294);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.Size = new System.Drawing.Size(131, 47);
            this.txtbxID.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(341, 361);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(131, 55);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(49, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 55);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(501, 302);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(191, 33);
            this.lblSelect.TabIndex = 4;
            this.lblSelect.Text = "Select item id";
            // 
            // Edit_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtbxID);
            this.Controls.Add(this.lstbxItems);
            this.Name = "Edit_items";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxItems;
        private System.Windows.Forms.TextBox txtbxID;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSelect;
    }
}