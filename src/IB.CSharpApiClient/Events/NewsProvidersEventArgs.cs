/* Copyright (C) 2017 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

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
