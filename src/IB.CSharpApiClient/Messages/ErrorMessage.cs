using System;

namespace IB.CSharpApiClient.Messages
{
    public class ErrorMessage
    {
        public int RequestId { get; private set; }
        public int ErrorCode { get; private set; }
        public string Message { get; private set; }
        public string AdvancedOrderRejectJson { get; private set; }
        public Exception Exception { get; private set; }

        public ErrorMessage(int requestId, int errorCode, string message, string advancedOrderRejectJson)
        {
            Message = message;
            RequestId = requestId;
            ErrorCode = errorCode;
            AdvancedOrderRejectJson = advancedOrderRejectJson;
        }

        public ErrorMessage(Exception e)
        {
            Exception = e;
        }

        public ErrorMessage(string err)
        {
            Message = err;
        }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(ErrorCode)}: {ErrorCode}, {nameof(Message)}: {Message}, {nameof(AdvancedOrderRejectJson)}: {AdvancedOrderRejectJson}, {nameof(Exception)}: {Exception}";
        }
    }
}
