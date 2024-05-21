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
        public void Hide_all_buttons()
        {
            btnMngMItms.Visible = false;
            btnMngRsrvs.Visible = false;
            btnViewRsrvRprt.Visible = false;
            btnUpdtPrfl.Visible = false;
            pictureBox1.Visible = false;
        }
        public void Unhide_all_buttons()
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
        }

        public void Management_mode()
        {
            button1.Text = "Add";
            button2.Text = "Edit";
            button3.Text = "Delete";
            Hide_all_buttons();
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }
        public void Reservation_view()
        {
            Hide_all_buttons();
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
        }

        private void btnMngRsrvs_Click(object sender, EventArgs e)
        {
            Management_mode();
        }

        private void btnViewRsrvRprt_Click(object sender, EventArgs e)
        {
            Hide_all_buttons();
        }

        private void btnUpdtPrfl_Click(object sender, EventArgs e)
        {
            Hide_all_buttons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Unhide_all_buttons();
        }
    }
}
