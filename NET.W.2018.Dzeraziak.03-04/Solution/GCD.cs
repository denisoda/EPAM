/**
 * @author [author]
 * @email [example@mail.com]
 * @create date 2018-03-20 07:10:53
 * @modify date 2018-03-20 07:10:53
 * @desc [description]
*/
using System;
using Solution.Extensions;
using System.Diagnostics;

namespace Solution
{
    public class Gcd
    {
        #region Classic Evclid Gcd method
        /// <summary>
        /// Method finds greatest common number with an Evclid's way
        /// </summary>
        /// <returns></returns>
        public static int Evclid(int first, int second)
        {
            Math.Abs(first);
            Math.Abs(second);

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
        #endregion
        #region overloaded Evclid with 3 arguments
        public static int Evclid(int first, int second,int third)
        {
            while(first != second && second != third)
            {
                if(first > second && second > third)
                    first -= second;
                if(second > first && second > third)
                    second -= first;
                if(third > second && second > third)
                    third -= second;
            }
            return first;
        }
        #endregion
        public static int EvclidRecursion(int a, int b)
        {   
            if(b == 0)
                return a;
            return EvclidRecursion(b, a % b);
        }
        /// <summary>
        /// Method finds greatest common number with a Stain's way
        /// </summary>
        /// <returns>Great common value</returns>
        #region BinaryEvclid
        public static int EvclidBin(int a, int b)
        {
            int shift;
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            for (shift = 0; ((a | b) & 1) == 0; ++shift) 
            {
                a >>= 1;
                b >>= 1;
            }
            while ((a & 1) == 0)
                a >>= 1;
                do {
                while ((b & 1) == 0)
                    b >>= 1;
                if (a > b)
                {
                    int t = b;
                    b = a;
                    a = t;
                }
                b = b - a;
            } while (b != 0);
            
            return a << shift;
        }
        #endregion
    }
}
