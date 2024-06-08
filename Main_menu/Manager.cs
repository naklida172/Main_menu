using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Main_menu
{
    public partial class Manager : Form
    {
        public string current_mode = "Main";
        static public bool Delete_item = false;

        public void Management_mode()
        {
            btnBack.Text = "Go back";
            button1.Text = "Add";
            button2.Text = "Edit";
            button3.Text = "Delete";
            btnMngMItms.Visible = false;
            btnMngRsrvs.Visible = false;
            btnViewRsrvRprt.Visible = false;
            btnUpdtPrfl.Visible = false;
            pictureBox1.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }
        public void Reservation_view()
        {
            pictureBox1.Visible = false;
            lblSortBy.Visible = true;
            btnMngMItms.Visible = false;
            btnMngRsrvs.Text = "Month";
            btnViewRsrvRprt.Text = "Customer";
            btnUpdtPrfl.Text = "Type";
            current_mode = "View";
        }
        public void Profile_mode()
        {
            button1.Text = "Change name";
            button2.Text = "Change password";
            button3.Text = "Change email";
        }
        public Manager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnMngMItms_Click(object sender, EventArgs e)
        {
            if (current_mode == "Main")
            {
                Management_mode();
                current_mode = "Items";
            }
            else if (current_mode == "View")
            {

            }
        }

        private void btnMngRsrvs_Click(object sender, EventArgs e)
        {
            if (current_mode == "Main")
            {
                Management_mode();
                current_mode = "Reservations";
            }
            else if (current_mode == "View")
            {

            }
        }

        private void btnViewRsrvRprt_Click(object sender, EventArgs e)
        {
            if (current_mode == "Main")
            {
                Reservation_view();
            }
            else if (current_mode == "View")
            {

            }
        }

        private void btnUpdtPrfl_Click(object sender, EventArgs e)
        {
            if (current_mode == "Main")
            {
                Profile_settings obj1 = new Profile_settings();
                obj1.ShowDialog();
            }
            else if (current_mode == "View")
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add button
            if(current_mode == "Items")
            {
                Add_item obj1 = new Add_item();
                obj1.ShowDialog();
            }
            else if (current_mode == "Reservations")
            {
                Add_reservation obj1 = new Add_reservation();
                obj1.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (current_mode =="Main")
            {
                MainMenu.current_user = null;
                this.Hide();
                MainMenu obj1 = new MainMenu();
                obj1.ShowDialog();
              
            }
            else 
            {
                btnBack.Text = "Logout";
                btnMngMItms.Visible = true;
                btnMngRsrvs.Visible = true;
                btnViewRsrvRprt.Visible = true;
                btnUpdtPrfl.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                btnMngMItms.Text = "Manage menu items";
                btnMngRsrvs.Text = "Manage reservations";
                btnViewRsrvRprt.Text = "View reservation report";
                btnUpdtPrfl.Text = "Update profile";
                pictureBox1.Visible = true;
                lblSortBy.Visible = false;
                current_mode = "Main";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (current_mode == "Items")
            {
                Edit_items obj1 = new Edit_items();
                obj1.ShowDialog();
            }
            else if (current_mode == "Reservations")
            {
                Add_reservation obj1 = new Add_reservation();
                obj1.ShowDialog();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (current_mode == "Items")
            {
                Delete_item = true;
                Edit_items obj1 = new Edit_items();
                obj1.ShowDialog();
            }
            else if (current_mode == "Reservations")
            {
                Add_reservation obj1 = new Add_reservation();
                obj1.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
