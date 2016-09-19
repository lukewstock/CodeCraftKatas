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

            if (numbers.Length == 1)
            {
                return int.Parse(numbers);
            }

            if (numbers.Length == 2)
            {
                return int.Parse(numbers);
            }

            return int.Parse(numbers.First().ToString()) + int.Parse(numbers.Last().ToString());
        }
    }
}