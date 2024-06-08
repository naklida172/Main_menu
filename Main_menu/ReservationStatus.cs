using System;
using System.Collections;
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
    public partial class FormReservationStatus : Form
    {
        public FormReservationStatus()
        {
            InitializeComponent();
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            if (cboYourReservation.SelectedIndex != -1)
            {
                string selectedText = cboYourReservation.GetItemText(cboYourReservation.SelectedItem);

                int customerID = Order.CustomerID(HomePage.CustomerDetails.customerUsername);
                int ReservationTypeID = Reservation.ReservationTypeID(selectedText);
                Reservation status_Reservation = new Reservation(customerID, ReservationTypeID);
                lblReservationStatus.Text = status_Reservation.CustomerReservationStatus(HomePage.CustomerDetails.customerUsername, selectedText);

            }
            else
            {
                MessageBox.Show("You have not selected an option from the combobox.Please select!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormReservationStatus_Load(object sender, EventArgs e)
        {
            ArrayList reservationType = new ArrayList();
            reservationType = Reservation.CustomerReservationStat(HomePage.CustomerDetails.customerUsername);
            foreach (var item in reservationType)
            {
                cboYourReservation.Items.Add(item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblReservationStatus.Text =string.Empty;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
