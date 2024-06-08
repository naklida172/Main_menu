using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C__Assignment
{
    internal class Reservation
    {
        private int customerID;
        private int reservationTypeID;

        public Reservation(int customerID, int reservationTypeID)
        {
            this.customerID = customerID;
            this.reservationTypeID = reservationTypeID;
        }
        public string CustomerReservationStatus(string username,string reservationTypeName)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select reservationStatus from Reservation where reservationTypeID in (select reservationTypeID from ReservationType where reservationTypeName =@a) and customerID in (select customerID from Customer where username = @b)", con);

            cmd1.Parameters.AddWithValue("@b", username);
            cmd1.Parameters.AddWithValue("@a", reservationTypeName);

            object reservationStatus = cmd1.ExecuteScalar();
            string reservationStatusString = (string)reservationStatus;
            con.Close();
            return reservationStatusString;
        }

        public string AddReservaionByCustomer(int customerID, int reservationTypeID,string date)
        {
            string status;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd1 = new SqlCommand("insert into Reservation(customerID,reservationTypeID,reservationStatus,date) values (@a,@b,@c,@d)", con);
            cmd1.Parameters.AddWithValue("@a", customerID);
            cmd1.Parameters.AddWithValue("@b", reservationTypeID);
            cmd1.Parameters.AddWithValue("@c", "Pending");
            cmd1.Parameters.AddWithValue("@d", date);
            int i = cmd1.ExecuteNonQuery();
            if (i != 0)

                status = "Reservation Request Placed.";

            else

                status = "Error.Try Again";
            con.Close();
            return status;

        }
        public static ArrayList ReservationTypeName()
        {
            ArrayList reservationTypeName = new ArrayList();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select reservationTypeName from ReservationType", con);


            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                reservationTypeName.Add(read.GetString(0));
            }
            con.Close();
            return reservationTypeName;
        }
        public static int ReservationTypeID(string reservationTypeName)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select ReservationTypeID from ReservationType where reservationTypeName =@a", con);

            cmd.Parameters.AddWithValue("@a", reservationTypeName);
            object reservationType_id = cmd.ExecuteScalar();
            int reservationType_ID = Convert.ToInt32(reservationType_id);
            return reservationType_ID;

        }
        public static ArrayList CustomerReservationStat(string username)
        {
            ArrayList reservationTypeName = new ArrayList();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select reservationTypeName from ReservationType where ReservationTypeID in (select ReservationTypeID from Reservation where customerID in (select CustomerID from Customer where username = @b))", con);

            cmd.Parameters.AddWithValue("@b", username);

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                reservationTypeName.Add(read.GetString(0));
            }
            con.Close();
            return reservationTypeName;

        }

    }
    
}
