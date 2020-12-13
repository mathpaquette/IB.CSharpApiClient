namespace IB.CSharpApiClient.Messages
{
    public class TickNewsMessage
    {
        public int TickerId { get; private set; }
        public long TimeStamp { get; private set; }
        public string ProviderCode { get; private set; }
        public string ArticleId { get; private set; }
        public string Headline { get; private set; }
        public string ExtraData { get; private set; }

        public TickNewsMessage(int tickerId, long timeStamp, string providerCode, string articleId, string headline, string extraData)
        {
            TickerId = tickerId;
            TimeStamp = timeStamp;
            ProviderCode = providerCode;
            ArticleId = articleId;
            Headline = headline;
            ExtraData = extraData;
        }

        public override string ToString()
        {
            return $"{nameof(TickerId)}: {TickerId}, {nameof(TimeStamp)}: {TimeStamp}, {nameof(ProviderCode)}: {ProviderCode}, {nameof(ArticleId)}: {ArticleId}, {nameof(Headline)}: {Headline}, {nameof(ExtraData)}: {ExtraData}";
        }
    }
}
