namespace IB.CSharpApiClient.Messages
{
    public class HistoricalTickBidAskEndMessage
    {
        public int ReqId { get; private set; }

        public HistoricalTickBidAskEndMessage(int reqId)
        {
            ReqId = reqId;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}";
        }
    }
}
