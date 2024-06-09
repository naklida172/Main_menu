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
    public partial class frmManageInventory : Form
    {
        public frmManageInventory()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddIngredient frm = new frmAddIngredient();
            frm.ShowDialog();

            btnShowAll_Click(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["MyCS"].ToString();

            SqlConnection con = new SqlConnection(conStr);
            con.Open();


            SqlCommand cmd = new SqlCommand("select * from tblIngredient where itemID=@itemID", con);

            string itemID = txtItemID.Text;
            cmd.Parameters.AddWithValue("@itemID", itemID);


            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvInventory.DataSource = dt;

            con.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a inventory");
                return;
            }

            string ingredientId = dgvInventory.SelectedRows[0].Cells["ingredientId"].Value.ToString();
            string itemId = dgvInventory.SelectedRows[0].Cells["itemId"].Value.ToString();

            string conStr = ConfigurationManager.ConnectionStrings["MyCS"].ToString();

            SqlConnection con = new SqlConnection(conStr);
            con.Open();


            SqlCommand cmd = new SqlCommand("delete from tblIngredient where ingredientId=@ingredientId and itemId=@itemId", con);

            cmd.Parameters.AddWithValue("@ingredientId", ingredientId);
            cmd.Parameters.AddWithValue("@itemId", itemId);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
            {
                MessageBox.Show("delete Success");
            }
            else
            {
                MessageBox.Show("delete failed");
            }

            con.Close();

            ShowAll();
        }

        private void ShowAll()
        {
            string conStr = ConfigurationManager.ConnectionStrings["MyCS"].ToString();

            SqlConnection con = new SqlConnection(conStr);
            con.Open();


            SqlCommand cmd = new SqlCommand("select * from tblIngredient", con);

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvInventory.DataSource = dt;

            con.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count<=0)
            {
                MessageBox.Show("please select a row");
                return;
            }


            frmEditIngredient frm = new frmEditIngredient();
            frm.ingredientID = dgvInventory.SelectedRows[0].Cells["ingredientID"].Value.ToString();
            frm.ingredientName = dgvInventory.SelectedRows[0].Cells["ingredient"].Value.ToString();
            frm.quantity = int.Parse(dgvInventory.SelectedRows[0].Cells["quantity"].Value.ToString());
            frm.unit = dgvInventory.SelectedRows[0].Cells["unit"].Value.ToString();
            frm.brand = dgvInventory.SelectedRows[0].Cells["brand"].Value.ToString();
            frm.supplier = dgvInventory.SelectedRows[0].Cells["supplier"].Value.ToString();
            frm.itemID = dgvInventory.SelectedRows[0].Cells["itemID"].Value.ToString();
            frm.createdTime = dgvInventory.SelectedRows[0].Cells["createdTime"].Value.ToString();
            frm.creator = dgvInventory.SelectedRows[0].Cells["creator"].Value.ToString();
          
            frm.ShowDialog();


            btnShowAll_Click(null, null);    
        }


    }
}
