using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsProUserInterfaceLayer
{
    public partial class FrmMain : Form
    {
        FrmViewAllIncidents aFormViewAllIncidents = new FrmViewAllIncidents();
        FrmViewIncidentsByTechnician aFormViewByTechnician = new FrmViewIncidentsByTechnician();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit the form and all its applications
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
            }
            this.Close();
            Application.Exit();
        }
        private void displayAllIncidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFormInMDI(aFormViewAllIncidents);
        }

        //Method for setting up the child forms; may need to edit (input from class demo)
        private void showFormInMDI(Form aForm)
        {
            //who is going to be the parent to this form? THIS FORM, "this" the form I'm on right now.
            aForm.MdiParent = this;
            //Specify anchor point adjust placement, TOP and LEFT used to put the form in the top left corner.
            aForm.Anchor = AnchorStyles.Top;
            aForm.Anchor = AnchorStyles.Left;
            //Fill the container using DockStyle FILL
            aForm.Dock = DockStyle.Fill;
            //Show the form
            aForm.Show();
        }

        private void displayIncidentsByTechnicianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFormInMDI(aFormViewByTechnician);
        }
    }
}
