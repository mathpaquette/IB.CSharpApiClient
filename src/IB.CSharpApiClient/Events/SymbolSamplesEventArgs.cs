using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class SymbolSamplesEventArgs : EventArgs
    {
        public SymbolSamplesEventArgs(int reqId, ContractDescription[] contractDescriptions)
        {
            ReqId = reqId;
            ContractDescriptions = contractDescriptions;
        }

        public int ReqId { get; }
        public ContractDescription[] ContractDescriptions { get; }

        public override string ToString()
        {
            return $"{nameof(ContractDescriptions)}: {ContractDescriptions}, {nameof(ReqId)}: {ReqId}";
        }
    }
}