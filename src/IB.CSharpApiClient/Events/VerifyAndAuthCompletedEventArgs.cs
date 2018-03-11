using System;

namespace IB.CSharpApiClient.Events
{
    public class VerifyAndAuthCompletedEventArgs : EventArgs
    {
        public bool IsSuccessful { get; }
        public string ErrorText { get; }

        public VerifyAndAuthCompletedEventArgs(bool isSuccessful, string errorText)
        {
            IsSuccessful = isSuccessful;
            ErrorText = errorText;
        }
    }
}