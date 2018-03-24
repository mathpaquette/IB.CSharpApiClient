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

        public int RequestId { get; private set; }

        public int MarketDataType { get; private set; }
    }
}
