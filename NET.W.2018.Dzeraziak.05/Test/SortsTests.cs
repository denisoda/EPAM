using System;
using NUnit.Framework;
using Solution.Sort;
using Solution;

namespace Solution.Test.NUnit
{
    public class Tests
    {   
        #region Ascending test
        /// <summary>
        /// Tests the jagged array buble sorting in an ascending order 
        /// </summary>
        [Test]
        public void SortBuble_IsSorted_Ascending()
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
        #endregion

        #region Descending test
        /// <summary>
        /// Tests the jagged array buble sorting in an descending order 
        /// </summary>
        [Test]
        public void SortBuble_IsSorted_Descending()
        {
            int[][] sortArray = new int[][]
            {
                new int[] {5, 2, 4, 8, 35}
            };

            var test = SortBuble.SortDescending(sortArray);

            var desiredResult = new int[][]
            {
                new int[] {35, 8, 5, 4, 2}
            };
            
            Assert.AreEqual(desiredResult, test);            
        }
        #endregion

        #region SortRowsSum tests
        [Test]
        public void SortRowsSum_IsSorted_Ascending() 
        {
            int[][] sortArray = new int[][]
            {
                new int[] {5, 2, 4, 8, 35},
                new int[] {2, 2, 4, 1, 228},
                new int[] {26, 24, 5, 8, 1},
                new int[] {90, 34, 77, 2, 35}
            };

            var actualResult = SortBuble.SortRowsSum(sortArray);

            int[] desiredResult = new int []{35, 237, 64, 238};

            Assert.That(actualResult, Is.EqualTo(desiredResult));
        }
        #endregion
    }
}