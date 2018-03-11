using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalTickBidAskEndEventArgs : EventArgs
    {
        public int ReqId { get; private set; }

        public HistoricalTickBidAskEndEventArgs(int reqId)
        {
            ReqId = reqId;
        }
    }
}
