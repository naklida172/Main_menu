using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Assignment
{
    public partial class HomePage : Form
    {
        public static class CustomerDetails
        {
            public static string customerUsername { get; set; }
            public static string customerPassword { get; set; }
            public static string customerRole { get; set; }
        }
        public HomePage()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        

        private void HomePage_Load(object sender, EventArgs e)
        {
            CustomerDetails.customerUsername = "mike";
            CustomerDetails.customerRole = "Customer";
            CustomerDetails.customerPassword = "1234";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {
            ManageOrder mo = new ManageOrder();
            mo.ShowDialog();
        }

        private void btnManageReservation_Click(object sender, EventArgs e)
        {
            ManageReservation manageReservarion = new ManageReservation();
            manageReservarion.ShowDialog();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback();
            feedback.ShowDialog();
        }
    }
}
