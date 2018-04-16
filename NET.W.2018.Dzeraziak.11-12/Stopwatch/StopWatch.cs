using System;
using System.Diagnostics;
using System.Timers;

namespace Dzeraziak.Stopwatch
{
    public class Watch
    {
        private Timer timer;
        public event ElapsedEventHandler TimeElapset;


        public Watch(double seconds)
        {
            timer = new Timer(seconds);

            timer.Elapsed += onElpaset;
        }
        /// <summary>
        /// Invokes the timer and rises an event afrer reaching the predefined time
        /// </summary>
        /// <param name="seconds">Numer to seconds to countdown</param>
        

        private void onElpaset(object sender, ElapsedEventArgs a)
        {
            System.Console.WriteLine("Iner elapsed");
            TimeElapset(this, a);
        }
    }
}
