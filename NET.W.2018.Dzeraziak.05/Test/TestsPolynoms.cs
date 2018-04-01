using System;
using NUnit.Framework;
using Solution.Sort;
using Solution;
using System.IO;

namespace Solution.Polynom.UnitTest.NUnit
{
    /// <summary>
    /// Tests the polynoms to string mehtod
    /// </summary>
    public class TestsPolynoms
    {
        [Test]
        [TestCase(new double[]{1.5, 18.1, 2.15, 7.95}, new double[]{1.5, 15, 2.15, 3.45}, ExpectedResult = "Coefficients:*3;*33.1;*4.3;*11.4")]
        [TestCase(new double[]{8.5, 8.1, -2.15, 1.15}, new double[]{2.5, 25, 8.5, 3.65}, ExpectedResult = "Coefficients:*11;*33.1;*6.35;*4.8")]
        [TestCase(new double[]{0.5, 1.1, 0.15, 0.95}, new double[]{15.1, 5, 2.25, 1.45}, ExpectedResult = "Coefficients:*15.6;*6.1;*2.4;*2.4")]
        [TestCase(new double[]{0.4, 12.1, 1.645, 0.95}, new double[]{1.5, 15, 2.15, 3.45}, ExpectedResult = "Coefficients:*1.9;*27.1;*3.795;*4.4")]
        [TestCase(new double[]{14.5, 8.241, 2.215, 27.95}, new double[]{-11.5, 15.14, 2.5, 124.45}, ExpectedResult = "Coefficients:*3;*23.381;*4.715;*152.4")]
        [TestCase(new double[]{18.5, 15.1, 2.15, 7.95}, new double[]{1.5, 15, 2.1, 3.4}, ExpectedResult = "Coefficients:*20;*30.1;*4.25;*11.35")]
        [TestCase(new double[]{11.5, 128.1, 2.15, 7.95}, new double[]{112.5, 15, 2.15, 0.45}, ExpectedResult = "Coefficients:*124;*143.1;*4.3;*8.4")]
        [TestCase(new double[]{0, 0, 0, 0}, new double[]{1.5, 15, 2.15, 3.45}, ExpectedResult = "Coefficients:*1.5;*15;*2.15;*3.45")]
        public string PolynomSum_AdditionToString_IsCorrect(double[] pFirst, double[] pSecond)
        {
            var polynomFirst = new Polynom(pFirst);
            var polynomSecond = new Polynom(pSecond);
           
            return (polynomFirst + polynomSecond).ToString();
        }
    }
}