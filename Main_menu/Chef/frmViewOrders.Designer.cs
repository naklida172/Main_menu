namespace Main_menu.Chef
{
    partial class frmViewOrders
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
            this.btnSearchUnFinished = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMarkedInProgress = new System.Windows.Forms.Button();
            this.btnMarkCompleted = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtTableNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dtpCreatedTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchUnFinished
            // 
            this.btnSearchUnFinished.BackColor = System.Drawing.Color.Red;
            this.btnSearchUnFinished.Location = new System.Drawing.Point(508, 40);
            this.btnSearchUnFinished.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchUnFinished.Name = "btnSearchUnFinished";
            this.btnSearchUnFinished.Size = new System.Drawing.Size(85, 38);
            this.btnSearchUnFinished.TabIndex = 0;
            this.btnSearchUnFinished.Text = "Unfinished Cuisine";
            this.btnSearchUnFinished.UseVisualStyleBackColor = false;
            this.btnSearchUnFinished.Click += new System.EventHandler(this.btnSearchUnFinished_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSearch.Location = new System.Drawing.Point(311, 48);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 24);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMarkedInProgress
            // 
            this.btnMarkedInProgress.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnMarkedInProgress.Location = new System.Drawing.Point(615, 37);
            this.btnMarkedInProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMarkedInProgress.Name = "btnMarkedInProgress";
            this.btnMarkedInProgress.Size = new System.Drawing.Size(92, 45);
            this.btnMarkedInProgress.TabIndex = 2;
            this.btnMarkedInProgress.Text = "Marked Cuisine \nIn Progress";
            this.btnMarkedInProgress.UseVisualStyleBackColor = false;
            this.btnMarkedInProgress.Click += new System.EventHandler(this.btnMarkedInProgress_Click);
            // 
            // btnMarkCompleted
            // 
            this.btnMarkCompleted.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnMarkCompleted.Location = new System.Drawing.Point(724, 37);
            this.btnMarkCompleted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMarkCompleted.Name = "btnMarkCompleted";
            this.btnMarkCompleted.Size = new System.Drawing.Size(94, 45);
            this.btnMarkCompleted.TabIndex = 3;
            this.btnMarkCompleted.Text = "Marked Cuisine as Completed";
            this.btnMarkCompleted.UseVisualStyleBackColor = false;
            this.btnMarkCompleted.Click += new System.EventHandler(this.btnMarkCompleted_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClear.Location = new System.Drawing.Point(372, 49);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 22);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Order ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Table No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Customer Name:";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(73, 18);
            this.txtOrderId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(52, 20);
            this.txtOrderId.TabIndex = 9;
            // 
            // txtTableNo
            // 
            this.txtTableNo.Location = new System.Drawing.Point(73, 52);
            this.txtTableNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTableNo.Name = "txtTableNo";
            this.txtTableNo.Size = new System.Drawing.Size(52, 20);
            this.txtTableNo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "-";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(229, 52);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(52, 20);
            this.txtCustomerName.TabIndex = 14;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(15, 108);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersWidth = 82;
            this.dgvOrders.RowTemplate.Height = 33;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(964, 322);
            this.dgvOrders.TabIndex = 15;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnShowAll.Location = new System.Drawing.Point(434, 48);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(57, 24);
            this.btnShowAll.TabIndex = 16;
            this.btnShowAll.Text = "ShowAll";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dtpCreatedTimeStart
            // 
            this.dtpCreatedTimeStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpCreatedTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreatedTimeStart.Location = new System.Drawing.Point(201, 18);
            this.dtpCreatedTimeStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpCreatedTimeStart.Name = "dtpCreatedTimeStart";
            this.dtpCreatedTimeStart.Size = new System.Drawing.Size(142, 20);
            this.dtpCreatedTimeStart.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(360, 16);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // frmViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(866, 350);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dtpCreatedTimeStart);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTableNo);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMarkCompleted);
            this.Controls.Add(this.btnMarkedInProgress);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSearchUnFinished);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchUnFinished;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMarkedInProgress;
        private System.Windows.Forms.Button btnMarkCompleted;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DateTimePicker dtpCreatedTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}