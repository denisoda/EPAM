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
        public static void Search<T>(T[] array, T searchFor, Comparer<T> comparer)
        {
            int high, low, mid;
            high = array.Length - 1;
            low = 0;
            if (array[0].Equals(searchFor))
                Console.WriteLine("Value {0} Found At Index {1}", array[0], 0);
            else if (array[high].Equals(searchFor))
                Console.WriteLine("Value {0} Found At Index {1}", array[high], high);
            else
            {
                while (low <= high)
                {
                    mid = (high + low) / 2;
                    if (comparer.Compare(array[mid], searchFor) == 0)
                    {
                        Console.WriteLine("Value {0} Found At Index {1}", array[mid], mid);
                        break;
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
                    Console.WriteLine("Value Not Found In the Collection");
                }
            }
        }
    }
}