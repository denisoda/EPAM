using System;

namespace Generator
{
    public static class RandomHelper
    {
        /// <summary>
        /// method helper for acquiring double in a predifined range
        /// </summary>
        /// <param name="minimum">element begins from</param>
        /// <param name="maximum">element ends from</param>
        /// <returns>pseudo random value</returns>
        public static double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}