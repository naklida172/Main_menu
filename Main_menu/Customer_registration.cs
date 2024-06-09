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
    public partial class Customer_registration : Form
    {
        public Customer_registration()
        {
            InitializeComponent();
        }

        private void Customer_registration_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtbxName.Text!="" && txtbxPassword.Text != "" && txtbxUsername.Text != "")
            {

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select count(*) from [tblUser] where Account=@u", conn);
                    cmd.Parameters.AddWithValue("@u", txtbxUsername.Text);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        lblTest.Text = "Error, this user already exists";
                    }
                    else
                    {
                        SqlCommand cmd1 = new SqlCommand("select Top 1 [ID] from [tblUser] order by [ID] Desc;", conn);
                        int idcounter;
                        if (cmd1.ExecuteScalar() != null)
                        {
                            idcounter = Convert.ToInt32(cmd1.ExecuteScalar().ToString()) + 1;
                        }
                        else
                        {
                            idcounter = 1;
                        }
                        string idreturn = idcounter.ToString();
                        User.Register(idreturn, txtbxName.Text, txtbxUsername.Text, txtbxPassword.Text, "customer", txtbxPhone.Text, txtbxEmail.Text);
                        lblTest.Text = "Registration Done";
                    }
                }
            }
            else
            {
                lblTest.Text = "Non-optional field is empty";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
