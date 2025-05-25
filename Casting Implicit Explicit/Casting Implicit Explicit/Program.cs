using Casting_Implicit_Explicit.Enums;
using Casting_Implicit_Explicit.Exceptions;
using Casting_Implicit_Explicit.Models;

namespace Casting_Implicit_Explicit
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Celsius c = new Celsius(123);
            //Kelvin k = c;
            //Console.WriteLine(k.Degree);
            #endregion

            #region task2
            //double azn = 2.0;
            //Currencyy valyuta = Currencyy.Usd;

            //double result = Exchange(valyuta, azn);
            //Console.WriteLine($"{azn} AZN -> {result} {valyuta}");
            #endregion

            #region task3
            try
            {
                Book book1 = new Book("Cinayet ve Ceza", 10.5, 3, "Dostoyevski", 688);

                book1.ShowInfo();

                book1.Sell();
                book1.Sell();
                book1.Sell();
                book1.ShowInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(": " + ex.Message);
            }
            #endregion
        }

        public static double Exchange(Enum currencyyEnum, double azn)
        {
            if (currencyyEnum is Currencyy currency)
            {
                switch (currency) 
                {
                    case Currencyy.Usd:
                        return azn * 0.59; 
                    case Currencyy.Eur:
                        return azn * 0.54; 
                    case Currencyy.Try:
                        return azn * 19.23; 
                    default:
                        throw new ArgumentException("valyuta desteklenmir.");
                }
            }
            else
            {
                throw new ArgumentException("Currencyy tipinde olmalidir.");
            }
        }
    }
}
