namespace IB.CSharpApiClient.Messages
{
    public class TickSizeMessage : MarketDataMessage
    {
        public int Size { get; private set; }

        public TickSizeMessage(int requestId, int field, int size) : base(requestId, field)
        {
            Size = size;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Size)}: {Size}";
        }
    }
}
