using System;
using System.Diagnostics;
using System.Timers;

namespace Dzeraziak.Stopwatch
{
    public class Watch
    {
        private Timer timer;
        public event EventHandler TimeElapset;

        public Watch()
        {
        }
        /// <summary>
        /// Invokes the timer and rises an event afrer reaching the predefined time
        /// </summary>
        /// <param name="seconds">Numer to seconds to countdown</param>
        public void StartTimer(double seconds)
        {
            timer = new Timer(seconds);

            timer.Elapsed += new ElapsedEventHandler(onElpaset);
        }

        private void onElpaset(object sender, ElapsedEventArgs a)
        {
            TimeElapset(this, EventArgs.Empty);
        }
    }
}
