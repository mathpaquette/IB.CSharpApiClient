using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class TickPriceMessage : MarketDataMessage
    {
        public TickAttrib Attribs { get; private set; }
        public double Price { get; private set; }

        public TickPriceMessage(int requestId, int field, double price, TickAttrib attribs)
            : base(requestId, field)
        {
            Price = price;
            Attribs = attribs;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Attribs)}: {Attribs}, {nameof(Price)}: {Price}";
        }
    }
}
