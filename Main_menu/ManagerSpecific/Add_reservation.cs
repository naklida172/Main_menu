using Main_menu.ManagerSpecific;
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
    public partial class Add_reservation : Form
    {
        public Add_reservation()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstbxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_reservation_Load(object sender, EventArgs e)
        {
            lstbxUsers.DataSource = User.Get_IdName();
            if (Edit_reservation.Edit != "")
            {
                btnCancel.Visible = false;
                txtbxUsers .Text = Reservation_manager.Get_item(Edit_reservation.Edit).Split(',')[0];
                txtbxDate .Text = Reservation_manager.Get_item(Edit_reservation.Edit).Split(',')[1];
                txtbxType .Text = Reservation_manager.Get_item(Edit_reservation.Edit).Split(',')[2];
                txtbxStatus.Visible = true;
                txtbxStatus.Text = Reservation_manager.Get_item(Edit_reservation.Edit).Split(',')[3];
                // Console.WriteLine("THIS IS MENU ITEM");
            }
        }

        public bool CheckAllFields()
        {
            if (txtbxUsers.Text != "" && txtbxDate.Text != "" && txtbxType.Text != "")
            {
                if (txtbxStatus.Visible == true &&  txtbxStatus.Text == "")
                {
                    //Console.WriteLine("aaaaaaaaaaaa");
                    return false;
                }
                return true;
            }
            else
            {
                //Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAA");
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckAllFields())
            {
                if (Edit_reservation.Edit == "")
                {
                    Reservation_manager.Register(txtbxUsers.Text, txtbxType.Text, txtbxDate.Text, "appointed");
                    lblTest.Text = "Done";
                }
                else
                {
                    Reservation_manager.Update(Edit_reservation.Edit,txtbxUsers.Text, txtbxType.Text, txtbxDate.Text, txtbxStatus.Text);
                    Edit_reservation.Edit = "";
                    Close();
                }
            }
            else
            {
                lblTest.Text = "Error";
            }
        }
    }
}
