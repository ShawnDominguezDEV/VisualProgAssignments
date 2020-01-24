using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsProBLLClassLibrary
{
    public class Technician
    {
        //Private variables from Technician Table
        private int techID;
        private string name;
        private string email;
        private string phone;

        //Property Methods
        public int TechID
        {
            get { return techID; }
            set { techID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        //Constructor methods for initial values.
        public Technician()
        {

        }
    }
}
