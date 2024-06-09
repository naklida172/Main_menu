using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_menu.Chef
{
    public partial class frmViewOrders : Form
    {
        public frmViewOrders()
        {
            InitializeComponent();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["MyCS"].ToString();

            SqlConnection con = new SqlConnection(conStr);
            con.Open();


            SqlCommand cmd = new SqlCommand("select * from tblOrder where orderId=@orderId or tableNo=@tableNo or customerName=@customerName or createdTime>=@createdTimeStart", con);

            string orderId = txtOrderId.Text;
            cmd.Parameters.AddWithValue("@orderId", orderId);

            string tableNo = txtTableNo.Text;
            cmd.Parameters.AddWithValue("@tableNo", tableNo);

            DateTime createdTimeStart = dtpCreatedTimeStart.Value;
            cmd.Parameters.AddWithValue("@createdTimeStart", createdTimeStart);

            string customerName = txtCustomerName.Text;
            cmd.Parameters.AddWithValue("@customerName", customerName);

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvOrders.DataSource = dt;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["MyCS"].ToString();

            SqlConnection con = new SqlConnection(conStr);
            con.Open();


            SqlCommand cmd = new SqlCommand("select * from tblOrder", con);

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvOrders.DataSource = dt;

            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrderId.Text = "";
            txtTableNo.Text = "";
            txtCustomerName.Text = "";
        }

        private void btnSearchUnFinished_Click(object sender, EventArgs e)
        {
            SearchUnFinished();
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count<=0)
            {
                MessageBox.Show("Please select a cuisine");
                return;
            }

            string orderId = dgvOrders.SelectedRows[0].Cells["orderId"].Value.ToString();
            string cuisineId = dgvOrders.SelectedRows[0].Cells["cuisineId"].Value.ToString();

            string cuisineStatus = dgvOrders.SelectedRows[0].Cells["cuisineStatus"].Value.ToString();

            if (cuisineStatus=="Waiting")
            {
                MessageBox.Show("Please Mark as In progress first");
                return;
            }

            string conStr = ConfigurationManager.ConnectionStrings["MyCS"].ToString();

            SqlConnection con = new SqlConnection(conStr);
            con.Open();


            SqlCommand cmd = new SqlCommand("update tblOrder set cuisineStatus ='Finished' where orderId =@orderId and cuisineId =@cuisineId", con);

            cmd.Parameters.AddWithValue("@orderId", orderId);
            cmd.Parameters.AddWithValue("@cuisineId", cuisineId);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Marked Cuisine as Completed Successfully.");
            }
            else
            {
                MessageBox.Show("Marked Cuisine as Completed Error.");
            }

            con.Close();

            SearchUnFinished();
        }


        void SearchUnFinished()
        {

            string conStr = ConfigurationManager.ConnectionStrings["MyCS"].ToString();

            SqlConnection con = new SqlConnection(conStr);
            con.Open();


            SqlCommand cmd = new SqlCommand("select * from tblOrder where cuisineStatus!='Finished' ", con);

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvOrders.DataSource = dt;
        }

        private void btnMarkedInProgress_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a cuisine");
                return;
            }

            string orderId = dgvOrders.SelectedRows[0].Cells["orderId"].Value.ToString();
            string cuisineId = dgvOrders.SelectedRows[0].Cells["cuisineId"].Value.ToString();

            string conStr = ConfigurationManager.ConnectionStrings["MyCS"].ToString();

            SqlConnection con = new SqlConnection(conStr);
            con.Open();


            SqlCommand cmd = new SqlCommand("update tblOrder set cuisineStatus ='InProgress' where orderId =@orderId and cuisineId =@cuisineId and cuisineStatus ='Waiting'", con);

            cmd.Parameters.AddWithValue("@orderId", orderId);
            cmd.Parameters.AddWithValue("@cuisineId", cuisineId);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Marked Cuisine as In Progress Successfully.");
            }
            else
            {
                MessageBox.Show("Marked Cuisine as In Progress Error.");
            }

            con.Close();

            SearchUnFinished();
        }
    }
}
