using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class NewsProvidersEventArgs : EventArgs
    {
        public NewsProvider[] NewsProviders { get; private set; }

        public NewsProvidersEventArgs(NewsProvider[] newsProviders)
        {
            this.NewsProviders = newsProviders;
        }
    }
}
