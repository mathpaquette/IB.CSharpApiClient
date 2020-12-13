namespace IB.CSharpApiClient.Messages
{
    public class HeadTimestampMessage
    {
        public int ReqId { get; private set; }
        public string HeadTimestamp { get; private set; }

        public HeadTimestampMessage(int reqId, string headTimestamp)
        {
            ReqId = reqId;
            HeadTimestamp = headTimestamp;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(HeadTimestamp)}: {HeadTimestamp}";
        }
    }
}
