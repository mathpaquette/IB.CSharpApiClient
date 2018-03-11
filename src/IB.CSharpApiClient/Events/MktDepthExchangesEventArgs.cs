/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;

namespace IB.CSharpApiClient.Events
{
    public class MktDepthExchangesEventArgs : EventArgs
    {
        public IBApi.DepthMktDataDescription[] Descriptions { get; private set; }

        public MktDepthExchangesEventArgs(IBApi.DepthMktDataDescription[] descriptions)
        {
            this.Descriptions = descriptions;
        }
    }
}
