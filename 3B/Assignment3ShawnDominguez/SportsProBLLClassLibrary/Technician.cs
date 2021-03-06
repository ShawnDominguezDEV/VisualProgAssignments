﻿using System;
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
        private string techName;
        private string techEmail;
        private string techPhone;

        //Property Methods
        public int TechID
        {
            get { return techID; }
            set { techID = value; }
        }

        public string TechName
        {
            get { return techName; }
            set { techName = value; }
        }

        public string TechEmail
        {
            get { return techEmail; }
            set { techEmail = value; }
        }

        public string TechPhone
        {
            get { return techPhone; }
            set { techPhone = value; }
        }

        //Constructor methods for initial values.
        public Technician()
        {

        }
    }
}
