using System;

namespace IB.CSharpApiClient.Events
{
    public class TickNewsEventArgs : EventArgs
    {
        public TickNewsEventArgs(int tickerId, long timeStamp, string providerCode, string articleId, string headline, string extraData)
        {
            this.TickerId = tickerId;
            this.TimeStamp = timeStamp;
            this.ProviderCode = providerCode;
            this.ArticleId = articleId;
            this.Headline = headline;
            this.ExtraData = extraData;
        }

        public int TickerId { get; private set; }
        public long TimeStamp { get; private set; }
        public string ProviderCode { get; private set; }
        public string ArticleId { get; private set; }
        public string Headline { get; private set; }
        public string ExtraData { get; private set; }
    }
}
