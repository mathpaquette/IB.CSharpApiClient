using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class HistoricalTicksBidAskMessage
    {
        public int ReqId { get; private set; }
        public HistoricalTickBidAsk[] Ticks { get; private set; }
        public bool Done { get; private set; }

        public HistoricalTicksBidAskMessage(int reqId, HistoricalTickBidAsk[] ticks, bool done)
        {
            ReqId = reqId;
            Ticks = ticks;
            Done = done;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Ticks)}: {Ticks}, {nameof(Done)}: {Done}";
        }
    }
}
