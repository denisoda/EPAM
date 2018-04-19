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
        public static T Search<T>(T[] array, T searchFor, Comparer comparer)
        {
            int high = array.Length - 1;
            int low = 0;
            if (array[low].Equals(searchFor))
                return array[low];
            else if (array[high].Equals(searchFor))
                return array[high];
            else
            {
                while (low <= high)
                {
                    var mid = (high + low) / 2;
                    if (comparer.Compare(array[mid], searchFor) == 0)
                    {
                        return array[mid];
                    }
                    else
                    {
                        if (comparer.Compare(searchFor, array[mid]) > 0)
                            high = mid + 1;
                        else
                            low = mid + 1;
                    }
                }

                if (low > high)
                {
                    throw new ArgumentException("value is not found!");
                }
            }

            return array[0];
        }
    }
}