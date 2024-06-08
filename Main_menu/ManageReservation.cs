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
    public partial class ManageReservation : Form
    {
        public ManageReservation()
        {
            InitializeComponent();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            AddReservation addReservation = new AddReservation();
            addReservation.ShowDialog();
            
        }

        private void btnReservationStatus_Click(object sender, EventArgs e)
        {
            FormReservationStatus frmStatus = new FormReservationStatus();
            frmStatus.ShowDialog();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
