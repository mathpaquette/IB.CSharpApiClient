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

        public string Message { get; private set; }

        public int ErrorCode { get; private set; }

        public int RequestId { get; private set; }

        public Exception Exception { get; private set; }

        public override string ToString()
        {
            return "Error. Request: " + RequestId + ", Code: " + ErrorCode + " - " + Message;
        }
    }
}
