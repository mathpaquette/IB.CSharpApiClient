using System;

namespace IB.CSharpApiClient.Events
{
    public class ErrorEventArgs : EventArgs
    {
        public ErrorEventArgs(int requestId, int errorCode, string message)
        {
            Message = message;
            RequestId = requestId;
            ErrorCode = errorCode;
        }

        public ErrorEventArgs(Exception exception)
        {
            Exception = exception;
        }

        public ErrorEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; }

        public int ErrorCode { get; }

        public int RequestId { get; }

        public Exception Exception { get; }

        public override string ToString()
        {
            return "Error. Request: " + RequestId + ", Code: " + ErrorCode + " - " + Message;
        }
    }
}
