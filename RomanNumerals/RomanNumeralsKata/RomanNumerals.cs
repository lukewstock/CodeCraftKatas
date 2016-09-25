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

            if (number > 50)
            {
                return arabicToRomanNumerals[50] + Convert(number - 50);
            }

            if (number > 10)
            {
                return arabicToRomanNumerals[10] + Convert(number - 10);
            }

            if (number > 5)
            {
                return arabicToRomanNumerals[5] + Convert(number - 5);
            }


            return arabicToRomanNumerals[1] + Convert(number - 1);
        }
    }
}