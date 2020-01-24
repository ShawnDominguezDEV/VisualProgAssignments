using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SportsProDALClassLibrary;     //Reference to the Data Access Layer

namespace SportsProBLLClassLibrary
{
    public class IncidentBLL
    {

        public List<Incident> GetAllIncidents()
        {
            List<Incident> lstIncidents = new List<Incident>();
            DataTable dtAllIncidents = new DataTable();
            IncidentDAL incidentDAL = new IncidentDAL();
            dtAllIncidents = incidentDAL.RetrieveAllIncidents();

            foreach(DataRow dr in dtAllIncidents.Rows)
            {
                Incident incidentA = new Incident();
                incidentA.IncidentID = (int)dr["IncidentID"];
                incidentA.CustomerID = (int)dr["CustomerID"];
                incidentA.ProductCode = dr["ProductCode"].ToString();

                //Need to account for if the TechID value returns a null value.
                if (dr["TechID"] == DBNull.Value)
                {
                    incidentA.TechID = null;
                }
                else
                {
                    incidentA.TechID = (int?)dr["TechID"];
                }

                incidentA.DateOpened = (DateTime)dr["DateOpened"];

                if (dr["DateClosed"] == DBNull.Value)
                {
                    incidentA.DateClosed = null;
                }
                else
                {
                    incidentA.DateClosed = (DateTime?)dr["DateClosed"];
                }

                incidentA.Title = dr["Title"].ToString();
                incidentA.Description = dr["Description"].ToString();
                lstIncidents.Add(incidentA);
            }
            return lstIncidents;
        }

        public List<Incident> GetIncidentsByTechnician(int techID)
        {
            List<Incident> lstIncidentsByTech = new List<Incident>();
            DataTable dtIncidentsByTech = new DataTable();
            IncidentDAL incidentDAL = new IncidentDAL();
            dtIncidentsByTech = incidentDAL.RetrieveIncidentsByTechnician(techID);

            foreach (DataRow dr in dtIncidentsByTech.Rows)
            {
                Incident incidentA = new Incident();
                incidentA.IncidentID = (int)dr["IncidentID"];
                incidentA.CustomerID = (int)dr["CustomerID"];
                incidentA.ProductCode = dr["ProductCode"].ToString();

                //Need to account for if the TechID value returns a null value.
                if (dr["TechID"] == DBNull.Value)
                {
                    incidentA.TechID = null;
                }
                else
                {
                    incidentA.TechID = (int?)dr["TechID"];
                }

                incidentA.DateOpened = (DateTime)dr["DateOpened"];

                if (dr["DateClosed"] == DBNull.Value)
                {
                    incidentA.DateClosed = null;
                }
                else
                {
                    incidentA.DateClosed = (DateTime?)dr["DateClosed"];
                }

                incidentA.Title = dr["Title"].ToString();
                incidentA.Description = dr["Description"].ToString();
                lstIncidentsByTech.Add(incidentA);
            }
            return lstIncidentsByTech;
        }
    }
}
