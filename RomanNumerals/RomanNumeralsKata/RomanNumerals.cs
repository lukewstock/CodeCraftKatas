using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

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

            foreach (var arabicToRomanNumeral in arabicToRomanNumerals.Reverse())
            {
                while (number >= arabicToRomanNumeral.Key)
                {
                    result += arabicToRomanNumeral.Value;
                    number -= arabicToRomanNumeral.Key;
                }
            }

            return result;
        }
    }
}