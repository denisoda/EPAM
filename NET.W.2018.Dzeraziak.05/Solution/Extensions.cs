using System;

namespace Solution.Extensions
{
    public  static class Extensions
    {
        public static int [] RowsSum(this int[][] arr)
        {
            if(arr is null)
            {
                throw new ArgumentNullException(nameof(arr)); 
            }

            int [] sum = new int[arr.Length];

                for(int i = 0; i < arr.Length - 1; i++)
                {
                    for(int j = 0; j < arr[i].Length - 1; i++)
                    {
                        sum[i] += arr[i][j];
                    }
                }
            
            return sum;
        }
    }
}