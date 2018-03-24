using System;

namespace IB.CSharpApiClient.Events
{
    public class ContractDetailsEndEventArgs : EventArgs
    {
        public int RequestId { get; private set; }

        public ContractDetailsEndEventArgs(int requestId)
        {
            RequestId = requestId;
        }
    }
}
