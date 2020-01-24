using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Assignment4DatabaseClassLibrary
{
    public class RegistrationDAL
    {
        public DataTable RetrieveRegistrations(string productCode)
        {
            SqlCommand cmdRegistrationByProduct = new SqlCommand();
            cmdRegistrationByProduct.CommandText = "spCustomerProductRegistrations";       //Stored Procedure
            cmdRegistrationByProduct.CommandType = CommandType.StoredProcedure;
            cmdRegistrationByProduct.Connection = TechSupportDB.GetTechSupportConnection();
            cmdRegistrationByProduct.Connection.Open();
            cmdRegistrationByProduct.Parameters.AddWithValue("@productCode", productCode);

            DataTable dtRegByProduct = new DataTable();
            dtRegByProduct.Load(cmdRegistrationByProduct.ExecuteReader());
            cmdRegistrationByProduct.Connection.Close();

            return dtRegByProduct;
        }
    }
}
