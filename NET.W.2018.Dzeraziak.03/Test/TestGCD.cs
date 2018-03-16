using NUnit.Framework;
using Solution;

namespace Solution.Tests
{
    public class TestGCD
    {
        [Test]
        // [TestCase(1, ExpectedResult = 5)]
        // [TestCase(1, ExpectedResult = 6)]
        public int IsRetunGCD(int expect)
        {
            return Number.FindGCD(expect);
        }
    }
}