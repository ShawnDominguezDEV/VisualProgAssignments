using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsProBLLClassLibrary;

namespace SportsProUserInterfaceLayer
{
    public partial class FrmOpenIncidentsByTechnician : Form
    {
        public FrmOpenIncidentsByTechnician()
        {
            InitializeComponent();
        }

        private void FrmOpenIncidentsByTechnician_Load(object sender, EventArgs e)
        {
            TechnicianBLL techBLL = new TechnicianBLL();

            cboTechnician.DataSource = techBLL.GetTechnicianNames();
            cboTechnician.DisplayMember = "Name";
            cboTechnician.ValueMember = "TechID";
            cboTechnician.SelectedIndex = -1;
        }

        private void cboTechnician_SelectionChangeCommitted(object sender, EventArgs e)
        {
            IncidentBLL incBLL = new IncidentBLL();
            TechnicianBLL techBLL = new TechnicianBLL();

            dgvOpenIncidentsByTechnician.DataSource = incBLL.GetOpenIncidentsByTechnican(int.Parse(cboTechnician.SelectedValue.ToString()));
            lblEmail.Text = techBLL.GetTechnicanDetails(int.Parse(cboTechnician.SelectedValue.ToString())).TechEmail;
            lblPhone.Text = techBLL.GetTechnicanDetails(int.Parse(cboTechnician.SelectedValue.ToString())).TechPhone;
        }

        private void btnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
}
