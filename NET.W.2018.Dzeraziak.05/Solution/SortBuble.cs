using System;

namespace Solution.Sort
{
    public class SortBuble
    {
        /// <summary>
        /// An implementation of buble sorting algorithm for a jagged array
        /// </summary>
        /// <param name="arr">Jagged array</param>
        /// <returns>Jagged array</returns>
        public static int [][]SortAscending(int[][] arr)
        {
            for(int f = 0; f < arr.Length - 2; f++)
            {
                for(int i = 0; i < arr.Length - 2; i++)
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