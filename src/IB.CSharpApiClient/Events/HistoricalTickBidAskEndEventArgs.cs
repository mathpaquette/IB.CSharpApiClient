using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalTickBidAskEndEventArgs : EventArgs
    {
        public HistoricalTickBidAskEndEventArgs(int reqId)
        {
            ReqId = reqId;
        }

        public int ReqId { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}";
        }
    }
}