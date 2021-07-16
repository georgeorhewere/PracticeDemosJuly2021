using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemosJuly2021.RomanNumeralConversion
{
    public class NumberRomanConverter
    {
        private RomanNumeralLookup romanNumeralLookup;        
        public NumberRomanConverter()
        {
            romanNumeralLookup = new RomanNumeralLookup();
        }

        public int Decode(string roman)
        {
            int result = 0;            
            //process string from right to left
            int previousNum = 0;
            for(int x= roman.Length -1; x >= 0; x--)
            {
                var num = romanNumeralLookup.GetNumberKey(roman[x]);
                

                if (previousNum != 0 && previousNum > num)
                {
                    result -= previousNum;
                    num = previousNum - num;
                }
                else
                {
                    previousNum = num;
                }

                result += num;
                

            }
            Console.WriteLine($"{roman}  => {result}");

            return result;
        }



    }
}
