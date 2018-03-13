using System;
using Xunit;
using Solution.Sorts;

namespace Test
{
    public class SortTest
    {
        ///<summary>QuickSort Unity Test</summary>  
        [Fact]
        public void IsQuickSorted()
        {
            var arrGoal = new int[]{1, 2, 3, 4, 5, 6, 7};
            var arrInput = new int[]{2, 1, 3, 5, 6, 7, 4};

            Sorts.QuickSort(arrInput, 0, arrInput.Length - 1);

            Assert.Equal(arrGoal, arrInput);
        }

        ///<summary>MergeSort Unity Test</summary>  
        [Fact]
        public void IsMergeSorted()
        {
            var arrGoal = new int[]{1, 2, 3, 4, 5, 6, 7};
            var arrInput = new int[]{2, 1, 3, 5, 6, 7, 4};

            Sorts.MergeSort(arrInput, 0, arrInput.Length - 1);

            Assert.Equal(arrGoal, arrInput);
        }
    }
}
