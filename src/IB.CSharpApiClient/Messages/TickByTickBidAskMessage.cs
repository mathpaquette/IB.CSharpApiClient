using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class TickByTickBidAskMessage
    {
        public int ReqId { get; private set; }
        public long Time { get; private set; }
        public double BidPrice { get; private set; }
        public double AskPrice { get; private set; }
        public decimal BidSize { get; private set; }
        public decimal AskSize { get; private set; }
        public TickAttribBidAsk TickAttribBidAsk { get; private set; }

        public TickByTickBidAskMessage(int reqId, long time, double bidPrice, double askPrice, decimal bidSize, decimal askSize, TickAttribBidAsk tickAttribBidAsk)
        {
            ReqId = reqId;
            Time = time;
            BidPrice = bidPrice;
            AskPrice = askPrice;
            BidSize = bidSize;
            AskSize = askSize;
            TickAttribBidAsk = tickAttribBidAsk;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Time)}: {Time}, {nameof(BidPrice)}: {BidPrice}, {nameof(AskPrice)}: {AskPrice}, {nameof(BidSize)}: {BidSize}, {nameof(AskSize)}: {AskSize}, {nameof(TickAttribBidAsk)}: {TickAttribBidAsk}";
        }
    }
}
