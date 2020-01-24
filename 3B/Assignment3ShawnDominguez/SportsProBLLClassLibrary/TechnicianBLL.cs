using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SportsProDALClassLibrary;

namespace SportsProBLLClassLibrary
{
    public class TechnicianBLL
    {
        
        public Technician GetTechnicanDetails(int techID)
        {
            TechnicianDAL techDAL = new TechnicianDAL();
            DataTable dtTechDetails = new DataTable();
            dtTechDetails = techDAL.RetrieveTechnicianDetails(techID);
            Technician aTechnician = new Technician();

            foreach (DataRow dr in dtTechDetails.Rows)
            {
                aTechnician.TechEmail = dr["Email"].ToString();
                aTechnician.TechPhone = dr["Phone"].ToString();
            }

            return aTechnician;
        }
        
        public DataTable GetTechnicianNames()
        {
            TechnicianDAL techDAL = new TechnicianDAL();
            return techDAL.RetrieveTechnicianNames();
        }

    }
}
