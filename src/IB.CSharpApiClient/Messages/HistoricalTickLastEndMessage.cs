namespace IB.CSharpApiClient.Messages
{
    public class HistoricalTickLastEndMessage
    {
        public int ReqId { get; private set; }

        public HistoricalTickLastEndMessage(int reqId)
        {
            ReqId = reqId;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}";
        }
    }
}
