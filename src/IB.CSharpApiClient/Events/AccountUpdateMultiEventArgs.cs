using System;

namespace IB.CSharpApiClient.Events
{
    public class AccountUpdateMultiEventArgs : EventArgs
    {
        public AccountUpdateMultiEventArgs(int reqId, string account, string modelCode, string key, string value, string currency)
        {
            ReqId = reqId;
            Account = account;
            ModelCode = modelCode;
            Key = key;
            Value = value;
            Currency = currency;
        }

        public int ReqId { get; private set; }

        public string Account { get; private set; }

        public string ModelCode { get; private set; }

        public string Key { get; private set; }

        public string Value { get; private set; }

        public string Currency { get; private set; }
    }
}
