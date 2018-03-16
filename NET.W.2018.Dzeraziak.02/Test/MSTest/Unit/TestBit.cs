using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.Bit;


namespace Solution.Number.Test
{
    [TestClass]
    public class TestBit
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow(8, 15, 0, 0, 9)]
        [DataRow(15, 15, 0, 0, 15)]
        [DataRow(8, 15, 3, 8, 120)]
        public void InsertNumber_InputCorrectValues(int source, int insert, int j, int i, int expected)
        {

            var result = Bit.Bit.InsertNumber(source, insert, j, i);

            Assert.AreEqual(expected, result);
        }
    }
}
