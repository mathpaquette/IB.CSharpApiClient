using System;

namespace IB.CSharpApiClient.Events
{
    public class ExecutionEndEventArgs : EventArgs
    {
        public int RequestId { get; }

        public ExecutionEndEventArgs(int requestId)
        {
            RequestId = requestId;
        }
    }
}