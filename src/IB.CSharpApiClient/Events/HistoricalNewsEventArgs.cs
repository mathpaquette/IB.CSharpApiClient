/* Copyright (C) 2017 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalNewsEventArgs : EventArgs
    {
        public int RequestId { get; private set; }
        public string Time { get; private set; }
        public string ProviderCode { get; private set; }
        public string ArticleId { get; private set; }
        public string Headline { get; private set; }

        public HistoricalNewsEventArgs(int requestId, string time, string providerCode, string articleId, string headline)
        {
            this.RequestId = requestId;
            this.Time = time;
            this.ProviderCode = providerCode;
            this.ArticleId = articleId;
            this.Headline = headline;
        }
    }
}
