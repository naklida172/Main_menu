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
    public partial class DeleteOrder : Form
    {
        public DeleteOrder()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void DeleteOrder_Load(object sender, EventArgs e)
        {
            ArrayList dishName = new ArrayList();
            dishName = Order.YourOrders(HomePage.CustomerDetails.customerUsername);
            foreach (var item in dishName)
            {
                clbYourOrder.Items.Add(item);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ArrayList yourOrder = new ArrayList();
            foreach (string item in clbYourOrder.CheckedItems)
            {
                yourOrder.Add(item.ToString());
            }
            foreach(string item in yourOrder) 
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("select orderID from [Order] where menuID in (select menuID from Menu where dishName =@a) and customerID in (select customerID from customer where username = @b)",con);
                cmd.Parameters.AddWithValue("@a", item);
                cmd.Parameters.AddWithValue("@b", HomePage.CustomerDetails.customerUsername);
                object order_id = cmd.ExecuteScalar();
                int order_ID = Convert.ToInt32(order_id);
                con.Close();
                int menuID = Order.MenuID(item);
                int customerID = Order.CustomerID(HomePage.CustomerDetails.customerUsername);
                Order yourOrd = new Order(customerID, menuID);
                MessageBox.Show(yourOrd.DeleteOrder(order_ID), "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < clbYourOrder.Items.Count; i++)
            {
                clbYourOrder.SetItemChecked(i, false);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
