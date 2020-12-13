namespace IB.CSharpApiClient.Messages
{
    public class MarketDataTypeMessage
    {
        public int RequestId { get; private set; }
        public int MarketDataType { get; private set; }

        public MarketDataTypeMessage(int requestId, int marketDataType)
        {
            RequestId = requestId;
            MarketDataType = marketDataType;
        }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(MarketDataType)}: {MarketDataType}";
        }
    }
}
