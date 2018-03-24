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
