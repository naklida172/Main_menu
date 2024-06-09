using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Main_menu.Chef
{
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            string id = MainMenu.current_user.Id;
            txtAccount.Text = id;


            string conStr = ConfigurationManager.ConnectionStrings["MyCS"].ToString();

            SqlConnection con = new SqlConnection(conStr);
            con.Open();


            SqlCommand cmd = new SqlCommand("select * from [tblUser] where [ID] =@i", con);
            cmd.Parameters.AddWithValue("@i", id);

            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();

            txtPassword.Text = rd.GetString(2);
            txtRealName.Text = rd.GetString(3); 
            txtAddress.Text = rd.GetString(4);
            txtPhoneNumber.Text = rd.GetString(5);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Account

            if (string.IsNullOrWhiteSpace(txtAccount.Text))
            {
                MessageBox.Show("Please Enter Your Account");
                return;
            }

            string account = txtAccount.Text.Trim();

            if (account.Length<3 || account.Length > 15 )
            {
                MessageBox.Show("Your account length should be in 3~15 characters");
                return;
            }

            //Password

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please Enter Your Password");
                return;
            }

            string password = txtPassword.Text.Trim();

            if (password.Length < 3 || password.Length > 10)
            {
                MessageBox.Show("Your password length should be in 3~10 characters");
                return;
            }

            //Real name

            if (string.IsNullOrWhiteSpace(txtRealName.Text))
            {
                MessageBox.Show("Please Enter Your Real Name");
                return;
            }

            string realname = txtRealName.Text.Trim();

           

            //Address
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please Enter Your Address");
                return;
            }

            string address = txtAddress.Text.Trim();

           

            //Phone Number
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please Enter Your Phone Number");
                return;
            }

            string phone = txtPhoneNumber.Text.Trim();

            if (phone.Length != 10)
            {
                MessageBox.Show("Your phone number should be at 10 digits");
                return;
            }

            //DATABASE CONNECT STRING
            //string conStr = "Data Source=LAPTOP-DGU69VME;Initial Catalog=RestaurantSystem;Persist Security Info=True;User ID=sa;Password=20183547";
            string conStr = ConfigurationManager.ConnectionStrings["MyCS"].ToString();

            SqlConnection con = new SqlConnection(conStr);
            con.Open();




            SqlCommand cmd = new SqlCommand("update tbluser set address =@email,phone=@phone,realname = @realName, password = @password where account =@account", con);

            cmd.Parameters.AddWithValue("@account", account);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@realname", realname);
            cmd.Parameters.AddWithValue("@email", address);
            cmd.Parameters.AddWithValue("@phone", phone);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Update Successfully.");
            }
            else
            {
                MessageBox.Show("Update Error.");
            }

            con.Close();
        }



    }
}
