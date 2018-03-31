using System;

namespace IB.CSharpApiClient.Events
{
    public class HeadTimestampEventArgs : EventArgs
    {
        public HeadTimestampEventArgs(int reqId, string headTimestamp)
        {
            ReqId = reqId;
            HeadTimestamp = headTimestamp;
        }

        public int ReqId { get; }
        public string HeadTimestamp { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(HeadTimestamp)}: {HeadTimestamp}";
        }
    }
}