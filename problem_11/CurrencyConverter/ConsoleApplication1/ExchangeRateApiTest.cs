using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    using NUnit.Framework;

    [TestFixture]
    class ExchangeRateApiTest
    {
        private ExchangeRateApi exchange;
        private string json;

        [SetUp]
        public void SetUp()
        {
            exchange = new ExchangeRateApi();
            json = "{ 'base':'GBP','date':'2015-09-02','rates':{ 'USD':1.5273,'EUR':1.357}}";
        }

        [Test]
        public void ExtractTheListOfCurrencyFromJson()
        {
            List<string> expected = new List<string>();
            expected.Add("USD");
            expected.Add("EUR");

            List<string> currencies=  exchange.GetAvailableCurrencyList(json);

            Assert.AreEqual(expected, currencies);
        }

        [Test]
        public void ExtractTheRateFromJson()
        {
            double rate = exchange.GetRateFromJson(json, "USD");

            Assert.AreEqual(1.5273, rate);
        }
    
        [Test]
        public void GetAnExchangeRate()
        {
            double rate = exchange.GetRate("GBP", "EUR");
            Assert.AreEqual(1.5, rate);
        }

        [Test]
        public void GetListOfAllCurrencies()
        {
            List<string> currencies = exchange.GetAllCurrencies();

            Assert.Contains("GBP", currencies);
            Assert.Contains("USD", currencies);
        }

    }
}
