using System;

namespace Solution.Extensions
{
    public  static class Extensions
    {
        /// <summary>
        ///An exension which calculates the sum of the row in a two dementional array
        /// </summary>
        /// <returns>An array with sum of elements</returns>
        public static int [] RowsSum(this int[][] arr)
        {
            if(arr is null)
            {
                throw new ArgumentNullException(nameof(arr)); 
            }

            int [] sum = new int[arr.Length];

                for(int i = 0; i < arr.Length - 1; i++)
                {
                    for(int j = 0; j < arr[i].Length - 1; j++)
                    {
                        sum[i] += arr[i][j];
                    }
                }
            
            return sum;
        }
    }
}