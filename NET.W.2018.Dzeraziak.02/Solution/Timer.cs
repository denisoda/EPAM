namespace Solution.Timer
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Timer for executing tinme calculation
    /// </summary>
    public class Timer
    {
        /// <summary>
        /// Timer for calcuting "FindNextBiggerNmber" method executing time"
        /// </summary>
        /// <param name="initialNumber">Number.</param>
        /// <returns>Object</returns>
        public static Stopwatch GetLeadTimeFindNextBiggerNumber(int number)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Number.Number.FindNextBiggerNumber(number);
            timer.Stop();
            return timer;
        }
    }
}