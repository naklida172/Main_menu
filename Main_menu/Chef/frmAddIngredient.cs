﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_menu.Chef
{
    public partial class frmAddIngredient : Form
    {
        public frmAddIngredient()
        {
            InitializeComponent();
        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIngredientID.Text))
            {
                MessageBox.Show("Please enter Ingredient ID");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIngredient.Text))
            {
                MessageBox.Show("Please enter Ingredient");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please enter Quantity");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show("Please enter Unit");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("Please enter Brand");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSupplier.Text))
            {
                MessageBox.Show("Please enter Supplier");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtItemID.Text))
            {
                MessageBox.Show("Please enter Cuisine Item ID");
                return;
            }


            string conStr = ConfigurationManager.ConnectionStrings["MyCS"].ToString();

            SqlConnection con = new SqlConnection(conStr);
            con.Open();


            SqlCommand cmd = new SqlCommand("INSERT INTO tblIngredient (ingredientID, ingredient, quantity, unit ,itemID,createdTime,brand,supplier,creator) VALUES (@ingredientID, @ingredientName, @ingredientQuantity, @ingredientUnit, @itemID, @createdTime, @brand, @supplier,@creator)", con);

            string ingredientID = txtIngredientID.Text;
            cmd.Parameters.AddWithValue("@ingredientID", ingredientID);

            string ingredientName = txtIngredient.Text;
            cmd.Parameters.AddWithValue("@ingredientName", ingredientName);

            int ingredientQuantity = int.Parse(txtQuantity.Text);
            cmd.Parameters.AddWithValue("@ingredientQuantity", ingredientQuantity);

            string ingredientUnit = txtUnit.Text;
            cmd.Parameters.AddWithValue("@ingredientUnit", ingredientUnit);

            DateTime createdTime = DateTime.Now;
            cmd.Parameters.AddWithValue("@createdTime", createdTime);

            string brand = txtBrand.Text;
            cmd.Parameters.AddWithValue("@brand", brand);

            string supplier = txtSupplier.Text;
            cmd.Parameters.AddWithValue("@supplier", supplier);

            string itemID = txtItemID.Text;
            cmd.Parameters.AddWithValue("@itemID", itemID);

            string creator = txtCreator.Text;
            cmd.Parameters.AddWithValue("@creator", creator);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
            {
                MessageBox.Show("Adding Success");

                this.Close();
            }
            else
            {
                MessageBox.Show("Adding failed");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddIngredient_Load(object sender, EventArgs e)
        {
            txtCreator.Text = GlobalItems.CurrentAccount;
        }

    }
}
