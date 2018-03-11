/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;

namespace IB.CSharpApiClient.Events
{
    public class AccountUpdateMultiEventArgs : EventArgs
    {
        private int reqId;
        private string account;
        private string modelCode;
        private string key;
        private string value;
        private string currency;
        
        public AccountUpdateMultiEventArgs(int reqId, string account, string modelCode, string key, string value, string currency)
        {
            Account = account;
            ModelCode = modelCode;
            Key = key;
            Value = value;
            Currency = currency;
        }

        public int ReqId
        {
            get { return reqId; }
            set { reqId = value; }
        }

        public string Account
        {
            get { return account; }
            set { account = value; }
        }

        public string ModelCode
        {
            get { return modelCode; }
            set { modelCode = value; }
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

    }
}
