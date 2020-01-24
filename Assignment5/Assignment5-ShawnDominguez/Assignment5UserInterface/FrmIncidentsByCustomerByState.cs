using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5UserInterface
{
    public partial class FrmIncidentsByCustomerByState : Form
    {
        DataClassesDataContext myContext = new DataClassesDataContext();
        public FrmIncidentsByCustomerByState()
        {
            InitializeComponent();
        }

        private void FrmIncidentsByCustomerByState_Load(object sender, EventArgs e)
        {
            var states = from state in myContext.States
                         orderby state.StateName ascending
                         select new { state.StateCode, state.StateName };
            cboStateName.DataSource = states;
            cboStateName.DisplayMember = "StateName";
            cboStateName.ValueMember = "StateCode";
            cboStateName.SelectedIndex = -1;
        }

        private void cboStateName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string stateCode = cboStateName.SelectedValue.ToString();
            var selectedState = (from aState in myContext.Customers
                                 where aState.State == stateCode && aState.Incidents.Count != 0
                                 select aState);
            customerBindingSource.Clear();
            customerBindingSource.DataSource = selectedState;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(customerDataGridView.SelectedRows.Count > 0)
            {
                int custID = int.Parse(customerDataGridView.SelectedCells[0].Value.ToString());
                var selectedCustomer = (from aCustomer in myContext.Incidents
                                        where aCustomer.CustomerID == custID
                                        select aCustomer);
                incidentBindingSource.Clear();
                incidentBindingSource.DataSource = selectedCustomer;
            }
        }
    }
}
