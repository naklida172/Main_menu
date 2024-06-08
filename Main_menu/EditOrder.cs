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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C__Assignment
{
    public partial class EditOrder : Form
    {
        public EditOrder()
        {
            InitializeComponent();
        }

        private void EditOrder_Load(object sender, EventArgs e)
        {
            ArrayList dishName = new ArrayList();
            dishName = Order.YourOrders(HomePage.CustomerDetails.customerUsername);
            foreach (var item in dishName)
            {
                cboYourOrders.Items.Add(item);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cboYourOrders.SelectedIndex != -1)
            {
                string selectedText = cboYourOrders.GetItemText(cboYourOrders.SelectedItem);
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand("select orderID from [Order] where menuID in (select menuID from Menu where dishName =@a) and customerID in (select customerID from customer where username = @b)",con);
                cmd.Parameters.AddWithValue("@a", selectedText);
                cmd.Parameters.AddWithValue("@b", HomePage.CustomerDetails.customerUsername);
               object order_id = cmd.ExecuteScalar();
                int order_ID = (int)order_id;
                con.Close();
                int customerID = Order.CustomerID(HomePage.CustomerDetails.customerUsername);
                int menuID = Order.MenuID(selectedText);
                Order edit_Order = new Order(customerID, menuID);
                MessageBox.Show(edit_Order.EditOrder(rtbChanges.Text, HomePage.CustomerDetails.customerUsername, order_ID), "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("You have not selected an option from the combobox.Please select!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbChanges.Clear();
        }
    }
    
}
