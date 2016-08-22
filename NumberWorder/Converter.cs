using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWorder
{
    public class Converter
    {
        private string[] singleDigits = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
                                          "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        private string[] deciles = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        public string Convert(int p)
        {
            if (p >= 20000) return deciles[p / 10000 - 2] + " " + (p % 10000 == 0 ? "Thousand" : Convert(p % 10000));
            if (p >= 1000) return singleDigits[p / 1000 - 1] + (p % 1000 == 0 ? " Thousand" : " Thousand ") + Convert(p % 1000);
            if (p >= 100) return singleDigits[p / 100 - 1] + (p % 100 == 0 ? " Hundred" : " Hundred and ") + Convert(p % 100);
            if (p >= 20) return deciles[p / 10 - 2] + (p % 10 == 0 ? "" : " ") + Convert(p % 10);
            if (p == 0) return "";

            return singleDigits[p-1];
        }
    }
}