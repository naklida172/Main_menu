using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment
{
    internal class Order
    {
        private int menuID;

        private int customerID;

        
    


        public Order(int customerID, int menuID)
        {
            
            this.menuID = menuID;
            this.customerID = customerID;
        }

        public string OrderStatus(string username, string dishName)
        {

            
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select orderStatus from [Order] where menuID in (select menuID from menu where dishName =@c) and customerID in (select customerID from Customer where username = @a)",con);
           
            cmd1.Parameters.AddWithValue("@a", username);
            cmd1.Parameters.AddWithValue("@c", dishName);

            object orderStatus = cmd1.ExecuteScalar();
            string orderStatusString = (string)orderStatus;
            con.Close();
            return orderStatusString;

        }
        public string EditOrder(string changes,string username,int orderID)
        {

            string status;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd1 = new SqlCommand("update [Order] set orderChanges = @a ,orderStatus='edited' where orderID =@c and customerID in (select customerID from Customer where username = @b)",con);
            cmd1.Parameters.AddWithValue("@a", changes);
            cmd1.Parameters.AddWithValue("@b", username);
            cmd1.Parameters.AddWithValue("@c", orderID);

            cmd1.ExecuteNonQuery();
                int i = cmd1.ExecuteNonQuery();
                if (i != 0)

                    status = "Order edited";

                else

                    status = "Error.Try Again";
            con.Close();
            return status;

        }
        public string DeleteOrder(int orderID)
        {

            string status;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd1 = new SqlCommand(" Delete from [Order] where orderStatus = 'proceed' or orderStatus = 'edited'  and orderID = @a",con);
            
            cmd1.Parameters.AddWithValue("@a", orderID);
            int i = cmd1.ExecuteNonQuery();
            if (i != 0)

                status = "Order deleted";

            else

                status = "Error.Try Again";
            con.Close();
            return status;

        }

        public string AddOrder(int customerID,int menuID)
        {
            string status;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ConnectionString);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("insert into [Order](customerID,menuID,orderStatus) values (@a,@b,@c)", con);
            cmd1.Parameters.AddWithValue("@a", customerID);
            cmd1.Parameters.AddWithValue("@b",  menuID);
            cmd1.Parameters.AddWithValue("@c", "Pending");
            cmd1.ExecuteNonQuery();
            int i = cmd1.ExecuteNonQuery();
            if (i != 0)

                status = "Order added to your cart";

            else

                status = "Error.Try Again";
            con.Close();
            return status;


        }

        public static ArrayList viewMenu(string cuisine)
        {

            ArrayList dishName = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select dishName from Menu where cuisineName =@c ", con);
            cmd.Parameters.AddWithValue("@c", cuisine);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                dishName.Add(read.GetString(0));

            }
            con.Close();
            return dishName;

        }
        public static ArrayList PriceFilter(string cuisine, int min, int max)
        {

            ArrayList dishName = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select dishName from Menu where cuisineName =@a and price between @b and @c ", con);
            cmd.Parameters.AddWithValue("@a", cuisine);
            cmd.Parameters.AddWithValue("@b", min);
            cmd.Parameters.AddWithValue("@c", max);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                dishName.Add(read.GetString(0));

            }
            con.Close();
            return dishName;

        }
        public static ArrayList DishDetails(string dishName)
        {

            ArrayList dishDetails = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT  MenuNutrition.kcal, MenuNutrition.carbs, MenuNutrition.fat, MenuNutrition.protien, Menu.dishName, Menu.Price FROM Menu JOIN MenuNutrition ON Menu.menuID = MenuNutrition.menuID WHERE Menu.dishName = @a", con);
            cmd.Parameters.AddWithValue("@a", dishName);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                dishDetails.Add(read["kcal"].ToString());
                dishDetails.Add(read["carbs"].ToString());
                dishDetails.Add(read["fat"].ToString());
                dishDetails.Add(read["protien"].ToString());
                dishDetails.Add(read["dishName"].ToString());
                dishDetails.Add(read["Price"].ToString());
                


            }
            con.Close();
            return dishDetails;

        }
        public static string CancelButtton(string username)
        {
            string stats;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from [Order] where orderStatus  = 'pending' and customerID = (select CustomerID from Customer where username = @a)", con);
            cmd.Parameters.AddWithValue("@a", username);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count != 0)
            {
                SqlCommand cmd1 = new SqlCommand("Delete from [Order] where orderstatus = 'pending' and customerID = (select CustomerID from Customer where username = @b) ", con);
                cmd1.Parameters.AddWithValue("@b", username);
                cmd1.ExecuteNonQuery();
                stats = "Return to Home Page.";
            }



            else
                stats = "Return to Home Page.";

            con.Close();
            return stats;

        }
        public static ArrayList ViewCart(string username)
        {
            ArrayList dishName = new ArrayList();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select dishName from Menu where menuID in (select menuID from [Order] where orderStatus = @a and customerID in (select CustomerID from Customer where username = @b))", con);
            cmd.Parameters.AddWithValue("@a", "pending");
            cmd.Parameters.AddWithValue("@b", username);

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                dishName.Add(read.GetString(0));
            }
            con.Close();
            return dishName;

        }

        public static float PriceTotal(string username) 
        {
            float total_Price;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select count(*) from Menu where menuID in (select menuID from [Order] where orderStatus = @a and customerID in (select CustomerID from Customer where username = @b))", con);
            cmd1.Parameters.AddWithValue("@a", "pending");
            cmd1.Parameters.AddWithValue("@b", username);
            int t = Convert.ToInt32(cmd1.ExecuteScalar());
            if (t != 0)
            {
                SqlCommand cmd2 = new SqlCommand("select Sum(Price) as total_price from Menu where menuID in (select menuID from [Order] where orderStatus = @a and customerID in (select CustomerID from Customer where username = @b))", con);
                cmd2.Parameters.AddWithValue("@a", "pending");
                cmd2.Parameters.AddWithValue("@b", username);
                total_Price = Convert.ToSingle(cmd2.ExecuteScalar());

            }
            else { total_Price = 0; }
            con.Close();
            return total_Price ;
        }
        public static float OrderDiscount(string coupon)
        {
            float discount;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select count(*) from Discount where discountCoupon= @a ", con);
            cmd1.Parameters.AddWithValue("@a",coupon);
            int i = Convert.ToInt32(cmd1.ExecuteScalar());
            if (i != 0)
            {
                SqlCommand cmd2 = new SqlCommand("select discountPercentage from Discount where discountCoupon= @b ", con);
                cmd1.Parameters.AddWithValue("@b", coupon);
                 discount = Convert.ToSingle(cmd1.ExecuteScalar());
            }
            else 
            { discount = 1.0f; }
          
                 
            
            
            con.Close();
            return discount ;
                }
        public static ArrayList YourOrders(string username)
        {
            ArrayList dishName = new ArrayList();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select dishName from Menu where menuID in (select menuID from [Order] where orderStatus = @a and customerID in (select CustomerID from Customer where username = @b))", con);
            cmd.Parameters.AddWithValue("@a", "proceed");
            cmd.Parameters.AddWithValue("@b", username);

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                dishName.Add(read.GetString(0));
            }
            con.Close();
            return dishName;

        }
        public static int CustomerID(string username) 
        {
            
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select customerID from Customer where username = @b",con);
            
            cmd.Parameters.AddWithValue("@b", username);

            object order_id = cmd.ExecuteScalar();
            int order_ID = Convert.ToInt32(order_id);
            con.Close();
            return order_ID;

        }
        public static int MenuID(string dishName)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select menuID from Menu where dishName =@a",con);

            cmd.Parameters.AddWithValue("@a", dishName);
            object order_id = cmd.ExecuteScalar();
            int order_ID = Convert.ToInt32(order_id);
            con.Close();
            return order_ID;

        }
        public static ArrayList YourOrderStat(string username)
        {
            ArrayList dishName = new ArrayList();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select dishName from Menu where menuID in (select menuID from [Order] where customerID in (select customerID from Customer where username = @b))", con);
            
            cmd.Parameters.AddWithValue("@b", username);

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                dishName.Add(read.GetString(0));
            }
            con.Close();
            return dishName;

        }


    }
}

