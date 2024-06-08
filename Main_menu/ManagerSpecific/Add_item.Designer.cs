namespace Main_menu
{
    partial class Add_item
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
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxCategory = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.txtbsDescription = new System.Windows.Forms.TextBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblCallories = new System.Windows.Forms.Label();
            this.txtbxIngredients = new System.Windows.Forms.TextBox();
            this.txtbxCallories = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxIfFood = new System.Windows.Forms.CheckBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbxName
            // 
            this.txtbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxName.Location = new System.Drawing.Point(142, 86);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(132, 29);
            this.txtbxName.TabIndex = 3;
            this.txtbxName.TextChanged += new System.EventHandler(this.txtbxName_TextChanged);
            // 
            // txtbxCategory
            // 
            this.txtbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCategory.Location = new System.Drawing.Point(142, 141);
            this.txtbxCategory.Name = "txtbxCategory";
            this.txtbxCategory.Size = new System.Drawing.Size(132, 29);
            this.txtbxCategory.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(37, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(37, 144);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(85, 24);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(37, 250);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 24);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(37, 192);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(104, 24);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description";
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPrice.Location = new System.Drawing.Point(142, 247);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(132, 29);
            this.txtbxPrice.TabIndex = 8;
            // 
            // txtbsDescription
            // 
            this.txtbsDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbsDescription.Location = new System.Drawing.Point(142, 192);
            this.txtbsDescription.Name = "txtbsDescription";
            this.txtbsDescription.Size = new System.Drawing.Size(132, 29);
            this.txtbsDescription.TabIndex = 7;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.ForeColor = System.Drawing.Color.Gray;
            this.lblIngredients.Location = new System.Drawing.Point(413, 147);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(103, 24);
            this.lblIngredients.TabIndex = 14;
            this.lblIngredients.Text = "Ingredients";
            // 
            // lblCallories
            // 
            this.lblCallories.AutoSize = true;
            this.lblCallories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallories.ForeColor = System.Drawing.Color.Gray;
            this.lblCallories.Location = new System.Drawing.Point(413, 89);
            this.lblCallories.Name = "lblCallories";
            this.lblCallories.Size = new System.Drawing.Size(82, 24);
            this.lblCallories.TabIndex = 13;
            this.lblCallories.Text = "Callories";
            // 
            // txtbxIngredients
            // 
            this.txtbxIngredients.BackColor = System.Drawing.Color.Gray;
            this.txtbxIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxIngredients.Location = new System.Drawing.Point(518, 144);
            this.txtbxIngredients.Name = "txtbxIngredients";
            this.txtbxIngredients.Size = new System.Drawing.Size(132, 29);
            this.txtbxIngredients.TabIndex = 12;
            // 
            // txtbxCallories
            // 
            this.txtbxCallories.BackColor = System.Drawing.Color.Gray;
            this.txtbxCallories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCallories.Location = new System.Drawing.Point(518, 89);
            this.txtbxCallories.Name = "txtbxCallories";
            this.txtbxCallories.Size = new System.Drawing.Size(132, 29);
            this.txtbxCallories.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(577, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(211, 31);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(268, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(218, 46);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxIfFood
            // 
            this.cbxIfFood.AutoSize = true;
            this.cbxIfFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIfFood.Location = new System.Drawing.Point(41, 27);
            this.cbxIfFood.Name = "cbxIfFood";
            this.cbxIfFood.Size = new System.Drawing.Size(179, 41);
            this.cbxIfFood.TabIndex = 19;
            this.cbxIfFood.Text = "Food item";
            this.cbxIfFood.UseVisualStyleBackColor = true;
            this.cbxIfFood.CheckedChanged += new System.EventHandler(this.cbxIfFood_CheckedChanged);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(370, 402);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 13);
            this.lblTest.TabIndex = 20;
            // 
            // Add_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.cbxIfFood);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblCallories);
            this.Controls.Add(this.txtbxIngredients);
            this.Controls.Add(this.txtbxCallories);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtbxPrice);
            this.Controls.Add(this.txtbsDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtbxCategory);
            this.Controls.Add(this.txtbxName);
            this.Name = "Add_item";
            this.Text = "Add_item";
            this.Load += new System.EventHandler(this.Add_item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.TextBox txtbsDescription;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblCallories;
        private System.Windows.Forms.TextBox txtbxIngredients;
        private System.Windows.Forms.TextBox txtbxCallories;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbxIfFood;
        private System.Windows.Forms.Label lblTest;
    }
}