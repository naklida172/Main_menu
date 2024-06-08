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

namespace Main_menu
{
    public partial class Add_item : Form
    {
        public Add_item()
        {
            InitializeComponent();
        }

        private void Add_item_Load(object sender, EventArgs e)
        {
            if(Edit_items.Edit>0)
            {
                btnBack.Visible= false;
                txtbxName.Text =Menu_item.Get_item(Edit_items.Edit).Split(',')[0];
                txtbxPrice.Text = Menu_item.Get_item(Edit_items.Edit).Split(',')[1];
                txtbsDescription.Text = Menu_item.Get_item(Edit_items.Edit).Split(',')[2];
                txtbxCategory.Text = Menu_item.Get_item(Edit_items.Edit).Split(',')[3];
               // Console.WriteLine("THIS IS MENU ITEM");
                if (Food_item.IsFood(Edit_items.Edit))
                {
                    cbxIfFood.Checked = true;
                    txtbxCallories.Text = Food_item.Get_item(Edit_items.Edit).Split(',')[4];
                    txtbxIngredients.Text = Food_item.Get_item(Edit_items.Edit).Split(',')[5];
               //    Console.WriteLine("THIS IF ALSO A FOOD ITEM");
                }
                cbxIfFood.Enabled = false;
            }
        }
        public bool CheckAllFields()
        {
            if(txtbxName.Text != "" && txtbsDescription.Text!="" && txtbxCategory.Text!="" && txtbxPrice.Text!="" && float.Parse(txtbxPrice.Text)>0)
            {
                if(cbxIfFood.Enabled == true && cbxIfFood.Checked && txtbxCallories.Text=="" && txtbxIngredients.Text=="")
                {
                    Console.WriteLine("aaaaaaaaaaaa");
                    return false;
                }
                return true;
            }
            else
            {
                Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAA");
                return false;
            }
        }





        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Edit_items.Edit != 0)
            {
                if (CheckAllFields()==true)
                {
                    if (cbxIfFood.Checked)
                    {
                        Food_item.Update_item(Edit_items.Edit, txtbxName.Text, txtbxCategory.Text, txtbsDescription.Text, float.Parse(txtbxPrice.Text), int.Parse(txtbxCallories.Text), txtbxIngredients.Text);
                    }
                    else
                    {
                        Menu_item.Update_item(Edit_items.Edit, txtbxName.Text, txtbxCategory.Text, txtbsDescription.Text, float.Parse(txtbxPrice.Text));
                    }
                    Edit_items.Edit = 0;
                    Close();
                    
                }
                else
                {

                    lblTest.Text = CheckAllFields().ToString();
                }
            }
            else
            {
                if (CheckAllFields())
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("select Top 1 [ItemID] from [Menu_item] order by [ItemID] Desc;", conn);
                        int idcounter = Convert.ToInt32(cmd.ExecuteScalar());
                        idcounter += 1;
                        if (cbxIfFood.Checked)
                        {
                            Food_item.Register(idcounter, txtbxName.Text, txtbxCategory.Text, txtbsDescription.Text, float.Parse(txtbxPrice.Text), int.Parse(txtbxCallories.Text), txtbxIngredients.Text);
                        }
                        else
                        {
                            Menu_item.Register(idcounter, txtbxName.Text, txtbxCategory.Text, txtbsDescription.Text, float.Parse(txtbxPrice.Text));
                        }
                        lblTest.Text = "Done";
                    }
                }
                else
                {
                    lblTest.Text = "Error";
                }
            }
        }

        private void cbxIfFood_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIfFood.Checked)
            {
                lblCallories.ForeColor = Color.Black;
                lblIngredients.ForeColor = Color.Black;
                txtbxCallories.ForeColor = Color.Black;
                txtbxIngredients.ForeColor = Color.Black;
                txtbxCallories.BackColor = Color.White;
                txtbxIngredients.BackColor = Color.White;
                txtbxCallories.Enabled = true;
                txtbxIngredients.Enabled = true;
            }
            else
            {
                lblCallories.ForeColor = Color.Gray;
                lblIngredients.ForeColor = Color.Gray;
                txtbxCallories.ForeColor = Color.Gray;
                txtbxIngredients.ForeColor = Color.Gray;
                txtbxCallories.BackColor = Color.Gray;
                txtbxIngredients.BackColor = Color.Gray;
                txtbxCallories.Enabled = false;
                txtbxIngredients.Enabled = false;
                txtbxCallories.Text = string.Empty;
                txtbxIngredients.Text = string.Empty;
            }
        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
