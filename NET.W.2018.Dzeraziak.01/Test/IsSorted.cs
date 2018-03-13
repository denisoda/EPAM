using System;
using Xunit;

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

            Array.Sort(arrInput);
            
            Assert.Equal(arrGoal, arrInput);
        }
    }
}
