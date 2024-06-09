using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Main_menu
{
    internal class Reservation_manager
    {
        private string reservationID;
        private string date;
        private string customerID;
        private string type;
        private string status;
        public Reservation_manager(string date, string customer_email, string customer_name, string type)
        {
            this.date = date;
            this.type = type;
        }
        public string Display()
        {
            return $"{customerID}, {date}, {type}";
        }
        static public void Register(string customerID, string type, string date, string status)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select count(*) from [ReservationType] where [reservationTypeName]=@n", conn);
                cmd.Parameters.AddWithValue("@n", type);
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                {
                    SqlCommand cmd1 = new SqlCommand("Insert into [ReservationType]([reservationTypeName]) Values (@n);", conn);
                    cmd1.Parameters.AddWithValue("@n", type);
                    cmd1.ExecuteNonQuery();
                }
                SqlCommand cmd2 = new SqlCommand("Select [reservationTypeID] from [ReservationType] where [reservationTypeName] = @n", conn);
                cmd2.Parameters.AddWithValue("@n", type);
                type = cmd2.ExecuteScalar().ToString();
                using (SqlCommand cmd1 = new SqlCommand("INSERT INTO [Reservation] ([customerID],[reservationTypeID],[date],[reservationStatus]) VALUES " +
                    "(@c,@t,@d,@s)", conn))
                {
                    cmd1.Parameters.AddWithValue("@c", customerID);
                    cmd1.Parameters.AddWithValue("@t", type);
                    cmd1.Parameters.AddWithValue("@d", date);
                    cmd1.Parameters.AddWithValue("@s", status);
                    cmd1.ExecuteNonQuery();
                }
                /*
                SqlCommand cmd3 = new SqlCommand("Select * from [Reservation]", conn);
                SqlDataReader read = cmd3.ExecuteReader();
                while (read.Read())
                {
                    Console.WriteLine(read.GetInt32(0));
                    Console.WriteLine(read.GetString(1));
                    Console.WriteLine(read.GetInt32(2));
                    Console.WriteLine(read.GetString(3));
                    Console.WriteLine(read.GetString(4));
                }
                */
            }
        }
        static public List<string> Get_IdName(string sort="")
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
            {
                List<string> Items_List = new List<string>();
                conn.Open();
                if (sort == "")
                {
                    string command = "Select [reservationId], [Realname], [date]  from [Reservation] Inner join [tblUser] on [Reservation].[customerID]=[tblUser].[ID]";
                    SqlCommand cmd = new SqlCommand(command, conn);
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        Items_List.Add(read.GetInt32(0).ToString() + "," + read.GetString(1) + "," + read.GetString(2));
                    }
                }
                else
                {
                    string singleRsrv= string.Empty;
                    string command = "Select *  from [Reservation]"+"Order by "+sort;
                    SqlCommand cmd = new SqlCommand(command, conn);
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        for(int i=0; i< read.FieldCount; i++)
                        {
                            singleRsrv+=read.GetValue(i).ToString();
                            if(i!= read.FieldCount - 1) {  singleRsrv+=", "; }
                        }
                        Items_List.Add(singleRsrv);
                    }
                }
                return Items_List;
            }
        }
        static public string Get_item(string id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select [customerID], [date], [ReservationTypeName], [reservationStatus]  from [Reservation] Inner join [ReservationType] on [Reservation].[reservationTypeID]=[ReservationType].[reservationTypeID] and [Reservation].[reservationID]=@i", conn);
                cmd.Parameters.AddWithValue("@i", id);
                SqlDataReader read = cmd.ExecuteReader();
                string reservation_info = "";
                while (read.Read())
                {
                    reservation_info += (read.GetString(0) + ",");
                    reservation_info += (read.GetString(1) + ",");
                    reservation_info += (read.GetString(2)) + ",";
                    reservation_info += (read.GetString(3)) + ",";
                }
                return reservation_info;
            }
        }
        static public void Update(string reservationID, string customerID, string type, string date, string status) 
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Update [Reservation] Set " +
                    "[customerID]=@c, [date]=@d, [reservationStatus]=@s where [reservationId]=@i", conn))
                {
                    cmd.Parameters.AddWithValue("@i", reservationID);
                    cmd.Parameters.AddWithValue("@c", customerID);
                    cmd.Parameters.AddWithValue("@d", date);
                    cmd.Parameters.AddWithValue("@s", status);
                    cmd.ExecuteNonQuery();
                }
                SqlCommand cmd1 = new SqlCommand("Select count(*) from [ReservationType] where [reservationTypeName]=@t", conn);
                cmd1.Parameters.AddWithValue("@t", type);
                if (Convert.ToInt32(cmd1.ExecuteScalar()) == 0)
                {
                    SqlCommand cmd2 = new SqlCommand("Insert into [ReservationType]([reservationTypeName]) Values (@n);", conn);
                    cmd1.Parameters.AddWithValue("@n", type);
                    cmd1.ExecuteNonQuery();
                }
                SqlCommand cmd3 = new SqlCommand("Select [reservationTypeID] from [ReservationType] where [reservationTypeName] = @n", conn);
                cmd3.Parameters.AddWithValue("@n", type);
                int typeID = Convert.ToInt32(cmd3.ExecuteScalar());
                Console.WriteLine(type);
                SqlCommand cmd4 = new SqlCommand("Update Reservation Set [reservationTypeID]=@t where [reservationId] = @i", conn);
                cmd4.Parameters.AddWithValue("@t", typeID);
                cmd4.Parameters.AddWithValue("@i", reservationID);
                cmd4.ExecuteNonQuery();
            }
        }

        static public void Delete_item(string id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ToString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM [Reservation] WHERE [reservationId]=@i", conn))
                {
                    cmd.Parameters.AddWithValue("@i", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
