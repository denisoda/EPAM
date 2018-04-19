using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Stopwatch
{
    class Timer
    {
        #region Private fields

        private bool _isRunnig;

        #endregion

        #region Constructors
        
        /// <summary>
        /// Constructor for initilazing
        /// </summary>
        Timer()
        {
        }

        #endregion

        #region Events

        public EventHandler<ElapsedEventArgs> OnTimeElapsed;

        #endregion

        #region Public Methods

        /// <summary>
        /// setting the time for the timer
        /// </summary>
        /// <param name="time"></param>
        /// <param name="notifMessage"></param>
        public void SetTime(TimeSpan time, string notifMessage)
        {
            Invoke(time);
            OnTimeElapsed?.Invoke(this, new ElapsedEventArgs(time, notifMessage));
        }

        #endregion

        #region Privat methods

        public void Invoke(TimeSpan time)
        {
            _isRunnig = true;

            int mileseconds = time.Milliseconds;
            Thread.Sleep(mileseconds);

            _isRunnig = false;
        }

        #endregion
    }
}
