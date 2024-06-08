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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }

        

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            if(radMenuFeedback.Checked) 
            {
                string selectedText = radMenuFeedback.Text;
                int customerID = Order.CustomerID(HomePage.CustomerDetails.customerUsername);
                Feedbacks feedback = new Feedbacks(customerID, selectedText);
                MessageBox.Show(feedback.Feedback(customerID, selectedText, txtFeedback.Text), "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else if ( radReservationFeedback.Checked ) 
            {
                string selectedText = radReservationFeedback.Text; 
                int customerID = Order.CustomerID(HomePage.CustomerDetails.customerUsername);
                Feedbacks feedback = new Feedbacks(customerID, selectedText);
                MessageBox.Show(feedback.Feedback(customerID, selectedText, txtFeedback.Text), "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("You have not selected a feedback type =.Please select!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
