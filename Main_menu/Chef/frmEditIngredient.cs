using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_menu.Chef
{
    public partial class frmEditIngredient : Form
    {
        public string ingredientID;
        public string ingredientName;
        public int quantity;
        public string unit;
        public string brand;
        public string supplier;
        public string itemID;
        public string createdTime;
        public string creator;
        public string changedtime;
        public string editor;

        public frmEditIngredient()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtIngredientID.Text))
            {
                MessageBox.Show("Please enter Ingredient ID");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIngredient.Text))
            {
                MessageBox.Show("Please enter Ingredient Name");
                return;
            }

            string conStr = ConfigurationManager.ConnectionStrings["MyCS"].ToString();

            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            SqlCommand cmd = new SqlCommand("update tblIngredient set ingredient =@ingredientName, quantity=@quantity, unit= @unit, brand = @brand, supplier=@supplier, changedTime=@changedTime, Editor=@Editor where ingredientID =@ingredientID and itemId =@itemId", con);

            string ingredientID = txtIngredientID.Text;
            cmd.Parameters.AddWithValue("@ingredientID", ingredientID);

            string ingredientName = txtIngredient.Text;
            cmd.Parameters.AddWithValue("@ingredientName", ingredientName);

            int quantity = int.Parse(txtQuantity.Text);
            cmd.Parameters.AddWithValue("@quantity", quantity);

            string unit = txtUnit.Text;
            cmd.Parameters.AddWithValue("@unit", unit);

            string brand = txtBrand.Text;
            cmd.Parameters.AddWithValue("@brand", brand);

            string supplier = txtSupplier.Text;
            cmd.Parameters.AddWithValue("@supplier", supplier);

            string itemID = txtItemID.Text;
            cmd.Parameters.AddWithValue("@itemID", itemID);

            string changedtime = DateTime.Now.ToString();
            cmd.Parameters.AddWithValue("@changedTime", changedtime);

            string editor = txtEditor.Text;
            cmd.Parameters.AddWithValue("@editor", editor);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
            {
                MessageBox.Show("Edit Success");

                this.Close();
            }
            else
            {
                MessageBox.Show("Edit failed");
            }
        }

        private void frmEditIngredient_Load(object sender, EventArgs e)
        {
            txtIngredientID.Text = ingredientID;
            txtIngredient.Text = ingredientName;
            txtQuantity.Text = quantity.ToString();
            txtUnit.Text = unit;
            txtBrand.Text = brand;
            txtSupplier.Text = supplier;
            txtItemID.Text = itemID;
            txtCreatedTime.Text = createdTime;
            txtCreator.Text = creator;  
            txtEditor.Text = GlobalItems.CurrentAccount;
        }


    }
}
