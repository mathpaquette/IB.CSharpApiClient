/* Copyright (C) 2017 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;

namespace IB.CSharpApiClient.Events
{
    public class NewsArticleEventArgs : EventArgs
    {
        public int RequestId { get; private set; }
        public int ArticleType { get; private set; }
        public string ArticleText { get; private set; }

        public NewsArticleEventArgs(int requestId, int articleType, string articleText)
        {
            this.RequestId = requestId;
            this.ArticleType = articleType;
            this.ArticleText = articleText;
        }
    }
}
