namespace IB.CSharpApiClient.Messages
{
    public class RerouteMktDataReqMessage
    {
        public int ReqId { get; private set; }
        public int ConId { get; private set; }
        public string Exchange { get; private set; }

        public RerouteMktDataReqMessage(int reqId, int conId, string exchange)
        {
            ReqId = reqId;
            ConId = conId;
            Exchange = exchange;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(ConId)}: {ConId}, {nameof(Exchange)}: {Exchange}";
        }
    }
}