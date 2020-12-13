namespace IB.CSharpApiClient.Messages
{
    public class NewsArticleMessage
    {
        public int RequestId { get; private set; }
        public int ArticleType { get; private set; }
        public string ArticleText { get; private set; }

        public NewsArticleMessage(int requestId, int articleType, string articleText)
        {
            RequestId = requestId;
            ArticleType = articleType;
            ArticleText = articleText;
        }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(ArticleType)}: {ArticleType}, {nameof(ArticleText)}: {ArticleText}";
        }
    }
}
