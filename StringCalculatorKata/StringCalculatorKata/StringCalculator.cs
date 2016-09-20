using System.Linq;
using NUnit.Framework.Constraints;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            if (numbers.Split(',').Count() == 1)
            {
                return int.Parse(numbers);
            }

            if (numbers.Split(',').Count() == 2)
            {
                return int.Parse(numbers.Split(',')[0]) + int.Parse(numbers.Split(',')[1]);
            }

            return int.Parse(numbers.First().ToString()) + int.Parse(numbers.Last().ToString());
        }
    }
}