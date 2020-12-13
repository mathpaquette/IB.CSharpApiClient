namespace IB.CSharpApiClient.Messages
{
    public class TickByTickMidPointMessage
    {
        public int ReqId { get; private set; }
        public long Time { get; private set; }
        public double MidPoint { get; private set; }

        public TickByTickMidPointMessage(int reqId, long time, double midPoint)
        {
            ReqId = reqId;
            Time = time;
            MidPoint = midPoint;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Time)}: {Time}, {nameof(MidPoint)}: {MidPoint}";
        }
    }
}
