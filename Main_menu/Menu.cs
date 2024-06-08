using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C__Assignment
{
    public partial class Menu : Form
    {
        public string selectedDish; 
        public Menu()
        {
            InitializeComponent();
        }
        string Cuisine;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radChinese_CheckedChanged(object sender, EventArgs e)
        {
            if (radChinese.Checked)
            {
                cboDish.Items.Clear();
                Cuisine = "Chinese";
                ArrayList dishName = new ArrayList();
                dishName = Order.viewMenu(Cuisine);
                foreach (var item in dishName)
                {
                    cboDish.Items.Add(item);
                }
            }
        }

        private void radMalay_CheckedChanged(object sender, EventArgs e)
        {
            if (radMalay.Checked)
            {
                cboDish.Items.Clear();
                Cuisine = "Malay";
                ArrayList dishName = new ArrayList();
                dishName = Order.viewMenu(Cuisine);
                foreach (var item in dishName)
                {
                    cboDish.Items.Add(item);
                }
            }
        }

        private void radIndian_CheckedChanged(object sender, EventArgs e)
        {
            if (radIndian.Checked)
            {
                cboDish.Items.Clear();
                Cuisine = "Indian";
                ArrayList dishName = new ArrayList();
                dishName = Order.viewMenu(Cuisine);
                foreach (var item in dishName)
                {
                    cboDish.Items.Add(item);
                }
            }
        }

        private void radMiddleEastern_CheckedChanged(object sender, EventArgs e)
        {
            if (radMiddleEastern.Checked)
            {
                cboDish.Items.Clear();
                Cuisine = "MiddleEastern";
                ArrayList dishName = new ArrayList();
                dishName = Order.viewMenu(Cuisine);
                foreach (var item in dishName)
                {
                    cboDish.Items.Add(item);
                }
            }
        }

        private void radOthers_CheckedChanged(object sender, EventArgs e)
        {
            if (radOthers.Checked)
            {
                cboDish.Items.Clear();
                Cuisine = "Others";
                ArrayList dishName = new ArrayList();
                dishName = Order.viewMenu(Cuisine);
                foreach (var item in dishName)
                {
                    cboDish.Items.Add(item);
                }
            }
        }

       
        
        private void radWestern_CheckedChanged(object sender, EventArgs e)
        {
            if (radWestern.Checked)
            {
                cboDish.Items.Clear();
                Cuisine = "Western";
                ArrayList dishName = new ArrayList();
                dishName = Order.viewMenu(Cuisine);
                foreach (var item in dishName)
                {
                    cboDish.Items.Add(item);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            radChinese.Checked = false;
            radIndian.Checked = false;
            radMalay.Checked = false;
            radMiddleEastern.Checked = false;
            radWestern.Checked = false;
            radOthers.Checked = false;
            txtMax.Clear();
            txtMin.Clear();
            lblCarbs.Text = string.Empty;
            lblFat.Text = string.Empty;
            lblKcal.Text = string.Empty;
            lblName.Text = string.Empty;
            lblPrice.Text = string.Empty;
            lblProtien.Text = string.Empty;
            pbDish.Image = null;
            cboDish.Items.Clear();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtMin.Text, out int min))
            { if(int.TryParse(txtMax.Text,out int max))
                {
                    cboDish.Items.Clear();
                    ArrayList dishName = new ArrayList();
                    dishName = Order.PriceFilter(Cuisine,min,max);
                    foreach (var item in dishName)
                    {
                        cboDish.Items.Add(item);
                    }

                }
                else { MessageBox.Show("Wrong input.Please use integers for Price","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(cboDish.SelectedIndex > -1)
            {
                string selectedDish = cboDish.SelectedItem.ToString();

                ArrayList dishDetails = new ArrayList();
                dishDetails = Order.DishDetails(selectedDish);
                if (dishDetails.Count >= 6)
                {
                    lblKcal.Text = dishDetails[0].ToString();
                    lblCarbs.Text = dishDetails[1].ToString();
                    lblFat.Text = dishDetails[2].ToString();
                    lblProtien.Text = dishDetails[3].ToString();
                    lblName.Text = dishDetails[4].ToString();
                    lblPrice.Text = $"MYR {dishDetails[5]}";
                }
                else { MessageBox.Show(""); }
               
            }
            else 
            {
                MessageBox.Show("Error.You have not selected a dish from the from Food.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string username = HomePage.CustomerDetails.customerUsername;
            MessageBox.Show(Order.CancelButtton(username), "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboDish.SelectedIndex != -1) 
            {
                string select_text = cboDish.SelectedItem.ToString();
                int customerID = Order.CustomerID(HomePage.CustomerDetails.customerUsername);
                int menuID = Order.MenuID(select_text);
                Order add_order = new Order(customerID, menuID);
                MessageBox.Show(add_order.AddOrder(customerID, menuID), "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Error.You have not selected a dish from the from Food.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            FormCart formCart = new FormCart();
            formCart.ShowDialog();
            this.Close();
        }
    }
}
