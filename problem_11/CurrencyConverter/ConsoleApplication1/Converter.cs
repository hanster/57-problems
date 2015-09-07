using System;

namespace CurrencyConverter
{
    internal class Converter
    {
        private Exchange exchange;

        public Converter()
        {
        }

        public Converter(Exchange exchange)
        {
            this.exchange = exchange;
        }

        internal double Convert(string from, string to, int amount)
        {
            double converted = amount * exchange.GetRate(from, to);
            double valueRoundedUp = Math.Ceiling(converted * 100.0) / 100;
            return valueRoundedUp;
        }
    }
}