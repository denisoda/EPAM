using NUnit.Framework;
using Solution;

namespace Solution.Tests
{
    public class TestGCD
    {
        /// <summary>
        /// Test shows correctness of greates common value return method with two integers input
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        [Test]
        [TestCase(100, 45, ExpectedResult = 5)]
        [TestCase(45, 5, ExpectedResult = 5)]
        [TestCase(228, 1488, ExpectedResult = 12)]
        [TestCase(17, 7, ExpectedResult = 1)]
        [TestCase(5, 10, ExpectedResult = 5)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(5, 10, ExpectedResult = 5)]
        public int IsRetunCorrectGCD(int first, int second)
        {
            return Gcd.Evclid(first, second);
        }
    }
}