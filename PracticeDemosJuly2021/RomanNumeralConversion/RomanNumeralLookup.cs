using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemosJuly2021.RomanNumeralConversion
{
    public class RomanNumeralLookup
    {
        Dictionary<int, char> numeralLookup;
        public RomanNumeralLookup()
        {
            numeralLookup = new Dictionary<int, char>()
            {
                { 1,'I' },
                { 5,'V' },
                { 10,'X' },
                { 50,'L' },
                { 100,'C' },
                { 500,'D' },
                { 1000,'M' },
            };
        }

        public char GetRomanNumeral(int key)
        {
            return numeralLookup.GetValueOrDefault(key);
        }

        public int GetNumberKey(char val) {
            return numeralLookup.FirstOrDefault(item => item.Value == val).Key;
        }
    }
}
