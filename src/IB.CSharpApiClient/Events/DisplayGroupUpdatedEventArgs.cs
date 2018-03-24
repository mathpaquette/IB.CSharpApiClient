using System;

namespace IB.CSharpApiClient.Events
{
    public class DisplayGroupUpdatedEventArgs : EventArgs
    {
        public int ReqId { get; private set; }
        public string ContractInfo { get; private set; }

        public DisplayGroupUpdatedEventArgs(int reqId, string contractInfo)
        {
            ReqId = reqId;
            ContractInfo = contractInfo;
        }
    }
}