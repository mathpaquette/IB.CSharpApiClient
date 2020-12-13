namespace IB.CSharpApiClient.Messages
{
    public class HistoricalNewsEndMessage
    {
        public int RequestId { get; private set; }
        public bool HasMore { get; private set; }

        public HistoricalNewsEndMessage(int requestId, bool hasMore)
        {
            RequestId = requestId;
            HasMore = hasMore;
        }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(HasMore)}: {HasMore}";
        }
    }
}
