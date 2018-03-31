using System;
using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class MarketRuleEventArgs : EventArgs
    {
        public MarketRuleEventArgs(int marketRuleId, PriceIncrement[] priceIncrements)
        {
            MarketruleId = marketRuleId;
            PriceIncrements = priceIncrements;
        }

        public int MarketruleId { get; }
        public PriceIncrement[] PriceIncrements { get; }

        public override string ToString()
        {
            return $"{nameof(MarketruleId)}: {MarketruleId}, {nameof(PriceIncrements)}: {PriceIncrements}";
        }
    }
}