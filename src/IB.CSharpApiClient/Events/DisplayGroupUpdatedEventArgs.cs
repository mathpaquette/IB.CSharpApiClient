using System;

namespace IB.CSharpApiClient.Events
{
    public class DisplayGroupUpdatedEventArgs : EventArgs
    {
        public int ReqId { get; }
        public string ContractInfo { get; }

        public DisplayGroupUpdatedEventArgs(int reqId, string contractInfo)
        {
            ReqId = reqId;
            ContractInfo = contractInfo;
        }
    }
}