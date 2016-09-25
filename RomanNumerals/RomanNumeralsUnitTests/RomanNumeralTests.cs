using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using RomanNumeralsKata;

namespace RomanNumeralsUnitTests
{
    [TestFixture]
    public class RomanNumeralShould
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(11, "XI")]
        [TestCase(12, "XII")]
        [TestCase(14, "XIV")]
        [TestCase(19, "XIX")]
        [TestCase(20, "XX")]
        [TestCase(30, "XXX")]
        [TestCase(40, "XL")]
        [TestCase(50, "L")]
        [TestCase(60, "LX")]
        public void Return_Roman_Numeral_When_Convert_Given_Arabic_Number(int number, string expectedNumeral)
        {
            var romanNumerals = RomanNumerals.Convert(number);

            romanNumerals.Should().Be(expectedNumeral);
        }
    }
}
