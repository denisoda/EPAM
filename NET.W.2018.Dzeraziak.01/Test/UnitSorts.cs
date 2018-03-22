using System;
using Xunit;
using Solution.Sorts;

namespace Solution.Sorts.Xunit
{
    public class SortTest
    {
        ///<summary>QuickSort Unity Test</summary>  
        [Fact]
        public void QuickSort_Int_IsSorted()
        {
            var arrGoal = new int[]{1, 2, 3, 4, 5, 6, 7};
            var arrInput = new int[]{2, 1, 3, 5, 6, 7, 4};

            Sorts.QuickSort(arrInput, 0, arrInput.Length - 1);

            Assert.Equal(arrGoal, arrInput);
        }

        ///<summary>MergeSort Unity Test</summary>  
        [Fact]
        public void Mergesort_Int_IsSorted()
        {
            var arrGoal = new int[]{1, 2, 3, 4, 5, 6, 7};
            var arrInput = new int[]{2, 1, 3, 5, 6, 7, 4};

            Sorts.MergeSort(arrInput, 0, arrInput.Length - 1);

            Assert.Equal(arrGoal, arrInput);
        }
    }
}
