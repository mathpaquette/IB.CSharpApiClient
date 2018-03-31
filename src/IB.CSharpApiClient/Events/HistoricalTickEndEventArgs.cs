using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalTickEndEventArgs : EventArgs
    {
        public HistoricalTickEndEventArgs(int reqId)
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