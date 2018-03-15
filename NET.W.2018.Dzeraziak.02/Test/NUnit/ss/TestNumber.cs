using System;
using NUnit.Framework;
using Solution.Number;

namespace Solution.Number.NUnit
{
    public class TestNumber
    {
        [Fact]
        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]
        public int IsReturnCorrect(int value)
        {
            return Number.FindNextBiggerNumber(value);
        }

        [Fact]
        [TestCase(1, 5, 0.0001, ExpectedResult = 1)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.001, 3, 0.0001, ExpectedResult = 0.1)]
        [TestCase(0.04100625,4 , 0.0001, ExpectedResult = 0.45)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.0279936, 7, 0.0001, ExpectedResult = 0.6)]
        [TestCase(0.0081, 4, 0.1, ExpectedResult = 0.3)]
        [TestCase(-0.008, 3, 0.1, ExpectedResult = -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, ExpectedResult = 0.545)]
        [TestCase(8, 15, -7, -5)]// &lt;-ArgumentOutOfRangeException
        [TestCase(8, 15, -0.6, -0.1)]// &lt;-ArgumentOutOfRangeException
        public int IsNewtonPowered(double number, int degree, double precision)
        {
            return FindNthRoot(number, degree, precision);
        }
    }
}