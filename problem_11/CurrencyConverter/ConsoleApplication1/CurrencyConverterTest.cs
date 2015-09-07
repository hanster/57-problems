namespace CurrencyConverter
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    class CurrencyConverterTest
    {
        [Test]
        public void ConvertsAnAmount()
        {
            Exchange exchange = new ExchangeStub();
            var converter = new Converter(exchange);
            double amount = converter.Convert("GBP", "USD", 1);
            Assert.AreEqual(amount, 1.23);
        }
    }

    class ExchangeStub : Exchange
    {
        public double GetRate(string from, string to)
        {
            return 1.222;
        }
    }
}
