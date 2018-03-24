using System;

namespace IB.CSharpApiClient.Events
{
    public class FundamentalsEventArgs : EventArgs
    {
        public int RequestId { get; private set; }
        public string Data { get; private set; }

        public FundamentalsEventArgs(int requestId, string data)
        {
            RequestId = requestId;
            Data = data;
        }
    }
}
