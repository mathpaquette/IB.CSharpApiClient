using System;

namespace IB.CSharpApiClient.Events
{
    public class AccountSummaryEndEventArgs : EventArgs
    {
        public AccountSummaryEndEventArgs(int requestId)
        {
            RequestId = requestId;
        }

        public int RequestId { get; private set; }
    }
}
