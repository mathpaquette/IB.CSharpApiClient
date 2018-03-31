using System;

namespace IB.CSharpApiClient.Events
{
    public class HistoricalNewsEventArgs : EventArgs
    {
        public HistoricalNewsEventArgs(int requestId, string time, string providerCode, string articleId, string headline)
        {
            RequestId = requestId;
            Time = time;
            ProviderCode = providerCode;
            ArticleId = articleId;
            Headline = headline;
        }

        public int RequestId { get; }
        public string Time { get; }
        public string ProviderCode { get; }
        public string ArticleId { get; }
        public string Headline { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(Time)}: {Time}, {nameof(ProviderCode)}: {ProviderCode}, {nameof(ArticleId)}: {ArticleId}, {nameof(Headline)}: {Headline}";
        }
    }
}