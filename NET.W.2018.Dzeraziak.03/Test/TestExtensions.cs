using NUnit.Framework;
using Solution.Extensions;

namespace Solution.Tests
{
    public class TestExtensions
    {
        [Test]
        [TestCase(5, ExpectedResult = "101")]
        public string IsCorrectConvertationDoubleToBinaryInStringFormat(double number) 
        => Extensions.Extensions.GetBinaryString(number);
    }
}