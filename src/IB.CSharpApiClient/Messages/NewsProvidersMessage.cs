using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class NewsProvidersMessage
    {
        public NewsProvider[] NewsProviders { get; private set; }

        public NewsProvidersMessage(NewsProvider[] newsProviders)
        {
            NewsProviders = newsProviders;
        }

        public override string ToString()
        {
            return $"{nameof(NewsProviders)}: {NewsProviders}";
        }
    }
}
