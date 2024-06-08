namespace C__Assignment
{
    partial class FormCart
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
            this.lsbCart = new System.Windows.Forms.ListBox();
            this.Cart = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cart.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbCart
            // 
            this.lsbCart.FormattingEnabled = true;
            this.lsbCart.ItemHeight = 19;
            this.lsbCart.Location = new System.Drawing.Point(6, 21);
            this.lsbCart.Name = "lsbCart";
            this.lsbCart.Size = new System.Drawing.Size(276, 251);
            this.lsbCart.TabIndex = 0;
            // 
            // Cart
            // 
            this.Cart.Controls.Add(this.btnCancel);
            this.Cart.Controls.Add(this.btnContinue);
            this.Cart.Controls.Add(this.lsbCart);
            this.Cart.Controls.Add(this.lblTotal);
            this.Cart.Controls.Add(this.label3);
            this.Cart.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cart.Location = new System.Drawing.Point(27, 12);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(293, 344);
            this.Cart.TabIndex = 1;
            this.Cart.TabStop = false;
            this.Cart.Text = "Cart";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(207, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(6, 311);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 9;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(58, 275);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(2, 21);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 361);
            this.Controls.Add(this.Cart);
            this.Name = "FormCart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.Cart.ResumeLayout(false);
            this.Cart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbCart;
        private System.Windows.Forms.GroupBox Cart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnContinue;
    }
}