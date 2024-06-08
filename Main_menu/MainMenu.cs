using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_menu
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }



        internal static User current_user = null;




        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from [User] where Username=@u and Password=@p", conn);
            cmd.Parameters.AddWithValue("@u",txtbxLogin.Text);
            cmd.Parameters.AddWithValue("@p",txtbxPassword.Text);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                SqlCommand cmd1 = new SqlCommand("Select role from [User] where [Username]=@u and [Password]=@p", conn);
                cmd1.Parameters.AddWithValue("@u", txtbxLogin.Text);
                cmd1.Parameters.AddWithValue("@p", txtbxPassword.Text);
                SqlCommand cmd2 = new SqlCommand("Select [UserID] from [User] where [Username]=@u and [Password]=@p", conn);
                cmd2.Parameters.AddWithValue("@u", txtbxLogin.Text);
                cmd2.Parameters.AddWithValue("@p", txtbxPassword.Text);
                string role = cmd1.ExecuteScalar().ToString();
                string id = cmd2.ExecuteScalar().ToString();
                if (role != "")//change "" to "manager"
                {
                    current_user=User.get_user(id);
                    this.Hide();
                    conn.Close();
                    Manager obj1 = new Manager();
                    obj1.ShowDialog();
                }
                else//put your role here
                {
                    //put your form here
                }
            }
            else
            {
                lblTest.Text = "Incorrect Password or Login";
            }
        }

            private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_registration obj1 = new Customer_registration();
            obj1.ShowDialog();
            this.Visible = true;
        }

        private void lblTest_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
