using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class TickByTickBidAskEventArgs : EventArgs
    {
        public TickByTickBidAskEventArgs(int reqId, long time, double bidPrice, double askPrice, long bidSize,
            long askSize, TickAttrib attribs)
        {
            ReqId = reqId;
            Time = time;
            BidPrice = bidPrice;
            AskPrice = askPrice;
            BidSize = bidSize;
            AskSize = askSize;
            Attribs = attribs;
        }

        public int ReqId { get; }
        public long Time { get; }
        public double BidPrice { get; }
        public double AskPrice { get; }
        public long BidSize { get; }
        public long AskSize { get; }
        public TickAttrib Attribs { get; }

        public override string ToString()
        {
            return $"{nameof(AskPrice)}: {AskPrice}, {nameof(AskSize)}: {AskSize}, {nameof(Attribs)}: {Attribs}, {nameof(BidPrice)}: {BidPrice}, {nameof(BidSize)}: {BidSize}, {nameof(ReqId)}: {ReqId}, {nameof(Time)}: {Time}";
        }
    }
}