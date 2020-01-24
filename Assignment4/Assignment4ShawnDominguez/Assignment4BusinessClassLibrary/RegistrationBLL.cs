using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Assignment4DatabaseClassLibrary;

namespace Assignment4BusinessClassLibrary
{
    public class RegistrationBLL
    {
        public List<Registration> GetRegistrationInfo(string productCode)
        {
            List<Registration> lstRegByProduct = new List<Registration>();
            DataTable dtRegistration = new DataTable();
            RegistrationDAL regDAL = new RegistrationDAL();
            dtRegistration = regDAL.RetrieveRegistrations(productCode);

            foreach(DataRow dr in dtRegistration.Rows)
            {
                Registration aRegistration = new Registration();
                aRegistration.CustomerID = (int)dr["CustomerID"];
                aRegistration.Name = dr["Name"].ToString();         //Name is not in Registration table, need to verify
                aRegistration.CustomerEmail = dr["Email"].ToString();
                aRegistration.DateRegistered = (DateTime)dr["RegistrationDate"];
                lstRegByProduct.Add(aRegistration);
            }

            return lstRegByProduct;
        }

    }
}
