using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemosJuly2021.RomanNumeralConversion
{
    public class RomanNumeralConverter
    {
        private RomanNumeralLookup romanNumeralLookup;
        public RomanNumeralConverter()
        {
            romanNumeralLookup = new RomanNumeralLookup();
        }

        public string Numerals(int num)
        {
            string result = string.Empty;
            //max number range is 3999
            if (IsValidNumeralNumber(num))
            {
                //process numeral digits
            }
            else
            {
                result = "The number entered cannot be expressed as a roman numeral";
            }
            // 
            return result;
        }
        private bool IsValidNumeralNumber(int num)
        {
            return num > 0 && num < 4000; 
        }

    }

    internal class RomanNumeralLookup
    {
        Dictionary<int, string> numeralLookup;
        public RomanNumeralLookup()
        {
            numeralLookup = new Dictionary<int, string>()
            {
                { 1,"I" },
                { 5,"V" },
                { 10,"X" },
                { 50,"L" },
                { 100,"C" },
                { 500,"D" },
                { 1000,"M" },
            };
        }

        public string GetRomanNumeral(int key) {
            return numeralLookup.GetValueOrDefault(key);
        }
    }
}
