using System;

namespace IB.CSharpApiClient.Events
{
    public class VerifyAndAuthCompletedEventArgs : EventArgs
    {
        public VerifyAndAuthCompletedEventArgs(bool isSuccessful, string errorText)
        {
            IsSuccessful = isSuccessful;
            ErrorText = errorText;
        }

        public bool IsSuccessful { get; }
        public string ErrorText { get; }

        public override string ToString()
        {
            return $"{nameof(ErrorText)}: {ErrorText}, {nameof(IsSuccessful)}: {IsSuccessful}";
        }
    }
}