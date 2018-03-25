using System;
using NUnit.Framework;
using Solution.Sort;
using Solution;

namespace Solution.Test.NUnit
{
    public class Tests
    {
        [Test]
        public void SortBuble_IsSorted_Ascending(int [][] arr)
        {
            int[][] sortArray = new int[][]
            {
                new int[] {5, 2, 4, 8, 35}
            };

            var test = SortBuble.SortAscending(sortArray);

            var desiredResult = new int[][]
            {
                new int[] {2, 4, 5, 8, 35}
            };
            
            Assert.AreEqual(desiredResult, test);            
        }
    }
}