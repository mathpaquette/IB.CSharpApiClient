using System;

namespace IB.CSharpApiClient
{
    public class IBClientException : Exception
    {
        public int RequestId { get; private set; }
        public int ErrorCode { get; private set; }
        public string AdvancedOrderRejectJson { get; private set; }
        public Exception Exception { get; private set; }

        public IBClientException(int requestId, int errorCode, string message, string advancedOrderRejectJson): base(message)
        {
            RequestId = requestId;
            ErrorCode = errorCode;
            AdvancedOrderRejectJson = advancedOrderRejectJson;
        }

        public IBClientException(string err) : base(err) { }

        public IBClientException(Exception e)
        {
            Exception = e;
        }
    }
}