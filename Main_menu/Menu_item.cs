using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_menu
{
    internal class Menu_item
    {
        protected int id;
        protected string name;
        protected string category;
        protected string description;
        protected float price;
        static public void Register(int id, string name, string category, string description, float price)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [Menu_item] VALUES " +
                    "(@i,@n,@c,@d,@p,Null,Null)", conn))
                {
                    cmd.Parameters.AddWithValue("@i", id);
                    cmd.Parameters.AddWithValue("@n", name);
                    cmd.Parameters.AddWithValue("@c", category);
                    cmd.Parameters.AddWithValue("@d", description);
                    cmd.Parameters.AddWithValue("@p", price);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        static public string Get_item(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
            {
                conn.Open();
                SqlCommand cmdN = new SqlCommand("Select [Name] from [Menu_Item] where [ItemID]=@i", conn);
                SqlCommand cmdP = new SqlCommand("Select [Price] from [Menu_Item] where [ItemID]=@i", conn);
                SqlCommand cmdD = new SqlCommand("Select [Description] from [Menu_Item] where [ItemID]=@i", conn);
                SqlCommand cmdC = new SqlCommand("Select [Category] from [Menu_Item] where [ItemID]=@i", conn);
                cmdN.Parameters.AddWithValue("@i", id);
                cmdP.Parameters.AddWithValue("@i", id);
                cmdD.Parameters.AddWithValue("@i", id);
                cmdC.Parameters.AddWithValue("@i", id);
                string name = cmdN.ExecuteScalar().ToString();
                string price = cmdP.ExecuteScalar().ToString();
                string description = cmdD.ExecuteScalar().ToString();
                string category = cmdC.ExecuteScalar().ToString();
                return $"{name},{price},{description},{category}";
            }
        }
        
        static public void Update_item(int id, string name, string category, string description, float price) 
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Update [Menu_item] Set " +
                    "[Name]=@n,[Category]=@c,[Description]=@d,[Price]=@p where ItemID=@i", conn))
                {
                    cmd.Parameters.AddWithValue("@i", id);
                    cmd.Parameters.AddWithValue("@n", name);
                    cmd.Parameters.AddWithValue("@c", category);
                    cmd.Parameters.AddWithValue("@d", description);
                    cmd.Parameters.AddWithValue("@p", price);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        static public void Delete_item(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM [Menu_item] WHERE ItemID=@i", conn))
                {
                    cmd.Parameters.AddWithValue("@i", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
    internal class Food_item : Menu_item
    {
        private int callories;
        private string ingredients;
        public Food_item(int id, string name, string category, string description, float price, int callories, string ingredients)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.description = description;
            this.price = price;
            this.callories = callories;
            this.ingredients = ingredients;
        }
        static public void Register(int id, string name, string category, string description, float price, int callories, string ingridients)
        {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO [Menu_item] VALUES " +
                        "(@i,@n,@c,@d,@p,@l,@g)", conn))
                    {
                        cmd.Parameters.AddWithValue("@i", id);
                        cmd.Parameters.AddWithValue("@n", name);
                        cmd.Parameters.AddWithValue("@c", category);
                        cmd.Parameters.AddWithValue("@d", description);
                        cmd.Parameters.AddWithValue("@p", price);
                        cmd.Parameters.AddWithValue("@l", callories);
                        cmd.Parameters.AddWithValue("@g", ingridients);
                        cmd.ExecuteNonQuery();
                    }
                }
        }

        static public List<string> Get_IdName()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
            {
                List<string> Items_List = new List<string>();
                conn.Open();
                string command = "Select count(ItemID) from Menu_item";
                SqlCommand cmd = new SqlCommand(command, conn);
                int IdAmount = Convert.ToInt32(cmd.ExecuteScalar());
                for (int i = 1; i < IdAmount + 1; i++)
                {
                    command = ("select Max(ItemID) from Menu_item where ItemID in (Select top " + i.ToString() + " ItemID from Menu_item);").ToString();
                    SqlCommand cmd1 = new SqlCommand(command, conn);
                    command = ("select [Name] from Menu_item where ItemID = (select Max(ItemID) from Menu_item where ItemID in (Select top " + i.ToString() + " ItemID from Menu_item))");
                    SqlCommand cmd2 = new SqlCommand(command, conn);
                    Items_List.Add(Convert.ToString(cmd1.ExecuteScalar()) + ", " + Convert.ToString(cmd2.ExecuteScalar()));
                }
                return Items_List;
            }
        }
        static public void Update_item(int id, string name, string category, string description, float price, int callories, string ingridients)
        {
            Menu_item.Update_item(id, name, category, description, price);
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Update [Menu_item] Set " +
                    "[Callories]=@c,[Ingridients]=@g where ItemID=@i", conn))
                {
                    cmd.Parameters.AddWithValue("@i", id);
                    cmd.Parameters.AddWithValue("@c", callories);
                    cmd.Parameters.AddWithValue("@g", ingridients);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        static public bool IsFood(int id)
        {

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
            {
                List<string> Items_List = new List<string>();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Count(Ingridients) from Menu_item where ItemID = @i", conn);
                cmd.Parameters.AddWithValue("@i", id);
                if(Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                {
                    return false;
                }
                return true;
            }
        }
        static public string Get_item(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
            {
                conn.Open();   
                SqlCommand cmdL = new SqlCommand("Select [Callories] from [Menu_Item] where [ItemID]=@i", conn);
                SqlCommand cmdI = new SqlCommand("Select [Ingridients] from [Menu_Item] where [ItemID]=@i", conn);
                cmdL.Parameters.AddWithValue("@i", id);
                cmdI.Parameters.AddWithValue("@i", id);
                string callories = cmdL.ExecuteScalar().ToString();
                string ingredients = cmdI.ExecuteScalar().ToString();
                return Menu_item.Get_item(id)+$",{callories},{ingredients}";
            }
        }
    }
}

/*
SqlCommand cmdN = new SqlCommand("Select [Name] from Menu_item where [ItemID]=@i", conn);
SqlCommand cmdU = new SqlCommand("Select [Category] from Menu_item where [ItemID]=@i", conn);
SqlCommand cmdP = new SqlCommand("Select [Description] from Menu_item where [ItemID]=@i", conn);
SqlCommand cmdR = new SqlCommand("Select [Price] from Menu_item where [ItemID]=@i", conn);
SqlCommand cmdE = new SqlCommand("Select [Ingridients] from Menu_item where [ItemID]=@i", conn);
SqlCommand cmdT = new SqlCommand("Select [Callories] from Menu_item where [ItemID]=@i", conn);
cmdN.Parameters.AddWithValue("@i", idcounter);
cmdU.Parameters.AddWithValue("@i", idcounter);
cmdP.Parameters.AddWithValue("@i", idcounter);
cmdR.Parameters.AddWithValue("@i", idcounter);
cmdE.Parameters.AddWithValue("@i", idcounter);
cmdT.Parameters.AddWithValue("@i", idcounter);
string name = cmdN.ExecuteScalar().ToString() +
cmdU.ExecuteScalar().ToString() +
 cmdP.ExecuteScalar().ToString() +
 cmdR.ExecuteScalar().ToString() +
 cmdE.ExecuteScalar().ToString() +
 cmdT.ExecuteScalar().ToString();
lblTest.Text = name;
*/