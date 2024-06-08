using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment
{
    internal class Payment
    {
        private float paymentAmount;
        private int customerID;
        private string paymentStatus;

        public Payment(float paymentAmount, int customerID)
        {
            this.paymentAmount = paymentAmount;
            this.customerID = customerID;
            this.paymentStatus = "Payment Done!";

        }
        

        public string OrderPayment(float paymentAmount,int customerID) 
        {
            string status;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
        
            SqlCommand cmd1 = new SqlCommand("insert into Payment(paymentAmount,customerID,paymentStatus) values (@a,@b,@c)", con);
            cmd1.Parameters.AddWithValue("@a", paymentAmount);
            cmd1.Parameters.AddWithValue("@b", customerID);
            cmd1.Parameters.AddWithValue("@c", paymentStatus);
            SqlCommand cmd2 = new SqlCommand("update [Order] set orderStatus ='Proceed' where customerID = @a ",con);
            cmd2.Parameters.AddWithValue("@a", customerID);
            cmd1.ExecuteNonQuery();
            int i = cmd1.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Payment Done";
                cmd2.ExecuteNonQuery();
            }

            else

                status = "Error.Try Again";
            con.Close();
            return status;
        }

    }
}
