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
        }

        static void convertToRomanNumeral()
        {
            Console.WriteLine("Convert to Roman Symbols");
            RomanNumeralConverter converter = new RomanNumeralConverter();
            //Console.WriteLine($"result -: {converter.Numerals(5000)}");
            //Console.WriteLine($"result -: {converter.Numerals(1)}");
            //Console.WriteLine($"result -: {converter.Numerals(2)}");
            //Console.WriteLine($"result -: {converter.Numerals(3)}");
            //Console.WriteLine($"result -: {converter.Numerals(4)}");
            //Console.WriteLine($"result -: {converter.Numerals(5)}");
            //Console.WriteLine($"result -: {converter.Numerals(6)}");
            //Console.WriteLine($"result -: {converter.Numerals(7)}");
            Console.WriteLine($"result -: {converter.Numerals(78)}");
            Console.WriteLine($"result -: {converter.Numerals(59)}");
            Console.WriteLine($"result -: {converter.Numerals(24)}");
            Console.ReadKey();

        }

        static void PrintResult()
        {

        }
    }
}
