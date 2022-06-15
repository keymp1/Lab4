using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Phone
    {
        
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string ExchangeCode { get; set; }
        
        public string LineNumber { get; set; }

        public string FullNumber { get; set; }

        public Phone (string countryCode, string areaCode, string exchangeCode, string lineNumber, string fullNumber)
        {
            CountryCode = countryCode;
            AreaCode = areaCode;
            ExchangeCode = exchangeCode;
            LineNumber = lineNumber;
            FullNumber = fullNumber;
        }
    }
}
