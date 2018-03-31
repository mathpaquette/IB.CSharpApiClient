using System;

namespace IB.CSharpApiClient.Events
{
    public class DisplayGroupUpdatedEventArgs : EventArgs
    {
        public DisplayGroupUpdatedEventArgs(int reqId, string contractInfo)
        {
            ReqId = reqId;
            ContractInfo = contractInfo;
        }

        public int ReqId { get; }
        public string ContractInfo { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(ContractInfo)}: {ContractInfo}";
        }
    }
}