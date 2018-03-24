using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalNewsEndEventArgs : EventArgs
    {
        public int RequestId { get; private set; }
        public bool HasMore { get; private set; }

        public HistoricalNewsEndEventArgs(int requestId, bool hasMore)
        {
            this.RequestId = requestId;
            this.HasMore = hasMore;
        }
    }
}
