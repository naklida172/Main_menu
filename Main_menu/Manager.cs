using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_menu
{
    public partial class Manager : Form
    {
        string current_mode = "main";


        public void Management_mode()
        {
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
            lstbxReservation.Visible = true;
            button2.Text = "Month";
            button3.Text = "Customer";
            button4.Text = "Type";
            current_mode = "View";
        }
        public void Profile_mode()
        {
            button1.Text = "Change name";
            button1.Text = "Change password";
            button1.Text = "Change email";
        }
        class Menu_item
        {
            protected string name;
            protected string category;
            protected string description;
            protected int price;
        }

        class Food_item : Menu_item
        {
            private string callories;
            private string ingredients;
            public Food_item(string name, string category, string description, int price,string callories, string ingredients)
            {
                this.name = name;
                this.category = category;
                this.description = description;
                this.price = price;
                this.callories = callories;
                this.ingredients = ingredients;
            }
            public void Change_price(int price)
            { this.price = price; }
        }
        class Reservation
        {
            private string date;
            private string customer_email;
            private string customer_name;
            private string type;
            public Reservation(string date, string customer_email, string customer_name, string type)
            {
                this.date = date;
                this.customer_email = customer_email;
                this.customer_name = customer_name;
                this.type = type;
            }
            public string Display()
            {
                return $"{date}, {customer_name}, {type}";
            }
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
            Management_mode();
            current_mode = "Items";
        }

        private void btnMngRsrvs_Click(object sender, EventArgs e)
        {
            Management_mode();
            current_mode = "Reservations";
        }

        private void btnViewRsrvRprt_Click(object sender, EventArgs e)
        {
            Reservation_view();
        }

        private void btnUpdtPrfl_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (current_mode == "main")
            { }
            else if(current_mode == "Items")
            { }
            else if (current_mode == "Reservations")
            { }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (current_mode =="main")
            { }
            else 
            {
                btnMngMItms.Visible = true;
                btnMngRsrvs.Visible = true;
                btnViewRsrvRprt.Visible = true;
                btnUpdtPrfl.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                pictureBox1.Visible = true;
                lblSortBy.Visible = false;
                lstbxReservation.Visible = false;
                current_mode = "main";
            }
        }
    }
}
