namespace IB.CSharpApiClient.Messages
{
    public class AccountUpdateMultiMessage 
    {
        public int ReqId { get; private set; }
        public string Account { get; private set; }
        public string ModelCode { get; private set; }
        public string Key { get; private set; }
        public string Value { get; private set; }
        public string Currency { get; private set; }

        public AccountUpdateMultiMessage(int reqId, string account, string modelCode, string key, string value, string currency)
        {
            Account = account;
            ModelCode = modelCode;
            Key = key;
            Value = value;
            Currency = currency;
        }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Account)}: {Account}, {nameof(ModelCode)}: {ModelCode}, {nameof(Key)}: {Key}, {nameof(Value)}: {Value}, {nameof(Currency)}: {Currency}";
        }
    }
}
