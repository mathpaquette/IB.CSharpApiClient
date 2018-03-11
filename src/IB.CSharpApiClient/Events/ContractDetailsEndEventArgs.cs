using System;

namespace IB.CSharpApiClient.Events
{
    public class ContractDetailsEndEventArgs : EventArgs
    {
        public int RequestId { get; }

        public ContractDetailsEndEventArgs(int requestId)
        {
            RequestId = requestId;
        }
    }
}
