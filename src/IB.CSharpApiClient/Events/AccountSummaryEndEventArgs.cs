using System;

namespace IB.CSharpApiClient.Events
{
    public class AccountSummaryEndEventArgs : EventArgs
    {
        public AccountSummaryEndEventArgs(int requestId)
        {
            RequestId = requestId;
        }

        public int RequestId { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}";
        }
    }
}