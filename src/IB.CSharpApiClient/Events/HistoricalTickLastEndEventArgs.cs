using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalTickLastEndEventArgs : EventArgs
    {
        public int ReqId { get; private set; }

        public HistoricalTickLastEndEventArgs(int reqId)
        {
            ReqId = reqId;
        }
    }
}
