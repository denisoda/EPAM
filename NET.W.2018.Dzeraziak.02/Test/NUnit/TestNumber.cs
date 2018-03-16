//using System.Collections.Generic;


//namespace Solution.Number.Test
//{
//    public class Tests
//    {
//        [Test]
//        [TestCase(12, ExpectedResult = 21)]
//        [TestCase(513, ExpectedResult = 531)]
//        [TestCase(2017, ExpectedResult = 2071)]
//        [TestCase(414, ExpectedResult = 441)]
//        [TestCase(144, ExpectedResult = 414)]
//        [TestCase(1234321, ExpectedResult = 1241233)]
//        [TestCase(1234126, ExpectedResult = 1234162)]
//        [TestCase(3456432, ExpectedResult = 3462345)]
//        [TestCase(10, ExpectedResult = -1)]
//        [TestCase(20, ExpectedResult = -1)]
//        public int IsReturnCorrect(int value)
//        {
//            return Number.FindNextBiggerNumber(value);
//        }
//    }

//    public class FilterDigit
//    {
        
//            IEnumerable<int> source = new List<int> { 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
//            int digit = 7;
//            IEnumerable<int> expected = new List<int> { 7, 70, 17 };

//            IEnumerable<int> result = Task4.FilterDigit(source, digit);

//            Assert.IsTrue(expected.SequenceEqual(result));
//    }
//}