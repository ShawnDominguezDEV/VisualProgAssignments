using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsProBLLClassLibrary;     //Provides reference to the business layer class

namespace SportsProUserInterfaceLayer
{
    public partial class FrmViewAllIncidents : Form
    {
        public FrmViewAllIncidents()
        {
            InitializeComponent();
        }

        private void btnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();    //Hides child form in the container.
        }

        private void FrmViewAllIncidents_Load(object sender, EventArgs e)
        {
            IncidentBLL incidentBLL = new IncidentBLL();

            dgvViewAllIncidents.DataSource = incidentBLL.GetAllIncidents();
        }
    }
}
