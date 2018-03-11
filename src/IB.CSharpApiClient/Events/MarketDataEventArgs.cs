using System;

namespace IB.CSharpApiClient.Events
{
    public abstract class MarketDataEventArgs : EventArgs
    {
        protected MarketDataEventArgs(int requestId, int field)
        {
            RequestId = requestId;
            Field = field;
        }

        public int RequestId { get; }

        public int Field { get; }
    }
}
