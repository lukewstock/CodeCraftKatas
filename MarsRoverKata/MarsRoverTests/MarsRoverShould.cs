using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace MarsRoverTests
{
    [TestFixture]
    public class MarsRoverShould
    {
        [Test]
        public void a()
        {
            new MarsRover().GetP().Should().Be("1 1 N");
        }
    }

    public class MarsRover
    {
        public string GetP()
        {
            return "1 1 N";
        }
    }
}
