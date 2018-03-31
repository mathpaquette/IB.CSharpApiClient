using System;

namespace IB.CSharpApiClient.Events
{
    public class VerifyCompletedEventArgs : EventArgs
    {
        public VerifyCompletedEventArgs(bool isSuccessful, string errorText)
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