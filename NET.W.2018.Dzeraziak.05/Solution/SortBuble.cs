using System;

namespace Solution
{
    public class SortBuble
    {
        static int [][]Sort(int[][] arr)
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