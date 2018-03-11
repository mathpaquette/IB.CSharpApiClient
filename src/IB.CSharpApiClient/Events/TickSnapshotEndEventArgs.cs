using System;

namespace IB.CSharpApiClient.Events
{
    public class TickSnapshotEndEventArgs : EventArgs
    {
        public int RequestId { get; }

        public TickSnapshotEndEventArgs(int requestId)
        {
            RequestId = requestId;
        }
    }
}