using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShawnDominguez_Assignment1
{
    class CurrencyConverterClass
    {
        private decimal input, convRate, output;
        
        //Constructor
        public CurrencyConverterClass()
        {
            input = 0;
            convRate = 0;
            output = 0;
        }

        //Getter and setters for the variables. (input, list choice, output)
        public decimal InputValue
        {
            get { return input; }
            set { input = value; }
        }

        public decimal ConversionRate
        {
            get { return convRate; }
            set { convRate = value; }
        }

        public decimal ConvOutput
        {
            get { return output; }
        }

        public decimal determineCurrency(string currencyChoice)
        {
            decimal exchangeRate;
            switch (currencyChoice)
            {
                case "Australian Dollar":
                    exchangeRate = 1.40760m;
                    break;
                case "Chinese Yuan":
                    exchangeRate = 6.8421m;
                    break;
                case "Euro":
                    exchangeRate = 0.86483m;
                    break;
                case "JapaneseYen":
                    exchangeRate = 111.08276m;
                    break;
                case "UK Pound":
                    exchangeRate = 0.77385m;
                    break;

                    return exchangeRate;
            }
        }

        //Other methods
        public decimal performConversion(decimal inValue, decimal convRate)
        {
            decimal result;

            result = inValue * convRate;
            return result;
        }

    }
}
