using System;
using System.Linq;
using Generator;
using NUnit.Framework;

namespace Test
{
    public class GeneratorTests
    {
        /// <summary>
        /// tests whether the method generates the correct elements of the array which sum must be equal of one
        /// </summary>
        /// <param name="num">number of elements for generation</param>
        [Test]
        [TestCase(7)]
        [TestCase(5)]
        [TestCase(4)]
        [TestCase(8)]
        [TestCase(10)]
        [TestCase(50)]
        public void GenerateWithSumOfElementsIsOne(int num)
        {
            Assert.IsTrue(Math.Abs(RandomArray.GenerateWithSumOfElementsIsOne(num).Sum() - 1.0) < 1e-8);
        }
    }
}