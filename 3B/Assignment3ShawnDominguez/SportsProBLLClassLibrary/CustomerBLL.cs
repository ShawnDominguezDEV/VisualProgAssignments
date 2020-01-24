using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SportsProDALClassLibrary;

namespace SportsProBLLClassLibrary
{
    public class CustomerBLL
    {
        public List<Customer> RetrieveCustomerIDandName()
        {
            CustomerDAL custDAL = new CustomerDAL();
            DataTable dtCustomers = new DataTable();
            List<Customer> lstCustomers = new List<Customer>();

            dtCustomers = custDAL.GetCustomerIDandName();
            foreach (DataRow dr in dtCustomers.Rows)
            {
                Customer aCustomer = new Customer();
                aCustomer.Name = dr["Name"].ToString();
                aCustomer.CustomerID = (int)dr["CustomerID"];
                lstCustomers.Add(aCustomer);
            }

            return lstCustomers;
        }

        public CustomerBLL()
        {

        }
    }
}
