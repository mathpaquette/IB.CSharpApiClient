using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalTickBidAskEventArgs : EventArgs
    {
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

        public int ReqId { get; }
        public long Time { get; }
        public int Mask { get; }
        public double PriceBid { get; }
        public double PriceAsk { get; }
        public long SizeBid { get; }
        public long SizeAsk { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Time)}: {Time}, {nameof(Mask)}: {Mask}, {nameof(PriceBid)}: {PriceBid}, {nameof(PriceAsk)}: {PriceAsk}, {nameof(SizeBid)}: {SizeBid}, {nameof(SizeAsk)}: {SizeAsk}";
        }
    }
}