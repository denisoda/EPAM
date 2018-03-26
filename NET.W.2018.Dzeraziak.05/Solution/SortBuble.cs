using System;
using Solution.Extensions;

namespace Solution.Sort
{
    public class SortBuble
    {
        #region Sorting public methods
        /// <summary>
        /// An implementation of buble sorting algorithm for a jagged array
        /// </summary>
        /// <param name="arr">Jagged array</param>
        /// <returns>Sorted in ascending order jagged array</returns>
        public static int [][] SortAscending(int[][] arr)
        {
            if(arr is null)
            {
                throw new ArgumentNullException(nameof(arr));
            }
                for(int p = 0; p <= arr.Length - 1; p++)
                {
                    for(int f = 0; f <= arr.Length - 1; f++)
                    {
                        for(int i = 0; i < arr[f].Length - 1; i++)
                        {
                            if(arr[f][i] > arr[f][i+1])
                            {
                                int buf = arr[f][i];
                                arr[f][i] = arr[f][i + 1];
                                arr[f][i + 1] = buf;
                            } 
                        }
                    }
                }
            return arr;
        }

        /// <summary>
        /// An implementation of buble sorting algorithm for a jagged array
        /// </summary>
        /// <param name="arr">Jagged array</param>
        /// <returns>Sorted in descending order jagged array</returns>
        public static int [][] SortDescending(int[][] arr)
        {
            if(arr is null)
            {
                throw new ArgumentNullException(nameof(arr));
            }
                for(int f = 0; f <= arr.Length - 1; f++)
                {
                    for(int p = 0; p <= arr[f].Length - 1; p++)
                    {
                        for(int i = 0; i < arr[f].Length - 1; i++)
                        {
                            if(arr[f][i] < arr[f][i+1])
                            {
                                int buf = arr[f][i + 1];
                                arr[f][i + 1] = arr[f][i];
                                arr[f][i] = buf;
                            } 
                        }
                    }
                }
            return arr;
        }

        /// <summary>
        /// An emplementation of row sum sorting algorithm
        /// </summary>
        /// <param name="arr">Two dementional array for sorting</param>
        /// <returns>Sorted array</returns>
        public static int [] SortRowsSum(int [][] arr)
        {
            if(arr is null)
                throw new ArgumentNullException(nameof(arr));

            int[] sum =  arr.RowsSum();

            for(int i = 0; i < sum.Length; i++)
            {
                for(int j = 0; j < sum.Length - 1; j++)
                {
                    if(sum[j] > sum[j + 1])
                    {
                        int buf = sum[j];
                        sum[j] = sum[j + 1];
                        sum[j + 1] = buf;
                    }
                }
            }

            return sum;
        }
    }
    #endregion
}