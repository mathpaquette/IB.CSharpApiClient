using System;

namespace IB.CSharpApiClient.Events
{
    public class VerifyCompletedEventArgs : EventArgs
    {
        public bool IsSuccessful { get; }
        public string ErrorText { get; }

        public VerifyCompletedEventArgs(bool isSuccessful, string errorText)
        {
            IsSuccessful = isSuccessful;
            ErrorText = errorText;
        }
    }
}