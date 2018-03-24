using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalTickBidAskEventArgs : EventArgs
    {
        public int ReqId { get; private set; }
        public long Time { get; private set; }
        public int Mask { get; private set; }
        public double PriceBid { get; private set; }
        public double PriceAsk { get; private set; }
        public long SizeBid { get; private set; }
        public long SizeAsk { get; private set; }

        public HistoricalTickBidAskEventArgs(int reqId, long time, int mask, double priceBid, double priceAsk, long sizeBid, long sizeAsk)
        {
            ReqId = reqId;
            Time = time;
            Mask = mask;
            PriceBid = priceBid;
            PriceAsk = priceAsk;
            SizeBid = sizeBid;
            SizeAsk = sizeAsk;
        }
    }
}
