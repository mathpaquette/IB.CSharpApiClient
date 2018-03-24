using System;

namespace IB.CSharpApiClient.Events
{
    public class VerifyAndAuthCompletedEventArgs : EventArgs
    {
        public bool IsSuccessful { get; private set; }
        public string ErrorText { get; private set; }

        public VerifyAndAuthCompletedEventArgs(bool isSuccessful, string errorText)
        {
            IsSuccessful = isSuccessful;
            ErrorText = errorText;
        }
    }
}