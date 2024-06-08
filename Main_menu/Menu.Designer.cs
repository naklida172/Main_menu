namespace C__Assignment
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDish = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFat = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblKcal = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblProtien = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbDish = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.radOthers = new System.Windows.Forms.RadioButton();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.radMiddleEastern = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radMalay = new System.Windows.Forms.RadioButton();
            this.radIndian = new System.Windows.Forms.RadioButton();
            this.radChinese = new System.Windows.Forms.RadioButton();
            this.radWestern = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDish)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuisine:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dish :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Min :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cboDish
            // 
            this.cboDish.FormattingEnabled = true;
            this.cboDish.Location = new System.Drawing.Point(62, 327);
            this.cboDish.Name = "cboDish";
            this.cboDish.Size = new System.Drawing.Size(121, 28);
            this.cboDish.TabIndex = 6;
            
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.btnCompare);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnContinue);
            this.groupBox1.Controls.Add(this.radOthers);
            this.groupBox1.Controls.Add(this.txtMax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.radMiddleEastern);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radMalay);
            this.groupBox1.Controls.Add(this.radIndian);
            this.groupBox1.Controls.Add(this.radChinese);
            this.groupBox1.Controls.Add(this.radWestern);
            this.groupBox1.Controls.Add(this.cboDish);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 396);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(304, 50);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 24;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare.Location = new System.Drawing.Point(242, 245);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(34, 23);
            this.btnCompare.TabIndex = 23;
            this.btnCompare.Text = "C";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(304, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pbDish);
            this.groupBox2.Location = new System.Drawing.Point(384, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 361);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dish Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblFat);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.lblKcal);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.lblProtien);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lblCarbs);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(0, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 118);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nutrition Value(Per Serving)";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFat.Location = new System.Drawing.Point(55, 66);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(2, 22);
            this.lblFat.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 20);
            this.label17.TabIndex = 11;
            this.label17.Text = "Fat:";
            // 
            // lblKcal
            // 
            this.lblKcal.AutoSize = true;
            this.lblKcal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKcal.Location = new System.Drawing.Point(55, 36);
            this.lblKcal.Name = "lblKcal";
            this.lblKcal.Size = new System.Drawing.Size(2, 22);
            this.lblKcal.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 20);
            this.label19.TabIndex = 9;
            this.label19.Text = "Kcal:";
            // 
            // lblProtien
            // 
            this.lblProtien.AutoSize = true;
            this.lblProtien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProtien.Location = new System.Drawing.Point(212, 66);
            this.lblProtien.Name = "lblProtien";
            this.lblProtien.Size = new System.Drawing.Size(2, 22);
            this.lblProtien.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(138, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Protien:";
            // 
            // lblCarbs
            // 
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCarbs.Location = new System.Drawing.Point(212, 36);
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.Size = new System.Drawing.Size(2, 22);
            this.lblCarbs.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(150, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 20);
            this.label15.TabIndex = 5;
            this.label15.Text = "Carbs:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrice.Location = new System.Drawing.Point(68, 218);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(2, 22);
            this.lblPrice.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Price:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(68, 188);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(2, 22);
            this.lblName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name:";
            // 
            // pbDish
            // 
            this.pbDish.Location = new System.Drawing.Point(6, 27);
            this.pbDish.Name = "pbDish";
            this.pbDish.Size = new System.Drawing.Size(316, 140);
            this.pbDish.TabIndex = 0;
            this.pbDish.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Food:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(304, 108);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(303, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(10, 361);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 15;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // radOthers
            // 
            this.radOthers.AutoSize = true;
            this.radOthers.Location = new System.Drawing.Point(167, 46);
            this.radOthers.Name = "radOthers";
            this.radOthers.Size = new System.Drawing.Size(79, 24);
            this.radOthers.TabIndex = 14;
            this.radOthers.TabStop = true;
            this.radOthers.Text = "Others";
            this.radOthers.UseVisualStyleBackColor = true;
            this.radOthers.CheckedChanged += new System.EventHandler(this.radOthers_CheckedChanged);
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(177, 248);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(59, 25);
            this.txtMax.TabIndex = 13;
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(62, 248);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(58, 25);
            this.txtMin.TabIndex = 12;
            // 
            // radMiddleEastern
            // 
            this.radMiddleEastern.AutoSize = true;
            this.radMiddleEastern.Location = new System.Drawing.Point(6, 166);
            this.radMiddleEastern.Name = "radMiddleEastern";
            this.radMiddleEastern.Size = new System.Drawing.Size(139, 24);
            this.radMiddleEastern.TabIndex = 10;
            this.radMiddleEastern.TabStop = true;
            this.radMiddleEastern.Text = "Middle Eastern";
            this.radMiddleEastern.UseVisualStyleBackColor = true;
            this.radMiddleEastern.CheckedChanged += new System.EventHandler(this.radMiddleEastern_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // radMalay
            // 
            this.radMalay.AutoSize = true;
            this.radMalay.Location = new System.Drawing.Point(6, 106);
            this.radMalay.Name = "radMalay";
            this.radMalay.Size = new System.Drawing.Size(73, 24);
            this.radMalay.TabIndex = 9;
            this.radMalay.TabStop = true;
            this.radMalay.Text = "Malay";
            this.radMalay.UseVisualStyleBackColor = true;
            this.radMalay.CheckedChanged += new System.EventHandler(this.radMalay_CheckedChanged);
            // 
            // radIndian
            // 
            this.radIndian.AutoSize = true;
            this.radIndian.Location = new System.Drawing.Point(6, 136);
            this.radIndian.Name = "radIndian";
            this.radIndian.Size = new System.Drawing.Size(74, 24);
            this.radIndian.TabIndex = 11;
            this.radIndian.TabStop = true;
            this.radIndian.Text = "Indian";
            this.radIndian.UseVisualStyleBackColor = true;
            this.radIndian.CheckedChanged += new System.EventHandler(this.radIndian_CheckedChanged);
            // 
            // radChinese
            // 
            this.radChinese.AutoSize = true;
            this.radChinese.Location = new System.Drawing.Point(6, 76);
            this.radChinese.Name = "radChinese";
            this.radChinese.Size = new System.Drawing.Size(87, 24);
            this.radChinese.TabIndex = 8;
            this.radChinese.TabStop = true;
            this.radChinese.Text = "Chinese";
            this.radChinese.UseVisualStyleBackColor = true;
            this.radChinese.CheckedChanged += new System.EventHandler(this.radChinese_CheckedChanged);
            // 
            // radWestern
            // 
            this.radWestern.AutoSize = true;
            this.radWestern.Location = new System.Drawing.Point(6, 46);
            this.radWestern.Name = "radWestern";
            this.radWestern.Size = new System.Drawing.Size(91, 24);
            this.radWestern.TabIndex = 7;
            this.radWestern.TabStop = true;
            this.radWestern.Text = "Western";
            this.radWestern.UseVisualStyleBackColor = true;
            this.radWestern.CheckedChanged += new System.EventHandler(this.radWestern_CheckedChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
           
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDish;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radMiddleEastern;
        private System.Windows.Forms.RadioButton radMalay;
        private System.Windows.Forms.RadioButton radIndian;
        private System.Windows.Forms.RadioButton radChinese;
        private System.Windows.Forms.RadioButton radWestern;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.RadioButton radOthers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbDish;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblKcal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblProtien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label5;
    }
}

