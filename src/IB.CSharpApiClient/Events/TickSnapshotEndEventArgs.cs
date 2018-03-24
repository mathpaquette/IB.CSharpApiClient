using System;

namespace IB.CSharpApiClient.Events
{
    public class TickSnapshotEndEventArgs : EventArgs
    {
        public int RequestId { get; private set; }

        public TickSnapshotEndEventArgs(int requestId)
        {
            RequestId = requestId;
        }
    }
}