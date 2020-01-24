using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Assignment4DatabaseClassLibrary
{
    public class ProductDAL
    {
        public DataTable RetrieveProductNameAndCode()
        {
            SqlCommand cmdProductNames = new SqlCommand();
            cmdProductNames.CommandText = "SELECT NAME, PRODUCTCODE FROM DBO.PRODUCTS";
            cmdProductNames.CommandType = CommandType.Text;

            SqlConnection connA = new SqlConnection();
            connA = TechSupportDB.GetTechSupportConnection();
            connA.Open();
            cmdProductNames.Connection = connA;

            DataTable dtProductNames = new DataTable();
            dtProductNames.Load(cmdProductNames.ExecuteReader());
            connA.Close();
            return dtProductNames;
        }

        public ProductDAL()
        {

        }
    }
}
