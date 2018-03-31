using System;

namespace IB.CSharpApiClient.Events
{
    public class ErrorEventArgs : EventArgs
    {
        public ErrorEventArgs(int requestId, int errorCode, string message)
        {
            RequestId = requestId;
            ErrorCode = errorCode;
            Message = message;
        }

        public ErrorEventArgs(Exception exception)
        {
            Exception = exception;
        }

        public ErrorEventArgs(string message)
        {
            Message = message;
        }

        public int RequestId { get; }
        public int ErrorCode { get; }
        public string Message { get; }
        public Exception Exception { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(ErrorCode)}: {ErrorCode}, {nameof(Message)}: {Message}, {nameof(Exception)}: {Exception}";
        }
    }
}