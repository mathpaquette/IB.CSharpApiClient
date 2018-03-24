using System;

namespace IB.CSharpApiClient.Events
{
    public class ExecutionEndEventArgs : EventArgs
    {
        public int RequestId { get; private set; }

        public ExecutionEndEventArgs(int requestId)
        {
            RequestId = requestId;
        }
    }
}