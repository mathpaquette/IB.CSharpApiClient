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

        public int ReqId { get; }
        public long Time { get; }
        public double MidPoint { get; }

        public override string ToString()
        {
            return $"{nameof(MidPoint)}: {MidPoint}, {nameof(ReqId)}: {ReqId}, {nameof(Time)}: {Time}";
        }
    }
}