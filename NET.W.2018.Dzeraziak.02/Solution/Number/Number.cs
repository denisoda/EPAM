using System;
using System.Collections.Generic;
using Sort.Helper;

namespace Solution.Number
{
    /// <summary>
    /// Number manimpulation class
    /// </summary>
    public static class Number
    {
        /// <summary>
        /// Finds the bigger closest number from the input
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Filtered an int</returns>
        public static int FindNextBiggerNumber(int number)
        {
             if (number < 0)
            {
                throw new ArgumentException($"{nameof(number)} should be possitive num");
            }

            if (number < 11)
            {
                return -1;
            }

            string numberStr = Convert.ToString(number);
            int[] arrDigits = new int[numberStr.Length];

            for (int si = 0; si < numberStr.Length; si++)
            {
                arrDigits[si] = int.Parse(numberStr[si].ToString());
            }

            var hasFound = false;
            var i = 0;
            var indexStartPoint = arrDigits.Length - 1;
            var indexFindNumber = 0;
            while (!hasFound && i < arrDigits.Length - 1)
            {
                for (int k = indexStartPoint; k >= indexStartPoint - i; k--)
                {
                    if (arrDigits[k] <= arrDigits[indexStartPoint - i - 1]) continue;
                    int temp = arrDigits[k];
                    arrDigits[k] = arrDigits[indexStartPoint - i - 1];
                    arrDigits[indexStartPoint - i - 1] = temp;
                    indexFindNumber = indexStartPoint - i;
                    hasFound = true;
                    break;
                }

                i++;
            }

            if (hasFound)
            {
                if (indexFindNumber != arrDigits.Length - 1)
                {
                    SortsHelper.QuickSort(arrDigits, indexFindNumber, arrDigits.Length - 1);
                }

                return Convert.ToInt32(string.Concat(arrDigits));
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Filters input and  which consists this number
        /// </summary>
        /// <param name="list"></param>
        /// <param name="digit"></param>
        /// <returns>an array of filtered nums</returns>
        public static List<int> FilterDigit(IEnumerable<int> list, int digit)
        {
            if (list == null)
            {
                throw new ArgumentNullException($"{nameof(list)} must be not null");
            }

            if (digit < 0 || digit > 9)
            {
                throw new ArgumentException($"{nameof(digit)} must be positive number");
            }

            List<int> result = new List<int>();
            string strDigit = Convert.ToString(digit);

            foreach (var item in list)
            {
                string str = Convert.ToString(item);
                if (str.Contains(strDigit))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        /// <summary>
        /// Finds a power of inputed number wiht Newton's method
        /// </summary>
        /// <param name="number"></param>
        /// <param name="degree"></param>
        /// <param name="precision"></param>
        /// <returns>powered an int</returns>
        public static int FindNthRoot(double number, int degree, double precision)
        {
            return degree;
        }
    }
}