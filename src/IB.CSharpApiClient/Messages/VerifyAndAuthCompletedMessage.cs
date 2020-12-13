namespace IB.CSharpApiClient.Messages
{
    public class VerifyAndAuthCompletedMessage
    {
        public bool IsSuccessful { get; private set; }
        public string ErrorText { get; private set; }

        public VerifyAndAuthCompletedMessage(bool isSuccessful, string errorText)
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