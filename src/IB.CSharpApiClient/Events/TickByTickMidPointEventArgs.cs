using System;

namespace IB.CSharpApiClient.Events
{
    public class TickByTickMidPointEventArgs : EventArgs
    {
        public TickByTickMidPointEventArgs(int reqId, long time, double midPoint)
        {
            ReqId = reqId;
            Time = time;
            MidPoint = midPoint;
        }

        public int ReqId { get; private set; }
        public long Time { get; private set; }
        public double MidPoint { get; private set; }
    }
}
