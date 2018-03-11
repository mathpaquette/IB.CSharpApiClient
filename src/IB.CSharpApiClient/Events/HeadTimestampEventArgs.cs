using System;

namespace IB.CSharpApiClient.Events
{
    public class HeadTimestampEventArgs : EventArgs
    {
        public int ReqId { get; private set; }
        public string HeadTimestamp { get; private set; }

        public HeadTimestampEventArgs(int reqId, string headTimestamp)
        {
            this.ReqId = reqId;
            this.HeadTimestamp = headTimestamp;
        }
    }
}
