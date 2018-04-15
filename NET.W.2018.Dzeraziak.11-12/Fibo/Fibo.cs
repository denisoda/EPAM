using System;
using System.Collections;

namespace Fibo
{
    public static class Fibo 
    {
        /// <summary>
        /// Fibo numbers generator
        /// </summary>
        /// <param name="number">Number of numbers to generate</param>
        /// <returns>Sequence of the fibo numbers</returns>
        public static IEnumerable Generate(int number)
        {
            int first = -1;
            int second = 1;
            
            for(int i = 0; i < number; i++)
            {
                int temp = first + second;
                first = second;
                second = temp;

                yield return temp;
            }
        }
    }
}
