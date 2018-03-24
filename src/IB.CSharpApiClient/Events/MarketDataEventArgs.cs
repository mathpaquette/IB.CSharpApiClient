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

        public int RequestId { get; private set; }

        public int Field { get; private set; }
    }
}
