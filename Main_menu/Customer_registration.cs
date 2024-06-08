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
            if (txtbxName.Text!="" && txtbxEmail.Text != "" && txtbxPhone.Text != "" && txtbxUsername.Text != "")
            {

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select count(*) from [User] where Username=@u or [Email]=@e or [Phone]=@p", conn);
                    cmd.Parameters.AddWithValue("@u", txtbxUsername.Text);
                    cmd.Parameters.AddWithValue("@e", txtbxEmail.Text);
                    cmd.Parameters.AddWithValue("@p", txtbxPhone.Text);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        lblTest.Text = "Error, this user already exists";
                    }
                    else
                    {
                        SqlCommand cmd1 = new SqlCommand("select Top 1 [UserID] from [User] order by [UserID] Desc;", conn);
                        int idcounter = Convert.ToInt32(Convert.ToString(cmd1.ExecuteScalar()).Split('N')[1]);
                        idcounter += 1;
                        string idreturn;
                        if (idcounter >= 10)
                        {
                            idreturn = "UN" + $"{idcounter}";
                        }
                        else
                        {
                            idreturn = "UN" + $"0{idcounter}";
                        }
                        User.Register(idreturn, txtbxName.Text, txtbxUsername.Text, txtbxPassword.Text, "customer", txtbxEmail.Text, txtbxPhone.Text, txtbxAddress.Text);
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
    }
}
