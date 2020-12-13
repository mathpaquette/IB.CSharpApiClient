using System;

namespace IB.CSharpApiClient.Messages
{
    public class ErrorMessage
    {
        public string Message { get; private set; }
        public int ErrorCode { get; private set; }
        public int RequestId { get; private set; }
        public Exception Exception { get; private set; }

        public ErrorMessage(int requestId, int errorCode, string message)
        {
            Message = message;
            RequestId = requestId;
            ErrorCode = errorCode;
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
            return $"{nameof(Message)}: {Message}, {nameof(ErrorCode)}: {ErrorCode}, {nameof(RequestId)}: {RequestId}, {nameof(Exception)}: {Exception}";
        }
    }
}
