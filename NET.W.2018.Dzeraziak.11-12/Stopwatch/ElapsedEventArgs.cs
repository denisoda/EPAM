using System;
using System.Collections.Generic;
using System.Text;

namespace Stopwatch
{
    internal class ElapsedEventArgs
    {
        public readonly TimeSpan Time;
        public readonly string NotifMessage;

        public ElapsedEventArgs(TimeSpan time, string notifMessage)
        {
            NotifMessage = notifMessage;
            Time = time;
        }
    }
}
