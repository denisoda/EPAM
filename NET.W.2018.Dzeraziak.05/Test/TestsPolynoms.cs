using System;
using NUnit.Framework;
using Solution.Sort;
using Solution;

namespace Solution.Polynom.UnitTest.NUnit
{
    public class TestsPolynoms
    {
        [Test]
        [TestCase(new double[]{1.5, 15, 2.15, 3.45}, new double[]{1.5, 15, 2.15, 3.45}, ExpectedResult = "Coefficients:*")]
        public void PolynomSum_Addition_IsCorrect(double[] pFirst, double[] pSecond)
        {
            var polynomFirst = new Polynom(pFirst);
            var polynomSecond = new Polynom(pSecond);

            var a = (polynomFirst + polynomSecond).ToString();
        }
    }
}