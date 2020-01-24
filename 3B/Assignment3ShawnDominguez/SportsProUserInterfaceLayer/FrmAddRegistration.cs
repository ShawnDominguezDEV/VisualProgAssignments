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
    public partial class FrmAddRegistration : Form
    {
        public FrmAddRegistration()
        {
            InitializeComponent();
        }

        private void FrmAddRegistration_Load(object sender, EventArgs e)
        {
            CustomerBLL custBLL = new CustomerBLL();
            ProductBLL prodBLL = new ProductBLL();

            //Name CBO
            cboName.DataSource = custBLL.RetrieveCustomerIDandName();
            cboName.DisplayMember = "Name";
            cboName.ValueMember = "CustomerID";
            cboName.SelectedIndex = -1;

            //ProductCBO
            cboProduct.DataSource = prodBLL.RetrieveProductNameAndCode();
            cboProduct.DisplayMember = "Name";
            cboProduct.ValueMember = "ProductCode";
            cboProduct.SelectedIndex = -1;
        }

        private void btnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Registration aRegistration = new Registration();
            RegistrationBLL regBLL = new RegistrationBLL();
            aRegistration.CustomerID = int.Parse(cboName.SelectedValue.ToString());
            aRegistration.ProductCode = cboProduct.SelectedValue.ToString();
            aRegistration.RegistrationDate = (DateTime)DateTime.Today;
            if(regBLL.AddNewRegistration(aRegistration) == true)
            {
                MessageBox.Show("The product was successfuly registered.", "Add Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The registration already exists.", "Add Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
