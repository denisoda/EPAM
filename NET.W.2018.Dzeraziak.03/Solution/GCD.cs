using System;

namespace Solution
{
    public class GCD
    {
        /// <summary>
        /// Method finds greatest common number with an Evclid's way
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        public static int FindEvclidGCD(int first, int second)
        {
            while (first != second) 
            {
                if (first > second)
                {
                    first = first - second;
                } else 
                {
                    second = second - first;
                }
	        }
            return first;
        }
        /// <summary>
        /// Method finds greatest common number with a Stain's way
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        public static int FindStainGCD(int Number)
        {
            return 0;
        }
    }
}
