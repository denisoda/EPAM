using System;
using System.Collections;
using NUnit.Framework;
using NUnit.Framework.Internal;
using BinarySearch;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void BinarySearch_SortedArray_IsTrue()
        {
            int[] arr = {15, 22, 49, 5645, 44, 0, 432, -456, 99};

            Array.Sort(arr);

            Assert.AreEqual(true, BinarySearch<int>.Search(arr, 432, Comparer.Default));
        }
    }
}
