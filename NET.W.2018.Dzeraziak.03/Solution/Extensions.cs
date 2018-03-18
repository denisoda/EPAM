using System;

namespace Solution.Extensions
{
    public static class Extensions
    {
        /// <summary>
        /// Converts to the binary string
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Binary representation of the number</returns>
        public static string GetBinaryString(this double number){ 
            var a = Convert.ToString(BitConverter.DoubleToInt64Bits(number), 2);
            return BitConverter.GetBytes(number).ToString();
            }
    }
}