using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class RegistrationDAL
    {
        
        private bool AddRegistration(int customerID, string productCode, DateTime regDate)
        {
            SqlCommand cmdAddReg = new SqlCommand();
            cmdAddReg.CommandText = "spAddRegistration";       //Stored Procedure
            cmdAddReg.CommandType = CommandType.StoredProcedure;
            cmdAddReg.Connection = TechSupportDB.GetTechSupportConnection();
            cmdAddReg.Connection.Open();
            cmdAddReg.Parameters.AddWithValue("@customerID", customerID);
            cmdAddReg.Parameters.AddWithValue("@productCode", productCode);
            cmdAddReg.Parameters.AddWithValue("@registrationDate", regDate);

            int numOfRecs = cmdAddReg.ExecuteNonQuery();
            cmdAddReg.Connection.Close();
            if (numOfRecs == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private bool CheckRegistration(int customerID, string productCode)
        {
            SqlCommand cmdCheckRegistration = new SqlCommand();
            cmdCheckRegistration.CommandText = "SELECT COUNT(*) FROM dbo.Registrations WHERE PRODUCTCODE = @ProductCode AND CUSTOMERID = @CustomerID";
            cmdCheckRegistration.CommandType = CommandType.Text;
            cmdCheckRegistration.Connection = TechSupportDB.GetTechSupportConnection();

            cmdCheckRegistration.Parameters.AddWithValue("@CustomerID", customerID);
            cmdCheckRegistration.Parameters.AddWithValue("@ProductCode", productCode);
            cmdCheckRegistration.Connection.Open();
            
            int countCheck = Convert.ToInt32(cmdCheckRegistration.ExecuteScalar());
            cmdCheckRegistration.Connection.Close();
            if (countCheck == 1)
            {
                return true;    //The registration already exists
            }
            else
            {
                return false;   //The registration does not exist
            }

            
        }

        public bool RegisterProduct(string prodCode, int custID, DateTime regDate)
        {
            if(CheckRegistration(custID, prodCode) == true)
            {
                return false;   //Already Exists
            }
            else
            {
                return AddRegistration(custID, prodCode, regDate);  //Successfully added
            }
        }

        public RegistrationDAL()
        {

        }
        
    }
}
