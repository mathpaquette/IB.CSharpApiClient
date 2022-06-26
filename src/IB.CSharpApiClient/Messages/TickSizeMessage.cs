namespace IB.CSharpApiClient.Messages
{
    public class TickSizeMessage : MarketDataMessage
    {
        public decimal Size { get; private set; }

        public TickSizeMessage(int requestId, int field, decimal size) : base(requestId, field)
        {
            Size = size;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Size)}: {Size}";
        }
    }
}
