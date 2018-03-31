using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class BondContractDetailsEventArgs : EventArgs
    {
        public BondContractDetailsEventArgs(int requestId, ContractDetails contractDetails)
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