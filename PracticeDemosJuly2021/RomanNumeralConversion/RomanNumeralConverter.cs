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

        public string Numerals(int number)
        {
            string result = string.Empty;
            //max number range is 3999
            if (IsValidRomanNumeralNumber(number))
            {
                //process numeral digits
                string numSequence = number.ToString();
                int numPosition = numSequence.Length;
                
                //process each num from left to right
                foreach(var num in numSequence)
                {                    
                    int currentNumToProcess = Convert.ToInt32(num.ToString());
                    result += ProcessNumberSequenceItem(currentNumToProcess, numPosition);
                    numPosition--;
                }
            }
            else
            {
                result = "The number entered cannot be expressed as a roman numeral - max range is 3999";
            }
            // 
            return $"{ number } => {result}";
        }
        private bool IsValidRomanNumeralNumber(int num)
        {
            return num > 0 && num < 4000; 
        }

        private string GetRepeatedSequence(int key, int count)
        {
            return string.Join("", Enumerable.Repeat(romanNumeralLookup.GetRomanNumeral(key), count));
        }

        private string ProcessNumberSequenceItem(int num, int position)
        {
            if (num < 4)
            {
                switch (position)
                {
                    case 1:
                        return GetRepeatedSequence(1, num);                        
                    case 2:
                        return GetRepeatedSequence(10, num);
                    case 3:
                        return GetRepeatedSequence(100, num);
                    case 4:
                        return GetRepeatedSequence(1000, num);
                    default:
                        return string.Empty;
                }
                
            }
            else if (num == 4)
            {
                switch (position)
                {
                    case 1:
                        return $"{romanNumeralLookup.GetRomanNumeral(1)}{ romanNumeralLookup.GetRomanNumeral(5) }";
                    case 2:
                        return $"{ romanNumeralLookup.GetRomanNumeral(10)}{ romanNumeralLookup.GetRomanNumeral(50)}";
                    case 3:
                        return $"{ romanNumeralLookup.GetRomanNumeral(100)} {romanNumeralLookup.GetRomanNumeral(500)}";
                    default:
                        return string.Empty;
                }
                
            }
            else if (num == 5)
            {
                switch (position)
                {
                    case 1:
                        return $"{romanNumeralLookup.GetRomanNumeral(5)}";
                    case 2:
                        return $"{romanNumeralLookup.GetRomanNumeral(50)}";
                    case 3:
                        return $"{romanNumeralLookup.GetRomanNumeral(500)}";
                    default:
                        return string.Empty;
                }
                
            }
            else if (num > 5 && num < 9)
            {
                switch (position)
                {
                    case 1:
                        return $"{ romanNumeralLookup.GetRomanNumeral(5)}{ GetRepeatedSequence(1, num - 5)}";
                    case 2:
                        return $"{ romanNumeralLookup.GetRomanNumeral(50) }{ GetRepeatedSequence(10, num - 5)}" ;
                    case 3:
                        return $"{ romanNumeralLookup.GetRomanNumeral(500) }{ GetRepeatedSequence(100, num - 5)}"; 
                    default:
                        return string.Empty;
                }                
            }
            else if (num == 9)
            {
                switch (position)
                {
                    case 1:
                        return $"{ romanNumeralLookup.GetRomanNumeral(1) }{ romanNumeralLookup.GetRomanNumeral(10)}";
                    case 2:
                        return $"{ romanNumeralLookup.GetRomanNumeral(10) }{ romanNumeralLookup.GetRomanNumeral(100)}";
                    case 3:
                        return $"{ romanNumeralLookup.GetRomanNumeral(100) }{ romanNumeralLookup.GetRomanNumeral(1000)}";
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

   
}
