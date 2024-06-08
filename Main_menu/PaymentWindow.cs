using System;
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
    public partial class PaymentWindow : Form
    {
        public PaymentWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaymentWindow_Load(object sender, EventArgs e)
        {
            lblDisplayATBP.Text = FormCart.TotalPrice.totalPrice.ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select customerID from Customer where username =@a",con);
            cmd.Parameters.AddWithValue("@a", HomePage.CustomerDetails.customerUsername);
            object amd = cmd.ExecuteScalar();
            int amds = (int)amd;
            con.Close();
            float amountPayment = FormCart.TotalPrice.totalPrice;
            Payment pay = new Payment(amountPayment, amds);
            MessageBox.Show(pay.OrderPayment(amountPayment, amds), "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
       
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string username = HomePage.CustomerDetails.customerUsername;
            MessageBox.Show(Order.CancelButtton(username), "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HomePage homePage = new HomePage();
            homePage.ShowDialog();

        }
    }
}
