using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsProDALClassLibrary;

namespace SportsProBLLClassLibrary
{
    public class RegistrationBLL
    {
        
        public bool AddNewRegistration(Registration aRegistration)
        {
            RegistrationDAL regDAL = new RegistrationDAL();
            return regDAL.RegisterProduct(aRegistration.ProductCode, aRegistration.CustomerID, aRegistration.RegistrationDate);
        }

        public RegistrationBLL()
        {

        }
        
    }
}
