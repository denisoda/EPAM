using System;

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
        => BitConverter.GetBytes(number).ToString();
    }
}