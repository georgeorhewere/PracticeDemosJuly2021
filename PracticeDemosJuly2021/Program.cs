using PracticeDemosJuly2021.RomanNumeralConversion;
using System;

namespace PracticeDemosJuly2021
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pratice tests");
            convertToRomanNumeral();
            ConvertRomanToNumber();


        }

        static void ConvertRomanToNumber()
        {
            NumberRomanConverter romanConverter = new NumberRomanConverter();
            romanConverter.Decode("XXI");
            romanConverter.Decode("MMMCMXCIX");
            romanConverter.Decode("MMVIII");
            romanConverter.Decode("MCMXC");
            romanConverter.Decode("XXIV");
        }

        static void convertToRomanNumeral()
        {
            Console.WriteLine("Convert to Roman Symbols");
            RomanNumeralConverter converter = new RomanNumeralConverter();
            //Console.WriteLine($"result -: {converter.Numerals(5000)}");
            // Console.WriteLine($"result -: {converter.Numerals(1)}");
            // Console.WriteLine($"result -: {converter.Numerals(1666)}");
            // Console.WriteLine($"result -: {converter.Numerals(2008)}");
            Console.WriteLine($"result -: {converter.Numerals(1990)}");
            // Console.WriteLine($"result -: {converter.Numerals(1000)}");
            Console.WriteLine($"result -: {converter.Numerals(3999)}");
            // Console.WriteLine($"result -: {converter.Numerals(3000)}");
            // Console.WriteLine($"result -: {converter.Numerals(788)}");
            Console.WriteLine($"result -: {converter.Numerals(59)}");
            Console.WriteLine($"result -: {converter.Numerals(24)}");
            Console.ReadKey();

        }

        static void PrintResult()
        {

        }
    }
}
