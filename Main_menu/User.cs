using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_menu
{
    internal class User
    {
            private string id;
            private string username;
            private string name;
            private string email;
            private string password;
            private string role;
            private string phone;
            private string address;
            public User(string id, string username, string email, string password, string role, string phone, string address, string name)
            {
                this.id = id;
                this.username = username;
                this.name = name;
                this.email = email;
                this.password = password;
                this.role = role;
                this.phone = phone;
                this.address = address;
            }
        static public User get_user(string id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
            {
                conn.Open();
                SqlCommand cmdN = new SqlCommand("Select [Name] from [User] where [UserID]=@i", conn);
                SqlCommand cmdU = new SqlCommand("Select [Username] from [User] where [UserID]=@i", conn);
                SqlCommand cmdP = new SqlCommand("Select [Password] from [User] where [UserID]=@i", conn);
                SqlCommand cmdR = new SqlCommand("Select [Role] from [User] where [UserID]=@i", conn);
                SqlCommand cmdE = new SqlCommand("Select [Email] from [User] where [UserID]=@i", conn);
                SqlCommand cmdT = new SqlCommand("Select [Phone] from [User] where [UserID]=@i", conn);
                SqlCommand cmdA = new SqlCommand("Select [Address] from [User] where [UserID]=@i", conn);
                cmdN.Parameters.AddWithValue("@i", id);
                cmdU.Parameters.AddWithValue("@i", id);
                cmdP.Parameters.AddWithValue("@i", id);
                cmdR.Parameters.AddWithValue("@i", id);
                cmdE.Parameters.AddWithValue("@i", id);
                cmdT.Parameters.AddWithValue("@i", id);
                cmdA.Parameters.AddWithValue("@i", id);
                string name = cmdN.ExecuteScalar().ToString();
                string username = cmdU.ExecuteScalar().ToString();
                string password = cmdP.ExecuteScalar().ToString();
                string role = cmdR.ExecuteScalar().ToString();
                string email = cmdE.ExecuteScalar().ToString();
                string phone = cmdT.ExecuteScalar().ToString();
                string address = cmdA.ExecuteScalar().ToString();
                User got_user = new User(id, name, username, password, role, email, phone, address);
                return got_user;
            }
        }
            static public void Register(string id, string name, string username, string password, string role, string email, string phone, string address)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO [User] VALUES " +
                        "(@i,@n,@u,@p,@r,@e,@q,@a)", conn))
                    {
                        cmd.Parameters.AddWithValue("@i", id);
                        cmd.Parameters.AddWithValue("@n", name);
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);
                        cmd.Parameters.AddWithValue("@r", role);
                        cmd.Parameters.AddWithValue("@e", email);
                        cmd.Parameters.AddWithValue("@q", phone);
                        cmd.Parameters.AddWithValue("@a", address);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            public string Change(string password, string new_value, string row_name)
            {
                if (this.password == password)
                {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE [User] SET "+ row_name+" = @n where [UserID]=@i", conn);
                        cmd.Parameters.AddWithValue("@n", new_value);
                        cmd.Parameters.AddWithValue("@i", this.id);
                        cmd.ExecuteNonQuery();
                    return "Success";
                    }
                }
                else
                    return "Error";
            }
    }
}
