using System;
using System.Diagnostics;
using System.Timers;

namespace Dzeraziak.Stopwatch
{
    public class Watch
    {
        private readonly Timer _timer;
        public event ElapsedEventHandler TimeElapset = _timer.Elapsed;

        public Watch(double seconds)
        {
            Console.WriteLine("Created");
            _timer = new Timer(seconds);
        }

        /// <summary>
        /// Invokes the timer and rises an event afrer reaching the predefined time
        /// </summary>
        private void OnElpaset(object sender, ElapsedEventArgs a)
        {
            System.Console.WriteLine("Iner elapsed");
            TimeElapset?.Invoke(this, a);
        }
    }
}