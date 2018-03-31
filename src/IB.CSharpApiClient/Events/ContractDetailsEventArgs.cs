using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class ContractDetailsEventArgs : EventArgs
    {
        public ContractDetailsEventArgs(int requestId, ContractDetails contractDetails)
        {
            RequestId = requestId;
            ContractDetails = contractDetails;
        }

        public int RequestId { get; }
        public ContractDetails ContractDetails { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(ContractDetails)}: {ContractDetails}";
        }
    }
}