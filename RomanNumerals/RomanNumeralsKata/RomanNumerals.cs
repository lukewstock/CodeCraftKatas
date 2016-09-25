using System.Collections.Generic;

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
                {5, "V"}
            };

            if (number > 5)
            {
                return arabicToRomanNumerals[5] + Convert(number - 5);
            }
          
            if (arabicToRomanNumerals.ContainsKey(number))
            {
                return arabicToRomanNumerals[number];
            }
            
            return arabicToRomanNumerals[1] + Convert(number - 1);
        }
    }
}