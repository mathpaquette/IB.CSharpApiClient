namespace IB.CSharpApiClient.Messages
{
    public class VerifyCompletedMessage
    {
        public bool IsSuccessful { get; private set; }
        public string ErrorText { get; private set; }

        public VerifyCompletedMessage(bool isSuccessful, string errorText)
        {
            IsSuccessful = isSuccessful;
            ErrorText = errorText;
        }

        public override string ToString()
        {
            return $"{nameof(IsSuccessful)}: {IsSuccessful}, {nameof(ErrorText)}: {ErrorText}";
        }
    }
}