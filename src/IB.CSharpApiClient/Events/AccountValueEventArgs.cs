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

        public string Key { get; }
        public string Value { get; }
        public string Currency { get; }
        public string AccountName { get; }

        public override string ToString()
        {
            return $"{nameof(Key)}: {Key}, {nameof(Value)}: {Value}, {nameof(Currency)}: {Currency}, {nameof(AccountName)}: {AccountName}";
        }
    }
}