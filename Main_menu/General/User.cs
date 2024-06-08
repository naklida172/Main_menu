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
            private string password;
            private string role;
            private string phone;
            private string address;
            public User(string id, string username, string password, string role, string phone, string address, string name)
            {
                this.id = id;
                this.username = username;
                this.name = name;
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
                SqlCommand cmdN = new SqlCommand("Select [Realname] from [tblUser] where [ID]=@i", conn);
                SqlCommand cmdU = new SqlCommand("Select [Account] from [tblUser] where [ID]=@i", conn);
                SqlCommand cmdP = new SqlCommand("Select [Password] from [tblUser] where [ID]=@i", conn);
                SqlCommand cmdR = new SqlCommand("Select [Role] from [tblUser] where [ID]=@i", conn);
                SqlCommand cmdT = new SqlCommand("Select [Phone] from [tblUser] where [ID]=@i", conn);
                SqlCommand cmdA = new SqlCommand("Select [Address] from [tblUser] where [ID]=@i", conn);
                cmdN.Parameters.AddWithValue("@i", id);
                cmdU.Parameters.AddWithValue("@i", id);
                cmdP.Parameters.AddWithValue("@i", id);
                cmdR.Parameters.AddWithValue("@i", id);
                cmdT.Parameters.AddWithValue("@i", id);
                cmdA.Parameters.AddWithValue("@i", id);
                string name = cmdN.ExecuteScalar().ToString();
                string username = cmdU.ExecuteScalar().ToString();
                string password = cmdP.ExecuteScalar().ToString();
                string role = cmdR.ExecuteScalar().ToString();
                string phone = cmdT.ExecuteScalar().ToString();
                string address = cmdA.ExecuteScalar().ToString();
                User got_user = new User(id, name, username, password, role, phone, address);
                return got_user;
            }
        }
        static public void Register(string id, string name, string username, string password, string role, string phone, string address)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [tblUser]([ID],[Realname],[Account],[Password],[Role],[Phone],[Address]) VALUES " +
                    "(@i,@n,@u,@p,@r,@q,@a)", conn))
                {
                    cmd.Parameters.AddWithValue("@i", id);
                    cmd.Parameters.AddWithValue("@n", name);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    cmd.Parameters.AddWithValue("@r", role);
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
                    SqlCommand cmd = new SqlCommand("UPDATE [tblUser] SET "+ row_name+" = @n where [ID]=@i", conn);
                    cmd.Parameters.AddWithValue("@n", new_value);
                    cmd.Parameters.AddWithValue("@i", this.id);
                    cmd.ExecuteNonQuery();
                return "Success";
                }
            }
            else
                return "Error";
        }
        static public List<string> Get_IdName()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
            {
                List<string> Items_List = new List<string>();
                conn.Open();
                string command = "Select count(ID) from [tblUser]";
                SqlCommand cmd = new SqlCommand(command, conn);
                int IdAmount = Convert.ToInt32(cmd.ExecuteScalar());
                for (int i = 1; i < IdAmount + 1; i++)
                {
                    command = ("select Max([ID]) from [tblUser] where [ID] in (Select top " + i.ToString() + " [ID] from [tblUser]);").ToString();
                    SqlCommand cmd1 = new SqlCommand(command, conn);
                    command = ("select [Account] from [tblUser] where [ID] = (select Max([ID]) from [tblUser] where [ID] in (Select top " + i.ToString() + " [ID] from [tblUser]))");
                    SqlCommand cmd2 = new SqlCommand(command, conn);
                    Items_List.Add(Convert.ToString(cmd1.ExecuteScalar()) + ", " + Convert.ToString(cmd2.ExecuteScalar()));
                }
                return Items_List;
            }
        }
    }
}
