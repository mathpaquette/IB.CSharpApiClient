/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;

namespace IB.CSharpApiClient.Events
{
    public class AccountSummaryEventArgs : EventArgs
    {
        private int requestId;
        private string account;
        private string tag;
        private string value;
        private string currency;

        public int RequestId
        {
            get { return requestId; }
            set { requestId = value; }
        }
        
        public string Account
        {
            get { return account; }
            set { account = value; }
        }
        
        public string Tag
        {
            get { return tag; }
            set { tag = value; }
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

        public AccountSummaryEventArgs(int requestId, string account, string tag, string value, string currency)
        {
            RequestId = requestId;
            Account = account;
            Tag = tag;
            Value = value;
            Currency = currency;
        }
    }
}
