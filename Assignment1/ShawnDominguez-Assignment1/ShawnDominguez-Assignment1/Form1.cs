using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShawnDominguez_Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            decimal input, exchangeRate, output;
            string currencyChoice;
            CurrencyConverterClass myConversion = new CurrencyConverterClass();
            input = decimal.Parse(inputTextBox.Text);
            if(currencyListBox.SelectedIndex != -1)
            {
                currencyChoice = currencyListBox.SelectedItem.ToString();
            }

            myConversion.determineCurrency(currencyChoice);

            output = myConversion.performConversion(input, exchangeRate);


            //Make application more efficient and the class more detailed.
            //Code to detect listbox toggle

            outputLabel.Text = output.ToString();
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
            this.Close();
        }
    }
}
