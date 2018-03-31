using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class NewsProvidersEventArgs : EventArgs
    {
        public NewsProvidersEventArgs(NewsProvider[] newsProviders)
        {
            NewsProviders = newsProviders;
        }

        public NewsProvider[] NewsProviders { get; }

        public override string ToString()
        {
            return $"{nameof(NewsProviders)}: {NewsProviders}";
        }
    }
}