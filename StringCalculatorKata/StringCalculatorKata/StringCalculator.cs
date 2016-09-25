using System.Linq;
using NUnit.Framework.Constraints;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public static int Add(string numbersList)
        {
            if (string.IsNullOrEmpty(numbersList))
            {
                return 0;
            }

            if (numbersList.Split(',').Count() == 1)
            {
                return int.Parse(numbersList);
            }

            if (numbersList.Split(',').Count() == 2)
            {
                return int.Parse(numbersList.Split(',')[0]) + int.Parse(numbersList.Split(',')[1]);
            }

            if (numbersList.Split(',').Any())
            {
                var numbers = numbersList.Split(',');
                var total = 0;

                foreach (var number in numbers)
                {
                    total = total + int.Parse(number);
                }

                return total;
            }

            return int.Parse(numbersList.First().ToString()) + int.Parse(numbersList.Last().ToString());
        }
    }
}