/**
 * @author Ilya Dzeraziak
 * @email IlyaDzeraziak@gmail.com
 * @create date 2018-03-20 07:17:06
*/

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
        [Test]
        [TestCase(100, 45, ExpectedResult = 5)]
        [TestCase(45, 5, ExpectedResult = 5)]
        [TestCase(228, 1488, ExpectedResult = 12)]
        [TestCase(17, 7, ExpectedResult = 1)]
        [TestCase(5, 10, ExpectedResult = 5)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(5, 10, ExpectedResult = 5)]
        [TestCase(15, 10, 5, ExpectedResult = 5)]
        [TestCase(99, 15, 3, ExpectedResult = 3)]
        public int Evclid_Gcd_IsReturnGcd(int first, int second, int third = 0)
        => third == 0 ? Gcd.Evclid(first, second) : Gcd.Evclid(first, second, third); 
        
        [Test]
        [TestCase(100, 45, ExpectedResult = 5)]
        [TestCase(45, 5, ExpectedResult = 5)]
        [TestCase(228, 1488, ExpectedResult = 12)]
        [TestCase(17, 7, ExpectedResult = 1)]
        [TestCase(5, 10, ExpectedResult = 5)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(5, 10, ExpectedResult = 5)]
        public int Evclid_Gcd_IsReturnGcd(int first, int second)
        {
           return Gcd.EvclidBin(first, second);
        }
        [Test]
        [TestCase(100, 45, ExpectedResult = 5)]
        [TestCase(45, 5, ExpectedResult = 5)]
        [TestCase(228, 1488, ExpectedResult = 12)]
        [TestCase(17, 7, ExpectedResult = 1)]
        [TestCase(5, 10, ExpectedResult = 5)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(5, 10, ExpectedResult = 5)]
        public int EvclidRecursion_Gcd_IsReturnGcd(int first, int second)
        {
           return Gcd.EvclidRecursion(first, second);
        }
    }
}