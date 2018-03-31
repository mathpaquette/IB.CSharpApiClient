using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class HistogramDataEventArgs : EventArgs
    {
        public HistogramDataEventArgs(int reqId, HistogramEntry[] data)
        {
            ReqId = reqId;
            Data = data;
        }

        public int ReqId { get; }
        public HistogramEntry[] Data { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Data)}: {Data}";
        }
    }
}