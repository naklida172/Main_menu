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
    public partial class Edit_items : Form
    {
        public Edit_items()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstbxItems.DataSource = Food_item.Get_IdName();
        }

        private void lstbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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
        static public int Edit=0;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!Check_list()) 
            {
                lblSelect.Text = "No such id found";
            }
            else if(Manager.Delete_item == false)
            {
                this.Hide();
                Edit = int.Parse(txtbxID.Text);
                Add_item obj1 = new Add_item();
                obj1.ShowDialog();
                Close();
            }
            else
            {
                Edit = int.Parse(txtbxID.Text);
                Menu_item.Delete_item(Edit);
                Edit = 0;
                lstbxItems.DataSource = Food_item.Get_IdName();
            }

        }
    }
}
