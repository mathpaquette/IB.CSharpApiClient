using System;

namespace IB.CSharpApiClient.Events
{
    public class VerifyCompletedEventArgs : EventArgs
    {
        public bool IsSuccessful { get; private set; }
        public string ErrorText { get; private set; }

        public VerifyCompletedEventArgs(bool isSuccessful, string errorText)
        {
            IsSuccessful = isSuccessful;
            ErrorText = errorText;
        }
    }
}