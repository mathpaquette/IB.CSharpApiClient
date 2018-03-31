using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalTickEventArgs : EventArgs
    {
        public HistoricalTickEventArgs(int reqId, long time, double price, long size)
        {
            ReqId = reqId;
            Time = time;
            Price = price;
            Size = size;
        }

        public int ReqId { get; }
        public long Time { get; }
        public double Price { get; }
        public long Size { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Time)}: {Time}, {nameof(Price)}: {Price}, {nameof(Size)}: {Size}";
        }
    }
}