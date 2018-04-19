using System;
using System.Collections;
using System.Collections.Generic;

namespace BinarySearch
{
    public class BinarySearch<T>
    {
        /// <summary>
        /// An emplementation of a binary sort
        /// </summary>
        /// <returns>Searched element</returns>
        public static bool Search<T>(T[] array, T searchFor, Comparer comparer)
        {
            uint high = (uint)array.Length - 1;
            uint low = 0;
            uint mid = high >> 1;

            if (array[low].Equals(searchFor)) return true;
            else if (array[high].Equals(searchFor)) return true;

            else
            {
                while (high >= low)
                {
                    int compResult = comparer.Compare(array[mid], searchFor);

                    if (compResult == 0)
                        return true;
                    else if (compResult > 0)
                            high = mid + 1;
                    else
                            low = mid + 1;

                    mid = (low + high) >> 1;
                }
            }

            return false;
        }
    }
}