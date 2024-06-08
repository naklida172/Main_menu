using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_menu
{
    internal class Reservation
    {
        private string date;
        private string customer_email;
        private string customer_name;
        private string type;
        public Reservation(string date, string customer_email, string customer_name, string type)
        {
            this.date = date;
            this.customer_email = customer_email;
            this.customer_name = customer_name;
            this.type = type;
        }
        public string Display()
        {
            return $"{date}, {customer_name}, {type}";
        }
    }
}
