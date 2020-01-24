using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment1Library;

namespace RevisedAssignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //1.
            CurrencyConverterClass myConverter = new CurrencyConverterClass();

            //2.
            double inputUSAmount = double.Parse(inputTextBox.Text);
            if (currencyListBox.SelectedIndex != -1)
            {
                string selectCurrency = currencyListBox.SelectedItem.ToString();

                //3.
                myConverter.SetValues(inputUSAmount, selectCurrency);

                //4.
                myConverter.ConvertCurrency();

                //5.
                outputLabel.Text = myConverter.GetConvertedValue().ToString("n2");
            }
            else
            {
                MessageBox.Show("Please select a country/currency.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = "";
            outputLabel.Text = "";
            currencyListBox.SelectedIndex = -1;
            inputTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
