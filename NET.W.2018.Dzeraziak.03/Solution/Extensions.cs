using System;
using System.Diagnostics;

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
        /// <returns>Binary representation of the number</returns>
        public static string GetBinaryString(this double number)
        => Convert.ToString(BitConverter.DoubleToInt64Bits(number), 2);
        /// <summary>
        /// An exension for Stopwatch class
        /// </summary>
        /// <param name="stopwatch"></param>
        /// <param name="numberofDigits"></param>
        /// <returns></returns>
        public static string GetTimeString(this Stopwatch stopwatch, int numberofDigits = 1)
        {
            double time = stopwatch.ElapsedTicks / (double)Stopwatch.Frequency;
            if (time > 1)
                return Math.Round(time, numberofDigits) + " s";
            if (time > 1e-3)
                return Math.Round(1e3 * time, numberofDigits) + " ms";
            if (time > 1e-6)
                return Math.Round(1e6 * time, numberofDigits) + " µs";
            if (time > 1e-9)
                return Math.Round(1e9 * time, numberofDigits) + " ns";
            return stopwatch.ElapsedTicks + " ticks";
        }
    }
}