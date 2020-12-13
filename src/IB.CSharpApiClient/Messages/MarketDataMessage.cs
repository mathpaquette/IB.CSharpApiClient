namespace IB.CSharpApiClient.Messages
{
    public abstract class MarketDataMessage
    {
        public int RequestId { get; private set; }
        public int Field { get; private set; }

        protected MarketDataMessage(int requestId, int field)
        {
            RequestId = requestId;
            Field = field;
        }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(Field)}: {Field}";
        }
    }
}
