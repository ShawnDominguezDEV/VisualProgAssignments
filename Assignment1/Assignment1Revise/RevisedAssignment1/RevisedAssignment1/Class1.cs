using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Library
{
    public class CurrencyConverterClass
    {
        
            //Private Instance properties - Variables
            double usAmount = 0.0, convertedValue = 0.0;
            string currencyToConvertTo = "";
            //Given constants for specific conversions
            const double AUDollar = 1.40760;
            const double CNY = 6.8421;
            const double Euro = 0.86483;
            const double JPY = 111.08276;
            const double BritishPound = 0.77385;

            //Set values to the input amount and the choice currency.
            public void SetValues(double usDollarAmount, string selectedCurrency)
            {
                usAmount = usDollarAmount;
                currencyToConvertTo = selectedCurrency;
            }

            //determines which constant to use based on setValues and then calc.
            public void ConvertCurrency()
            {
                switch (currencyToConvertTo)
                {
                    case "Australian Dollar":
                        convertedValue = usAmount * AUDollar;
                        break;
                    case "Chinese Yuan":
                        convertedValue = usAmount * CNY;
                        break;
                    case "Euro":
                        convertedValue = usAmount * Euro;
                        break;
                    case "Japanese Yen":
                        convertedValue = usAmount * JPY;
                        break;
                    case "UK Pound":
                        convertedValue = usAmount * BritishPound;
                        break;
                }
            }

            //Returns the currency conversion as a double
            public double GetConvertedValue()
            {
                return convertedValue;
            }
        
    }
}
