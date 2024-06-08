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
    public partial class AddReservation : Form
    {
        public AddReservation()
        {
            InitializeComponent();
        }

        private void txtDate_Enter(object sender, EventArgs e)
        {


        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (cboReservationType.SelectedIndex != -1)
            {
                string selectedText = cboReservationType.SelectedItem.ToString();
                int customerID = Order.CustomerID(HomePage.CustomerDetails.customerUsername);
                int reservationTypeID = Reservation.ReservationTypeID(selectedText);
                Reservation reserve = new Reservation(customerID, reservationTypeID);
                MessageBox.Show(reserve.AddReservaionByCustomer(customerID,reservationTypeID,txtDate.Text), "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("You have not selected an option from the combobox.Please select!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void AddReservation_Load(object sender, EventArgs e)
        {
            ArrayList reservationTypeName = new ArrayList();
            reservationTypeName = Reservation.ReservationTypeName();
            foreach (var item in reservationTypeName)
            {
                cboReservationType.Items.Add(item);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
