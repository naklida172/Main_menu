using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment
{
    internal class Feedbacks
    {
        private int customerID;
        private string feedbackType;
        public Feedbacks(int customerID, string feedbackType)
        {
            this.customerID = customerID;
            this.feedbackType = feedbackType;
        }
        public string Feedback(int customerID,string feedbackType,string feedback)
        {
            string status;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment"].ToString());
            con.Open();
            SqlCommand cmd1 = new SqlCommand("insert into Feedback(customerID,feedbackType,feedback) values (@a,@b,@c)",con);
            cmd1.Parameters.AddWithValue("@a", customerID);
            cmd1.Parameters.AddWithValue("@b", feedbackType);
            cmd1.Parameters.AddWithValue("@c", feedback);
            
            cmd1.ExecuteNonQuery();
            int i = cmd1.ExecuteNonQuery();
            if (i != 0)

                status = "Feedback sent .";

            else

                status = "Error.Try Again";
            con.Close();
            return status;
        }
    }
    
}
