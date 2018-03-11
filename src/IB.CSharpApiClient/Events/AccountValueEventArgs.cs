/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;

namespace IB.CSharpApiClient.Events
{
    public class AccountValueEventArgs : EventArgs
    {
        private string key;
        private string value;
        private string currency;
        private string accountName;

        public AccountValueEventArgs(string key, string value, string currency, string accountName)
        {
            Key = key;
            Value = value;
            Currency = currency;
            AccountName = accountName;
        }

        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        
        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }

    }
}
