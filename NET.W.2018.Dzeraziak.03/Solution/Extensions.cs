using System;
using System.Diagnostics;
using System.Collections;
using System.Text;

namespace Solution.Extensions
{
    /// <summary>
    /// Extensions methods for the "Solution" namespace
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Converts to the binary string
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Binary representation of the double number</returns>
        public static string GetBinaryString(this double number)
        {
            var bitArray = new BitArray(BitConverter.GetBytes(number));

            var res = new StringBuilder(64);

            for(int i = bitArray.Length - 1; i >= 0; i--)
            {
                if(bitArray[i] == false)
                    res.Append('0');
                else
                    res.Append('1');
            }

            return res.ToString();
        }

        /// <summary>
        /// Gets the time for executing a method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="method"></param>
        /// <returns></returns>
        public static Stopwatch GetExecutionTime<T>(Func<T> method)
        {
            var sw = new Stopwatch();
            sw.Start();
            method.Invoke();
            sw.Stop();
            return sw;
        }
    }
}