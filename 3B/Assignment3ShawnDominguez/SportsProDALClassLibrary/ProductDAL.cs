using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class ProductDAL
    {
        public DataTable GetProductNameAndCode()
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
            return dtProductNames;
        }

        public ProductDAL()
        {

        }
    }
}
