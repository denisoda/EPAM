using System;
using System.Diagnostics;
using NUnit.Framework;
using Solution.Extensions;
using System.Threading.Tasks;

namespace Solution.Extensions.Tests
{
    /// <summary>
    /// Class for testing extensions methods
    /// </summary>
    public class TestExtensions
    {
        /// <summary>
        /// Tests the correct convertatin from double to binary with string returning
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Binary converted representation</returns>
        [Test]
        [TestCase(-255.255, ExpectedResult = "1100000001101111111010000010100011110101110000101000111101011100")]
        [TestCase(255.255, ExpectedResult = "0100000001101111111010000010100011110101110000101000111101011100")]
        [TestCase(4294967295.0, ExpectedResult = "0100000111101111111111111111111111111111111000000000000000000000")]
        [TestCase(double.MinValue, ExpectedResult = "1111111111101111111111111111111111111111111111111111111111111111")]
        [TestCase(double.MaxValue, ExpectedResult = "0111111111101111111111111111111111111111111111111111111111111111")]
        [TestCase(double.Epsilon, ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000001")]
        [TestCase(double.NaN, ExpectedResult = "1111111111111000000000000000000000000000000000000000000000000000")]
        [TestCase(double.NegativeInfinity, ExpectedResult = "1111111111110000000000000000000000000000000000000000000000000000")]
        [TestCase(double.PositiveInfinity, ExpectedResult = "0111111111110000000000000000000000000000000000000000000000000000")]
        public string IsCorrectConvertationDoubleToBinaryInStringFormat(double number) 
        => number.GetBinaryString();

        /// <summary>
        /// Test a total time for executing in a ticks
        /// </summary>
        /// <param name="time">Desired ticks for execution</param>
        [TestCase(ExpectedResult = 3000)]
        public long IsEvclidMethodFast(int time)
        {
            var result = Extensions.GetExecutionTime(() => Gcd.Evclid(10, 100)).Elapsed.Ticks;

            return result;
        }
    }
}