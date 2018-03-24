using IBApi;

namespace IB.CSharpApiClient.Events
{
    public class TickPriceEventArgs : MarketDataEventArgs
    {
        public TickPriceEventArgs(int requestId, int field, double price, TickAttrib attribs)
            : base(requestId, field)
        {
            Price = price;
            Attribs = attribs;
        }

        public TickAttrib Attribs { get; private set; }
        public double Price { get; private set; }
    }
}
