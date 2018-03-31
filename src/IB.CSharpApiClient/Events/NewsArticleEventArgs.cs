using System;

namespace IB.CSharpApiClient.Events
{
    public class NewsArticleEventArgs : EventArgs
    {
        public NewsArticleEventArgs(int requestId, int articleType, string articleText)
        {
            RequestId = requestId;
            ArticleType = articleType;
            ArticleText = articleText;
        }

        public int RequestId { get; }
        public int ArticleType { get; }
        public string ArticleText { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(ArticleType)}: {ArticleType}, {nameof(ArticleText)}: {ArticleText}";
        }
    }
}