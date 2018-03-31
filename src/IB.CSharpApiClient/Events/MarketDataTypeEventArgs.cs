using System;

namespace IB.CSharpApiClient.Events
{
    public class MarketDataTypeEventArgs : EventArgs
    {
        public MarketDataTypeEventArgs(int requestId, int marketDataType)
        {
            RequestId = requestId;
            MarketDataType = marketDataType;
        }

        public int RequestId { get; }
        public int MarketDataType { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(MarketDataType)}: {MarketDataType}";
        }
    }
}