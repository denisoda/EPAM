using System;

namespace Stopwatch
{
    public class Timer
    {
        public event EventHandler OnTimeEndEvent; 
        
        public void Start()
        {
            //Timer begins execution
        }

        public void End()
        {
        //Timer ends exution
            if(OnTimeEndEvent != null)
                OnTimeEndEvent(this, EventArgs.Empty);
        }
    }
}
