using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    interface Exchange
    {
        double GetRate(string from, string to);
    }
}
