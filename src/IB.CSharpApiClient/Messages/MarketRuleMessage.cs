using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class MarketRuleMessage
    {
        public int MarketRuleId { get; private set; }
        public PriceIncrement[] PriceIncrements { get; private set; }

        public MarketRuleMessage(int marketRuleId, PriceIncrement[] priceIncrements)
        {
            MarketRuleId = marketRuleId;
            PriceIncrements = priceIncrements;
        }

        public override string ToString()
        {
            return $"{nameof(MarketRuleId)}: {MarketRuleId}, {nameof(PriceIncrements)}: {PriceIncrements}";
        }
    }
}
