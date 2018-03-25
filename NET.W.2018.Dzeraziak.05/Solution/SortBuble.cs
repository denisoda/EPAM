using System;

namespace Solution.Sort
{
    public class SortBuble
    {
        /// <summary>
        /// An implementation of buble sorting algorithm for a jagged array
        /// </summary>
        /// <param name="arr">Jagged array</param>
        /// <returns>Sorted in ascending order jagged array</returns>
        public static int [][] SortAscending(int[][] arr)
        {
            for(int f = 0; f <= arr.Length - 1; f++)
            {
                for(int i = 0; i < arr[f].Length - 2; i++)
                {
                    if(arr[f][i] > arr[f][i+1])
                    {
                        int buf = arr[f][i];
                        arr[f][i] = arr[f][i + 1];
                        arr[f][i + 1] = buf;
                    } 
                }
            }
            return arr;
        }
    }
}