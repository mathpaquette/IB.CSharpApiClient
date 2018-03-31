using System;

namespace IB.CSharpApiClient.Events
{
    public class AccountUpdateMultiEventArgs : EventArgs
    {
        public AccountUpdateMultiEventArgs(int reqId, string account, string modelCode, string key, string value,
            string currency)
        {
            ReqId = reqId;
            Account = account;
            ModelCode = modelCode;
            Key = key;
            Value = value;
            Currency = currency;
        }

        public int ReqId { get; }
        public string Account { get; }
        public string ModelCode { get; }
        public string Key { get; }
        public string Value { get; }
        public string Currency { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Account)}: {Account}, {nameof(ModelCode)}: {ModelCode}, {nameof(Key)}: {Key}, {nameof(Value)}: {Value}, {nameof(Currency)}: {Currency}";
        }
    }
}