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
    public partial class FrmViewIncidentsByTechnician : Form
    {
        public FrmViewIncidentsByTechnician()
        {
            InitializeComponent();
        }

        private void btnGetIncidents_Click(object sender, EventArgs e)
        {
            IncidentBLL incBLL = new IncidentBLL();
            dgvIncidentsByTechnician.DataSource = incBLL.GetIncidentsByTechnician(int.Parse(txtTechnician.Text));
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
