using System;

namespace IB.CSharpApiClient.Events
{
    public class FundamentalsEventArgs : EventArgs
    {
        public FundamentalsEventArgs(int requestId, string data)
        {
            RequestId = requestId;
            Data = data;
        }

        public int RequestId { get; }
        public string Data { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(Data)}: {Data}";
        }
    }
}