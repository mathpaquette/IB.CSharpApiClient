using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalTickEndEventArgs : EventArgs
    {
        public int ReqId { get; private set; }

        public HistoricalTickEndEventArgs(int reqId)
        {
            ReqId = reqId;
        }
    }
}
