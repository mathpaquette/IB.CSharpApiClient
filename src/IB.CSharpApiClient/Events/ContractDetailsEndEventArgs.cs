using System;

namespace IB.CSharpApiClient.Events
{
    public class ContractDetailsEndEventArgs : EventArgs
    {
        public ContractDetailsEndEventArgs(int requestId)
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