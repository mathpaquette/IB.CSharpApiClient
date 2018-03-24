using System;

namespace IB.CSharpApiClient.Events
{
    public class AccountValueEventArgs : EventArgs
    {
        public AccountValueEventArgs(string key, string value, string currency, string accountName)
        {
            Key = key;
            Value = value;
            Currency = currency;
            AccountName = accountName;
        }

        public string Key { get; private set; }

        public string Value { get; private set; }

        public string Currency { get; private set; }

        public string AccountName { get; private set; }
    }
}
