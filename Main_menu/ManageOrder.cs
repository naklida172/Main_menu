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
    public partial class ManageOrder : Form
    {
        public ManageOrder()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            EditOrder editOrder = new EditOrder();
            editOrder.ShowDialog();
            
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            DeleteOrder deleteOrder = new DeleteOrder();
            deleteOrder.ShowDialog();
            
        }

        private void btnOrderStatus_Click(object sender, EventArgs e)
        {
            OrderStatus status = new OrderStatus();
            status.ShowDialog();
            
        }
    }
}
