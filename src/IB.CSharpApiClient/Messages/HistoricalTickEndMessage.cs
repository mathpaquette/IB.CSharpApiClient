namespace IB.CSharpApiClient.Messages
{
    public class HistoricalTickEndMessage
    {
        public int ReqId { get; private set; }

        public HistoricalTickEndMessage(int reqId)
        {
            ReqId = reqId;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}";
        }
    }
}
