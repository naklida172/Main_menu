using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_menu.ManagerSpecific
{
    public partial class Edit_reservation : Form
    {
        static public string Edit = "";
        public Edit_reservation()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Edit_reservation_Load(object sender, EventArgs e)
        {
            lstbxItems.DataSource= Reservation_manager.Get_IdName();
        }

        public bool Check_list()
        {
            for (int i = 0; i < lstbxItems.Items.Count; i++)
            {
                if (txtbxID.Text == lstbxItems.Items[i].ToString().Split(',')[0])
                {
                    return true;
                }
            }
            return false;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!Check_list())
            {
                lblSelect.Text = "No such id found";
            }
            else if (Manager.Delete_reservation == false)
            {
                this.Hide();
                Edit = txtbxID.Text;
                Add_reservation obj1 = new Add_reservation();
                obj1.ShowDialog();
                Close();
            }
            else
            {
            }
        }

        private void lstbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
