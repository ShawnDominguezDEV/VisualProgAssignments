using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class TechnicianDAL
    {
        public DataTable RetrieveTechnicianNames()
        {
            SqlCommand cmdTechnicianNames = new SqlCommand();
            cmdTechnicianNames.CommandText = "SELECT NAME, TECHID FROM DBO.TECHNICIANS";
            cmdTechnicianNames.CommandType = CommandType.Text;

            SqlConnection connA = new SqlConnection();
            connA = TechSupportDB.GetTechSupportConnection();
            connA.Open();
            cmdTechnicianNames.Connection = connA;

            DataTable dtTechnicianNames = new DataTable();
            dtTechnicianNames.Load(cmdTechnicianNames.ExecuteReader());
            return dtTechnicianNames;

        }

        public DataTable RetrieveTechnicianDetails(int techID)
        {
            SqlParameter techParam = new SqlParameter();
            techParam.ParameterName = "@specifiedTechID";
            techParam.Value = techID;
            techParam.Direction = ParameterDirection.Input;

            SqlCommand cmdTechnicianDetails = new SqlCommand();
            cmdTechnicianDetails.Parameters.Add(techParam);
            cmdTechnicianDetails.CommandText = "SELECT EMAIL, PHONE FROM DBO.TECHNICIANS WHERE TECHID = @specifiedTechID";
            cmdTechnicianDetails.CommandType = CommandType.Text;

            SqlConnection connA = new SqlConnection();
            connA = TechSupportDB.GetTechSupportConnection();
            connA.Open();
            cmdTechnicianDetails.Connection = connA;

            DataTable dtTechnicianDetails = new DataTable();
            dtTechnicianDetails.Load(cmdTechnicianDetails.ExecuteReader());
            return dtTechnicianDetails;
        }
        
        
    }
}
