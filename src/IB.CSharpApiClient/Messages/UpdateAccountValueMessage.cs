namespace IB.CSharpApiClient.Messages
{
    public class UpdateAccountValueMessage
    {
        public string Key { get; private set; }
        public string Value { get; private set; }
        public string Currency { get; private set; }
        public string AccountName { get; private set; }

        public UpdateAccountValueMessage(string key, string value, string currency, string accountName)
        {
            Key = key;
            Value = value;
            Currency = currency;
            AccountName = accountName;
        }

        public override string ToString()
        {
            return $"{nameof(Key)}: {Key}, {nameof(Value)}: {Value}, {nameof(Currency)}: {Currency}, {nameof(AccountName)}: {AccountName}";
        }
    }
}