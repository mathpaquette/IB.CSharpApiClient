using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalTickEventArgs : EventArgs
    {
        public int ReqId { get; private set; }
        public long Time { get; private set; }
        public double Price { get; private set; }
        public long Size { get; private set; }

        public HistoricalTickEventArgs(int reqId, long time, double price, long size)
        {
            ReqId = reqId;
            Time = time;
            Price = price;
            Size = size;
        }
    }
}
