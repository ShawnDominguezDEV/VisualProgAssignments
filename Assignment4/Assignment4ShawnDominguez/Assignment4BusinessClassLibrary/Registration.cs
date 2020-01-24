using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4BusinessClassLibrary
{
    public class Registration
    {
        private int customerID;
        private string name;
        private string customerEmail;
        private DateTime dateRegistered;       

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string CustomerEmail
        {
            get { return customerEmail; }
            set { customerEmail = value; }
        }

        public DateTime DateRegistered      
        {
            get { return dateRegistered; }
            set { dateRegistered = value; }
        }

        public Registration()
        {

        }
    }
}
