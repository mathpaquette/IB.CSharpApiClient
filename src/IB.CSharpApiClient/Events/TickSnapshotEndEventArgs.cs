using System;

namespace IB.CSharpApiClient.Events
{
    public class TickSnapshotEndEventArgs : EventArgs
    {
        public TickSnapshotEndEventArgs(int requestId)
        {
            RequestId = requestId;
        }

        public int RequestId { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}";
        }
    }
}