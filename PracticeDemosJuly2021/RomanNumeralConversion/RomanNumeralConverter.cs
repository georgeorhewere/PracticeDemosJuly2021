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
                string numSequence = num.ToString();
                int numLength = numSequence.Length;
                foreach(var n in numSequence)
                {
                    // Console.WriteLine($" {n} {numLength}");
                    int currentNumPlace = Convert.ToInt32(n.ToString());
                    result += ProcessNumberSequenceItem(currentNumPlace, numLength);                    
                    numLength--;
                }
            }
            else
            {
                result = "The number entered cannot be expressed as a roman numeral";
            }
            // 
            return $"{ num } => {result}";
        }
        private bool IsValidNumeralNumber(int num)
        {
            return num > 0 && num < 4000; 
        }

        private string GetRepeatedSequence(int key, int count)
        {
            return string.Join("", Enumerable.Repeat(romanNumeralLookup.GetRomanNumeral(key), count));
        }

        private string ProcessNumberSequenceItem(int num, int pos)
        {
            if (num < 4)
            {
                switch (pos)
                {
                    case 1:
                        return GetRepeatedSequence(1, num);                        
                    case 2:
                        return GetRepeatedSequence(10, num);
                    case 3:
                        return GetRepeatedSequence(100, num);
                    default:
                        return string.Empty;
                }
                
            }
            else if (num == 4)
            {
                switch (pos)
                {
                    case 1:
                        return romanNumeralLookup.GetRomanNumeral(1) + romanNumeralLookup.GetRomanNumeral(5);
                    case 2:
                        return romanNumeralLookup.GetRomanNumeral(10) + romanNumeralLookup.GetRomanNumeral(50);
                    case 3:
                        return romanNumeralLookup.GetRomanNumeral(100) + romanNumeralLookup.GetRomanNumeral(500);
                    default:
                        return string.Empty;
                }
                
            }
            else if (num == 5)
            {
                switch (pos)
                {
                    case 1:
                        return romanNumeralLookup.GetRomanNumeral(5);
                    case 2:
                        return romanNumeralLookup.GetRomanNumeral(50);
                    case 3:
                        return romanNumeralLookup.GetRomanNumeral(500);
                    default:
                        return string.Empty;
                }
                
            }
            else if (num > 5 && num < 9)
            {
                switch (pos)
                {
                    case 1:
                        return romanNumeralLookup.GetRomanNumeral(5) + GetRepeatedSequence(1, num - 5);
                    case 2:
                        return romanNumeralLookup.GetRomanNumeral(50) + GetRepeatedSequence(10, num - 5); ;
                    case 3:
                        return romanNumeralLookup.GetRomanNumeral(500) + GetRepeatedSequence(100, num - 5); ;
                    default:
                        return string.Empty;
                }                
            }
            else if (num == 9)
            {
                switch (pos)
                {
                    case 1:
                        return romanNumeralLookup.GetRomanNumeral(1) + romanNumeralLookup.GetRomanNumeral(10);
                    case 2:
                        return romanNumeralLookup.GetRomanNumeral(10) + romanNumeralLookup.GetRomanNumeral(100);
                    case 3:
                        return romanNumeralLookup.GetRomanNumeral(100) + romanNumeralLookup.GetRomanNumeral(1000);
                    default:
                        return string.Empty;
                }                
            }
            else
            {
                return "";
            }
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
