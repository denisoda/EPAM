using System;

namespace Generator
{
    /// <summary>
    /// Random array generation class
    /// </summary>
    public static class RandomArray
    {
        private static Random _random = new Random();

        /// <summary>
        /// generates random array of decimal where sum of elements is equal one
        /// </summary>
        /// <param name="elements">number of random elements to generate</param>
        /// <returns>random array of decimal where sum of elements is equal one</returns>
        public static double [] GenerateWithSumOfElementsIsOne(int elements)
        {
            double sum = 1;
            double [] arr = new double [elements];

            for (int i = 0; i < elements - 1; i++)
            {
                arr[i] = RandomHelper.GetRandomNumber(0, sum);
                sum -= arr[i];
            }

            arr[elements - 1] = sum;

            return arr;
        }
    }
}
