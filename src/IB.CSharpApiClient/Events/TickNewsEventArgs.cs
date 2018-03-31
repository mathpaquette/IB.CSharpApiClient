using System;

namespace IB.CSharpApiClient.Events
{
    public class TickNewsEventArgs : EventArgs
    {
        public TickNewsEventArgs(int tickerId, long timeStamp, string providerCode, string articleId, string headline, string extraData)
        {
            TickerId = tickerId;
            TimeStamp = timeStamp;
            ProviderCode = providerCode;
            ArticleId = articleId;
            Headline = headline;
            ExtraData = extraData;
        }

        public int TickerId { get; }
        public long TimeStamp { get; }
        public string ProviderCode { get; }
        public string ArticleId { get; }
        public string Headline { get; }
        public string ExtraData { get; }

        public override string ToString()
        {
            return $"{nameof(ArticleId)}: {ArticleId}, {nameof(ExtraData)}: {ExtraData}, {nameof(Headline)}: {Headline}, {nameof(ProviderCode)}: {ProviderCode}, {nameof(TickerId)}: {TickerId}, {nameof(TimeStamp)}: {TimeStamp}";
        }
    }
}