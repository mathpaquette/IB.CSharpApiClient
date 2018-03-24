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
