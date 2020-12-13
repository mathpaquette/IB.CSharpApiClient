using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class HistoricalDataUpdateMessage
    {
        public int ReqId { get; private set; }
        public Bar Bar { get; private set; }

        public HistoricalDataUpdateMessage(int reqId, Bar bar)
        {
            ReqId = reqId;
            Bar = bar;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Bar)}: {Bar}";
        }
    }
}