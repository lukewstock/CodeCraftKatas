using System;
using System.Collections.Generic;
using System.Globalization;

namespace RomanNumeralsKata
{
    public class RomanNumerals
    {
        public static string Convert(int number)
        {
            var arabicToRomanNumerals = new Dictionary<int, string>
            {
                {1, "I"},
                {4, "IV"},
                {5, "V"},
                {9, "IX"},
                {10, "X"},
                {40, "XL"},
                {50, "L"}
            };

            if (arabicToRomanNumerals.ContainsKey(number))
            {
                return arabicToRomanNumerals[number];
            }

            var result = string.Empty;

            while (number >= 40)
            {
                result += arabicToRomanNumerals[40];
                number -= 40;
            }

            while (number >= 10)
            {
                result += arabicToRomanNumerals[10];
                number -= 10;
            }

            while (number >= 9)
            {
                result += arabicToRomanNumerals[9];
                number -= 9;
            }

            while (number >= 5)
            {
                result += arabicToRomanNumerals[5];
                number -= 5;
            }

            while (number >= 4)
            {
                result += arabicToRomanNumerals[4];
                number -= 4;
            }

            while (number >= 1)
            {
                result += arabicToRomanNumerals[1];
                number -= 1;
            }

            return result;
        }
    }
}