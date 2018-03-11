/* Copyright (C) 2017 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class MarketRuleEventArgs : EventArgs
    {
        public int MarketruleId { get; private set; }
        public PriceIncrement[] PriceIncrements { get; private set; }

        public MarketRuleEventArgs(int marketRuleId, PriceIncrement[] priceIncrements)
        {
            this.MarketruleId = marketRuleId;
            this.PriceIncrements = priceIncrements;
        }
    }
}
