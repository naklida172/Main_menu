using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Assignment
{
    public partial class OrderStatus : Form
    {
        public OrderStatus()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OrderStatus_Load(object sender, EventArgs e)
        {
            ArrayList dishName = new ArrayList();
            dishName = Order.YourOrderStat(HomePage.CustomerDetails.customerUsername);
            foreach (var item in dishName) 
            {
                cboYourOrders.Items.Add(item);
            }
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            if (cboYourOrders.SelectedIndex != -1)
            {
                string selectedText = cboYourOrders.GetItemText(cboYourOrders.SelectedItem);
                
                int customerID = Order.CustomerID(HomePage.CustomerDetails.customerUsername);
                int menuID = Order.MenuID(selectedText);
                Order status_Order = new Order(customerID, menuID);
                lblOrderStatus.Text = status_Order.OrderStatus(HomePage.CustomerDetails.customerUsername, selectedText);

            }
            else
            {
                MessageBox.Show("You have not selected an option from the combobox.Please select!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOrderStatus.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
