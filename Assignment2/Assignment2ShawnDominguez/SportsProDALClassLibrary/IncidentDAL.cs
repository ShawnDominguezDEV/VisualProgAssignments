using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;        //Lines 6 and 7 are input using statements for sql functions.

namespace SportsProDALClassLibrary
{
    public class IncidentDAL
    {
        //Method to retrieve all the incident entries.
        public DataTable RetrieveAllIncidents()
        {
            SqlCommand cmdAllIncidents = new SqlCommand();
            cmdAllIncidents.CommandText = "SELECT INCIDENTID, CUSTOMERID, PRODUCTCODE, TECHID, DATEOPENED, DATECLOSED, TITLE, DESCRIPTION FROM DBO.INCIDENTS";

            cmdAllIncidents.CommandType = CommandType.Text;
            SqlConnection connA = new SqlConnection();
            connA = TechSupportDB.GetTechSupportConnection();
            connA.Open();
            cmdAllIncidents.Connection = connA;

            //Execution of the assigned SQL statement
            DataTable dtAllIncidents = new DataTable();
            dtAllIncidents.Load(cmdAllIncidents.ExecuteReader());
            return dtAllIncidents;
            
        }
        
        public DataTable RetrieveIncidentsByTechnician(int techID)
        {
            SqlParameter incidentParam = new SqlParameter();
            incidentParam.ParameterName = "@specifiedTechID";
            incidentParam.Value = techID;
            incidentParam.Direction = ParameterDirection.Input;

            SqlCommand cmdIncidentsByTechnicians = new SqlCommand();
            cmdIncidentsByTechnicians.Parameters.Add(incidentParam);
            cmdIncidentsByTechnicians.CommandText = "SELECT INCIDENTID, CUSTOMERID, PRODUCTCODE, TECHID, DATEOPENED, DATECLOSED, TITLE, DESCRIPTION FROM DBO.INCIDENTS WHERE TECHID = @specifiedTechID";

            cmdIncidentsByTechnicians.CommandType = CommandType.Text;
            SqlConnection connA = new SqlConnection();
            connA = TechSupportDB.GetTechSupportConnection();
            connA.Open();
            cmdIncidentsByTechnicians.Connection = connA;

            DataTable dtIncidentsByTechnician = new DataTable();
            dtIncidentsByTechnician.Load(cmdIncidentsByTechnicians.ExecuteReader());
            return dtIncidentsByTechnician;

        }
    }
}
