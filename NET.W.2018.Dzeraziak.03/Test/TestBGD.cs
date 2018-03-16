using NUnit.Framework;
using Solution;

namespace Tests
{
    public class BGD
    {
        [Test]
        [TestCase(1, ExpectedResult = 5)]
        [TestCase(1, ExpectedResult = 6)]
        public int TestSimple(int expect)
        {
            return Class1.a(expect);
        }
    }
}