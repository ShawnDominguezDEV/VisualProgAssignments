using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class CustomerDAL
    {
        public DataTable GetCustomerIDandName()
        {
            SqlCommand cmdCustomerNames = new SqlCommand();
            cmdCustomerNames.CommandText = "SELECT NAME, CUSTOMERID FROM DBO.CUSTOMERS";
            cmdCustomerNames.CommandType = CommandType.Text;

            SqlConnection connA = new SqlConnection();
            connA = TechSupportDB.GetTechSupportConnection();
            connA.Open();
            cmdCustomerNames.Connection = connA;

            DataTable dtCustomerNames = new DataTable();
            dtCustomerNames.Load(cmdCustomerNames.ExecuteReader());
            return dtCustomerNames;
        }

        public CustomerDAL()
        {

        }
    }
}
