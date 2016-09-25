using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using StringCalculatorKata;

namespace StringCalculatorUnitTests
{
    [TestFixture]
    public class StringCalculatorShould
    {
//        String Calculator
//1.	Create a simple String calculator with a method int Add(string numbers)
//2.	The method can take 0, 1 or 2 numbers, and will return their sum 
//        (for an empty string it will return 0) for example “” or “1” or “1,2”
////3.	Allow the Add method to handle an unknown amount of numbers
////4.	Allow the Add method to handle new lines between numbers 
//        (instead of commas).
////a.	the following input is ok:  “1\n2,3”  (will equal 6)
////b.	the following input is NOT ok:  “1,\n” 
//        (not need to prove it - just clarifying)
////5.	Support different delimiters
////1.	to change a delimiter, the beginning of the string will contain a 
//        separate line that looks like this:   “//[delimiter]\n[numbers…]” for example “//;\n1;2” should return three where the default delimiter is ‘;’ . The first line is optional. all existing scenarios should still be supported
////2.	Calling Add with a negative number will throw an exception 
//        “negatives not allowed” - and the negative that was passed.if there are multiple negatives, show all of them in the exception message

        [Test]
        public void Return_Zero_Given_Empty_String()
        {
            var emptyInput = string.Empty;

            var result = StringCalculator.Add(emptyInput);

            result.Should().Be(0);
        }
    
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("22", 22)]
        [TestCase("223", 223)]
        public void Return_Integer_Value_When_Add_Given_A_Single_Value_Input(string input, int integerRepresentation)
        {
            var result = StringCalculator.Add(input);

            result.Should().Be(integerRepresentation);
        }

        [TestCase("1,2", 3)]
        [TestCase("2,3", 5)]
        [TestCase("1,9", 10)]
        [TestCase("11,9", 20)]
        public void Return_Sum_Of_Values_When_Add_Comma_Seperated_Input_With_Two_Values(string numbers, int expectedSum)
        {
            var result = StringCalculator.Add(numbers);

            result.Should().Be(expectedSum);
        }

        [TestCase("1,5,7", 13)]
        public void Return_Sum_Of_Values_When_Add_Comma_Seperated_Input_With_More_Than_Two_Values(string numbers, int expectedSum)
        {
            var result = StringCalculator.Add(numbers);

            result.Should().Be(expectedSum);
        }
    }
}