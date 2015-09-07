using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    using Newtonsoft.Json.Linq;

    class ExchangeRateApi : Exchange
    {
        private static string BASE_API = "http://api.fixer.io/latest";

        public double GetRate(string from, string to)
        {
            var uri = BASE_API + $"?base={from}&symbols={to}";
            var responseJsonApi = GetResponseBody(uri);
            return GetRateFromJson(responseJsonApi, to);
        }

        private string GetResponseBody(string uri)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(uri).Result;
            response.EnsureSuccessStatusCode();
            var responseBody = response.Content.ReadAsStringAsync().Result;
            return responseBody;
        }

        internal List<string> GetAvailableCurrencyList(string json)
        {
            JObject obj = JObject.Parse(json);
            var rates = obj.SelectToken("rates");

            List<string> currencies = new List<string>();
        
            foreach (JProperty prop in rates)
            {
                currencies.Add(prop.Name);
            }
            return currencies;
        }

        internal double GetRateFromJson(string json, string to)
        {
            JObject obj = JObject.Parse(json);
            string rate = (string)obj["rates"][to];

            return Convert.ToDouble(rate);
        }

        internal List<string> GetAllCurrencies()
        {
            string responseJson = GetResponseBody(BASE_API);
            var currencies = GetAvailableCurrencyList(responseJson);
            return currencies;
        }
    }
}
