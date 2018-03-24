using System;

namespace IB.CSharpApiClient.Events
{
    public class TimeEventArgs : EventArgs
    {
        public TimeEventArgs(long time)
        {
            CurrentTime = time;
        }

        public long CurrentTime { get; private set; }
    }
}