using System;

namespace IB.CSharpApiClient.Events
{
    public class FundamentalsEventArgs : EventArgs
    {
        public int RequestId { get; }
        public string Data { get; }

        public FundamentalsEventArgs(int requestId, string data)
        {
            RequestId = requestId;
            Data = data;
        }
    }
}
