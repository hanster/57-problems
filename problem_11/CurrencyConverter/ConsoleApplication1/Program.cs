using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            ExchangeRateApi exchange = new ExchangeRateApi();
            Converter converter = new Converter(exchange);
            Console.WriteLine("List of Currencies:");
            foreach (string currency in exchange.GetAllCurrencies())
            {
                Console.WriteLine(currency);            
            }
            Console.WriteLine("Enter From Currency :");
            string fromCurrency = Console.ReadLine();
            Console.WriteLine("Enter To Currency: ");
            string toCurrency = Console.ReadLine();
            Console.WriteLine("Enter Amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            var convertedAmount = converter.Convert(fromCurrency, toCurrency, amount);
            Console.WriteLine($"{amount} in {fromCurrency} converts to {convertedAmount} in {toCurrency}");
            Console.ReadLine();
        }
    }
}
