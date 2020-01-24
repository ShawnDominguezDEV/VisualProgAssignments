using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment4BusinessClassLibrary;

namespace Assignment4UserInterface
{
    public partial class FrmRegistrationsByProduct : Form
    {
        RegistrationBLL regBLL = new RegistrationBLL();
        DataTable dtRegistrationByProduct = new DataTable();
        ProductBLL prodBLL = new ProductBLL();

        public FrmRegistrationsByProduct()
        {
            InitializeComponent();
        }

        private void FrmRegistrationsByProduct_Load(object sender, EventArgs e)
        {

            //ProductCBO
            cboProduct.DataSource = prodBLL.GetProductNameAndCode();
            cboProduct.DisplayMember = "Name";
            cboProduct.ValueMember = "ProductCode";
            cboProduct.SelectedIndex = -1;
        }

        private void cboProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            registrationDataGridView.DataSource = regBLL.GetRegistrationInfo(cboProduct.SelectedValue.ToString());

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
