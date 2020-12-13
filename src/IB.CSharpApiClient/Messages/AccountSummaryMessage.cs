namespace IB.CSharpApiClient.Messages
{
    public class AccountSummaryMessage
    {
        public int RequestId { get; private set; }
        public string Account { get; private set; }
        public string Tag { get; private set; }
        public string Value { get; private set; }
        public string Currency { get; private set; }

        public AccountSummaryMessage(int requestId, string account, string tag, string value, string currency)
        {
            RequestId = requestId;
            Account = account;
            Tag = tag;
            Value = value;
            Currency = currency;
        }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(Account)}: {Account}, {nameof(Tag)}: {Tag}, {nameof(Value)}: {Value}, {nameof(Currency)}: {Currency}";
        }
    }
}
