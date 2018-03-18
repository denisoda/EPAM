using System;

namespace Solution.Extensions
{
    public static class Extensions
    {
        public static string GetBinaryString(this double number){ 
            var a = Convert.ToString(BitConverter.DoubleToInt64Bits(number), 2);
            return BitConverter.GetBytes(number).ToString();
            }
    }
}