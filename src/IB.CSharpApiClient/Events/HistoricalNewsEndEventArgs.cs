using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalNewsEndEventArgs : EventArgs
    {
        public HistoricalNewsEndEventArgs(int requestId, bool hasMore)
        {
            RequestId = requestId;
            HasMore = hasMore;
        }

        public int RequestId { get; }
        public bool HasMore { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(HasMore)}: {HasMore}";
        }
    }
}