using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class SymbolSamplesEventArgs : EventArgs
    {
        public int ReqId { get; private set; }
        public ContractDescription[] ContractDescriptions { get; private set; }

        public SymbolSamplesEventArgs(int reqId, ContractDescription[] contractDescriptions)
        {
            this.ReqId = reqId;
            this.ContractDescriptions = contractDescriptions;
        }
    }
}
