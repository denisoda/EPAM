using System;
using System.Collections.Generic;
using NUnit.Framework;
using BinarySearch;

namespace BinarySearch.UnitTest.NUnit
{
    public class Tests
    {
        [TestCase(new []{15, 22, 49, 5645, 44, 0, 432, -456, 99}, (int)5)]
        [Test]
        public void BinarySearch_SortedArray_HasFoundCorrectItem<T>(T []array, T searchFor)
        {
            Assert.AreEqual(searchFor, BinarySearch<int>.Search(array, searchFor, System.Collections.Comparer.Default));
        }
    }
}