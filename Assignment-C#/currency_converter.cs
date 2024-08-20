using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_
{
    internal class currency_converter
    {
        private static int ConversionCount = 0;
        public string fromCurrency { get; set; } = "USD";
        public string toCurrency { get; set; } = "INR";
        public double exchangeRate { get; set; } = 83.785500;

        public currency_converter()
        {

        }
        public currency_converter(string fromCurrency, string toCurrency, double exchangeRate)
        {
            this.fromCurrency = fromCurrency;
            this.toCurrency = toCurrency;
            this.exchangeRate = exchangeRate;
        }

        static void ShowConversionCount()
        {
            Console.WriteLine(ConversionCount);
        }

        private static void IncrementConversionCount()
        {

            ConversionCount++;

        }

       public double ConvertAmount(double amount)
        {
            IncrementConversionCount();

            return exchangeRate * amount;

        }

       public double ConvertAmount(double amount, double customRate)
        {
            IncrementConversionCount();
            return customRate * amount;

        }



    }
    //internal class pro
    //{
    //    public static void Main()
    //    {
    //        currency_converter[] currency = new currency_converter[4];
    //        currency[0] = new currency_converter();
    //        currency[1] = new currency_converter("EUR", "USD", 1.11);
    //        currency[2] = new currency_converter();
    //        currency[3] = new currency_converter("EUR", "USD", 1.11);


    //        Console.WriteLine(currency[0].ConvertAmount(100));
    //        Console.WriteLine(currency[1].ConvertAmount(100));
    //        Console.WriteLine(currency[2].ConvertAmount(100, 78.68));
    //        Console.WriteLine(currency[3].ConvertAmount(100, 1.02));






    //    }
    //}


}
