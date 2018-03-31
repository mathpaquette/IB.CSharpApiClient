using System;

namespace IB.CSharpApiClient.Events
{
    public class ExecutionEndEventArgs : EventArgs
    {
        public ExecutionEndEventArgs(int requestId)
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