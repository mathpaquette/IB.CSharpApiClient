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

        public ContractDetails ContractDetails { get; private set; }

        public int RequestId { get; private set; }
    }
}
