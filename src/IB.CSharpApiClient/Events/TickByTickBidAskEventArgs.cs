using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class TickByTickBidAskEventArgs : EventArgs
    {
        public TickByTickBidAskEventArgs(int reqId, long time, double bidPrice, double askPrice, long bidSize, long askSize, TickAttrib attribs)
        {
            ReqId = reqId;
            Time = time;
            BidPrice = bidPrice;
            AskPrice = askPrice;
            BidSize = bidSize;
            AskSize = askSize;
            Attribs = attribs;
        }

        public int ReqId { get; private set; }
        public long Time { get; private set; }
        public double BidPrice { get; private set; }
        public double AskPrice { get; private set; }
        public long BidSize { get; private set; }
        public long AskSize { get; private set; }
        public TickAttrib Attribs { get; private set; }
    }
}
