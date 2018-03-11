using System;

namespace IB.CSharpApiClient.Events
{
    public class HistogramDataEventArgs : EventArgs
    {
        public int ReqId { get; private set; }
        public IBApi.HistogramEntry[] Data { get; private set; }

        public HistogramDataEventArgs(int reqId, IBApi.HistogramEntry[] data)
        {
            ReqId = reqId;
            Data = data;
        }
    }
}
