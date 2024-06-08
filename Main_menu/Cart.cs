using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static C__Assignment.FormCart;

namespace C__Assignment
{
    public partial class FormCart : Form
    {
        public static class TotalPrice
        {
            public static float totalPrice { get; set; }
            
        }
        public string username=HomePage.CustomerDetails.customerUsername;
        public string Password = HomePage.CustomerDetails.customerPassword;
        public FormCart()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            float totalprice = Order.PriceTotal(username);
            lblTotal.Text = $"MYR {totalprice}";
            TotalPrice.totalPrice = totalprice;


            ArrayList dishName = new ArrayList();
            dishName = Order.ViewCart(username);
            foreach (var item in dishName)
            {
                lsbCart.Items.Add(item);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCoupon_Click(object sender, EventArgs e)
        {

        }

        private void txtCoupon_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (lsbCart.Items.Count > 0)
            {
                PaymentWindow paymentWindow = new PaymentWindow();
                paymentWindow.ShowDialog();
                this.Close();
                
            }
            else
            {
                
                this.Close(); 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string username = HomePage.CustomerDetails.customerUsername;
            MessageBox.Show(Order.CancelButtton(username), "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
