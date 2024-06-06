using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_menu.Chef
{
    public partial class frmChefMenu : Form
    {
        public frmChefMenu()
        {
            InitializeComponent();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            frmUpdate frm = new frmUpdate();
            frm.ShowDialog();
        }

        private void frmChefMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            frmViewOrders frm = new frmViewOrders();
            frm.ShowDialog();
        }

        private void btnManageInventory_Click(object sender, EventArgs e)
        {
            frmManageInventory frm = new frmManageInventory();
            frm.ShowDialog();
        }
    }
}
